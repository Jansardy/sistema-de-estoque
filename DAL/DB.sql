CREATE DATABASE EstoqueDB;
USE estoquedb;

CREATE TABLE Fornecedores (
	ID INT AUTO_INCREMENT PRIMARY KEY,
    Nome VARCHAR(100) NOT NULL,
    Contato VARCHAR(100) NOT NULL,
    Endereco TEXT
);
select * from Fornecedores;
insert into Fornecedores(Nome, Contato, Endereco)
Values ('Tech Supplies Ltda', 'contato@techsupplies.com', 'Rua A, 123 - SP');

CREATE TABLE Produtos (
    ID INT AUTO_INCREMENT PRIMARY KEY,
    Nome VARCHAR(100) NOT NULL,
    Categoria VARCHAR(100),
    Quantidade INT NOT NULL,
    Preco DECIMAL(10,2) NOT NULL,
    FornecedorID INT,
    FOREIGN KEY (FornecedorID) REFERENCES Fornecedores(ID) ON DELETE CASCADE
);
select * from Produtos;
INSERT INTO Produtos (Nome, Categoria, Quantidade, Preco, FornecedorID)
VALUES ('Teclado Gamer', 'Eletrônicos', 10, 150.00, 1);


CREATE TABLE Usuarios (
	ID INT AUTO_INCREMENT PRIMARY KEY,
    Nome VARCHAR(100),
    Login VARCHAR(50) UNIQUE NOT NULL,
    Senha VARCHAR(255) NOT NULL,
    NivelAcesso ENUM('Admin','Vendedor') NOT NULL
);
INSERT INTO Usuarios (Nome, Login, Senha, NivelAcesso)
VALUES ('Admin', 'admin', sha2('123456', 256), 'Admin');

DELIMITER $$
CREATE PROCEDURE InserirProdutos(
	IN p_Nome VARCHAR(100),
    IN p_Categoria VARCHAR(100),
    IN p_Quantidade INT,
    IN p_Preco DECIMAL(10,2),
    IN p_FornecedorID INT
)
BEGIN
	INSERT INTO Produtos(Nome, Categoria, Quantidade, Preco, FornecedorID)
    VALUES(p_Nome, p_Categoria, p_Quantidade, p_Preco, p_FornecedorID);
END $$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE BuscarProdutos(
	IN p_Nome VARCHAR(100),
    IN p_Categoria VARCHAR(100)
)
BEGIN
	IF p_Nome <> '' THEN
		SELECT * FROM Produtos 
        WHERE Nome LIKE CONCAT('%', p_Nome, '%')
        ORDER BY Nome ASC;
	ELSE
		SELECT * FROM Produtos 
        WHERE Categoria LIKE CONCAT('%', p_Categoria, '%')
        ORDER BY Nome ASC;
	END IF;
END $$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE EditarProdutos(
	IN p_ID INT,
    IN p_Nome VARCHAR(100),
    IN p_Categoria VARCHAR(100),
    IN p_Quantidade INT,
    IN p_Preco DECIMAL(10,2),
    IN p_FornecedorID INT
)
BEGIN
	UPDATE Produtos
    SET 
        Nome = COALESCE(NULLIF(p_Nome, ''), Nome),
        Categoria = COALESCE(NULLIF(p_Categoria, ''), Categoria),
        Quantidade = COALESCE(NULLIF(p_Quantidade, 0), Quantidade),
        Preco = COALESCE(NULLIF(p_Preco, 0), Preco),
        FornecedorID = COALESCE(NULLIF(p_FornecedorID, 0), FornecedorID)
    WHERE ID = p_ID;
END $$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE DeletarProdutos(
	IN p_ID INT
)
BEGIN
    DECLARE CONTINUE HANDLER FOR SQLEXCEPTION
    BEGIN
        -- Caso ocorra um erro, você pode adicionar lógica para tratá-lo
        SELECT 'Erro ao deletar o produto' AS mensagem_erro;
    END;

    DELETE FROM Produtos WHERE ID = p_ID;
END $$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE InserirFornecedor(
	IN p_Nome VARCHAR(100),
    IN p_Contato VARCHAR(100),
    IN p_Endereco TEXT
)
BEGIN
	INSERT INTO Fornecedores (Nome, Contato, Endereco)
    VALUES (p_Nome, p_Contato, p_Endereco);
END $$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE BuscarFornecedores(
	IN p_Nome VARCHAR(100)
)
BEGIN
	SELECT * FROM Fornecedores
    WHERE Nome LIKE CONCAT('%', p_Nome, '%')
    ORDER BY Nome ASC;
END $$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE EditarFornecedor(
    IN p_Nome VARCHAR(100),
    IN p_Contato VARCHAR(100),
    IN p_Endereco TEXT
)
BEGIN
	UPDATE Fornecedores
    SET
		Nome = COALESCE(NULLIF(p_Nome, ''), Nome),
        Contato = COALESCE(NULLIF(p_Contato, ''), Contato),
        Endereco = COALESCE(NULLIF(p_Endereco, ''), Endereco)
    WHERE ID = p_ID;
END $$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE DeletarFornecedor(
	IN p_ID INT
)
BEGIN
	DELETE FROM Fornecedores WHERE ID = p_ID;
END $$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE InserirUsuario(
    IN p_Nome VARCHAR(100),
    IN p_Login VARCHAR(50),
    IN p_Senha VARCHAR(255),
    IN p_NivelAcesso ENUM('Admin', 'Vendedor')
)
BEGIN
    INSERT INTO Usuarios (Nome, Login, Senha, NivelAcesso)
    VALUES (p_Nome, p_Login, sha2(p_Senha, 256), p_NivelAcesso);
END $$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE BuscarUsuarios(
    IN p_Nome VARCHAR(100),
    IN p_Login VARCHAR(50)
)
BEGIN
    IF p_Nome <> '' THEN
		SELECT * FROM Usuarios WHERE Nome LIKE CONCAT('%', p_Nome, '%');
	ELSEIF p_Login <> '' THEN
		SELECT * FROM Usuarios WHERE Login LIKE CONCAT('%', p_Login, '%');
	ELSE
		SELECT * FROM Usuarios; -- Retorna todos os usuários se não houver filtro
	END IF;
END $$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE EditarUsuario(
    IN p_ID INT,
    IN p_Nome VARCHAR(100),
    IN p_Login VARCHAR(50),
    IN p_Senha VARCHAR(255),
    IN p_NivelAcesso ENUM('Admin', 'Vendedor')
)
BEGIN
    DECLARE new_Senha VARCHAR(255);
    
    IF p_Senha <> '' THEN
        SET new_Senha = sha2(p_Senha, 256);
    ELSE
        SET new_Senha = (SELECT Senha FROM Usuarios WHERE ID = p_ID); -- Mantém a senha existente
    END IF;

    UPDATE Usuarios
    SET 
        Nome = COALESCE(NULLIF(p_Nome, ''), Nome),
        Login = COALESCE(NULLIF(p_Login, ''), Login),
        Senha = new_Senha,
        NivelAcesso = COALESCE(NULLIF(p_NivelAcesso, ''), NivelAcesso)
    WHERE ID = p_ID;
END $$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE DeletarUsuario(
    IN p_ID INT
)
BEGIN
    DELETE FROM Usuarios WHERE ID = p_ID;
END $$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE sp_ValidarLogin(
	IN p_Usuario VARCHAR(50),
    IN p_Senha VARCHAR(255)
)
BEGIN
    DECLARE v_Count INT;
    
    SELECT COUNT(*) INTO v_Count
    FROM Usuarios
    WHERE Login = p_Usuario AND Senha = p_Senha;
    
    IF v_Count > 0 THEN
        SELECT 'SUCESSO' AS status;
    ELSE
        SELECT 'FALHA' AS status;
    END IF;
END //
DELIMITER ;
