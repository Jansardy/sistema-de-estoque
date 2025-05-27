-- MySQL dump 10.13  Distrib 8.0.41, for Win64 (x86_64)
--
-- Host: localhost    Database: estoquedb
-- ------------------------------------------------------
-- Server version	8.0.41

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `fornecedores`
--

DROP TABLE IF EXISTS `fornecedores`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `fornecedores` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `Nome` varchar(100) NOT NULL,
  `Contato` varchar(100) NOT NULL,
  `Endereco` text,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `fornecedores`
--

LOCK TABLES `fornecedores` WRITE;
/*!40000 ALTER TABLE `fornecedores` DISABLE KEYS */;
INSERT INTO `fornecedores` VALUES (1,'Tech Supplies Ltda','contato@techsupplies.com','Rua A, 123 - SP'),(2,'Supermercado Brasil','(21) 98765-4321','Rua das Flores, 123, Rio de Janeiro, RJ'),(3,'Bebidas da Serra','(21) 98765-1234','Av. das Américas, 500, Barra da Tijuca, Rio de Janeiro, RJ'),(4,'Tecnologia & Cia','(11) 98765-6789','Rua dos Alfeneiros, 1000, São Paulo, SP'),(5,'Jeans & Cia','(  )      -','Rua do Comércio, 500, Belo Horizonte, MG'),(6,'Produtos de Limpeza Oliveira','(21) 98765-9876','Rua Padre Miguel, 200, Rio de Janeiro, RJ'),(7,'Móveis Lar','(21) 99988-7654','Av. das Indústrias, 1200, São João de Meriti, RJ'),(8,'Papelaria Central','(11) 99988-1122','Rua dos Três Irmãos, 400, São Paulo, SP');
/*!40000 ALTER TABLE `fornecedores` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `movimentacao_estoque`
--

DROP TABLE IF EXISTS `movimentacao_estoque`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `movimentacao_estoque` (
  `id` int NOT NULL AUTO_INCREMENT,
  `produto_id` int NOT NULL,
  `tipo` enum('Entrada','Saída') NOT NULL,
  `quantidade` int NOT NULL,
  `data_movimentacao` datetime DEFAULT CURRENT_TIMESTAMP,
  `usuario_id` int NOT NULL,
  `fornecedor_id` int DEFAULT NULL,
  `motivo` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `produto_id` (`produto_id`),
  KEY `usuario_id` (`usuario_id`),
  KEY `fornecedor_id` (`fornecedor_id`),
  CONSTRAINT `movimentacao_estoque_ibfk_1` FOREIGN KEY (`produto_id`) REFERENCES `produtos` (`ID`),
  CONSTRAINT `movimentacao_estoque_ibfk_2` FOREIGN KEY (`usuario_id`) REFERENCES `usuarios` (`ID`),
  CONSTRAINT `movimentacao_estoque_ibfk_3` FOREIGN KEY (`fornecedor_id`) REFERENCES `fornecedores` (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=17 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `movimentacao_estoque`
--

LOCK TABLES `movimentacao_estoque` WRITE;
/*!40000 ALTER TABLE `movimentacao_estoque` DISABLE KEYS */;
INSERT INTO `movimentacao_estoque` VALUES (1,2,'Entrada',15,'2005-05-18 00:00:00',1,3,NULL),(2,2,'Saída',15,'2005-05-18 00:00:00',1,NULL,NULL),(3,1,'Entrada',15,'2025-04-15 08:26:30',2,3,NULL),(4,4,'Saída',4,'2025-04-16 14:35:39',1,NULL,NULL),(5,7,'Saída',6,'2025-04-16 14:50:15',11,NULL,NULL),(6,7,'Entrada',6,'2025-04-16 14:50:21',11,7,NULL),(7,3,'Entrada',5,'2025-04-17 14:53:52',1,3,NULL),(8,9,'Entrada',6,'2025-04-17 15:00:11',6,4,NULL),(9,9,'Entrada',6,'2025-04-17 15:00:15',6,4,NULL),(10,9,'Entrada',3,'2025-04-17 15:01:18',6,4,NULL),(11,3,'Entrada',3,'2025-04-21 11:23:46',1,3,NULL),(12,3,'Entrada',100,'2025-04-21 11:24:30',6,3,NULL),(13,3,'Saída',4,'2025-04-22 17:00:23',1,NULL,'Venda'),(14,9,'Entrada',4500,'2025-04-22 17:08:47',6,4,NULL),(15,9,'Saída',4500,'2025-04-22 17:09:33',6,NULL,'Devolução ao fornecedor'),(16,7,'Saída',21,'2025-05-21 18:22:55',1,NULL,'Venda');
/*!40000 ALTER TABLE `movimentacao_estoque` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `produtos`
--

DROP TABLE IF EXISTS `produtos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `produtos` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `Nome` varchar(100) NOT NULL,
  `Categoria` enum('Alimentos','Bebidas','Eletrônicos','Vestuário','Limpeza','Móveis','Papelaria') NOT NULL,
  `Quantidade` int NOT NULL,
  `Preco` decimal(10,2) NOT NULL,
  `FornecedorID` int DEFAULT NULL,
  PRIMARY KEY (`ID`),
  KEY `FornecedorID` (`FornecedorID`),
  CONSTRAINT `produtos_ibfk_1` FOREIGN KEY (`FornecedorID`) REFERENCES `fornecedores` (`ID`) ON DELETE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=39 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `produtos`
--

LOCK TABLES `produtos` WRITE;
/*!40000 ALTER TABLE `produtos` DISABLE KEYS */;
INSERT INTO `produtos` VALUES (1,'Cabo HDMI','Eletrônicos',150,25.00,1),(2,'Arroz 5kg','Alimentos',192,19.90,2),(3,'Refrigerante de Laranja 1L','Bebidas',238,4.50,3),(4,'Computador Desktop','Eletrônicos',46,2800.00,4),(5,'Calça Jeans Masculina','Vestuário',125,89.90,5),(6,'Detergente Líquido 500ml','Limpeza',300,3.00,6),(7,'Sofá 3 Lugares','Móveis',19,900.00,7),(8,'Caneta Azul','Papelaria',500,3.00,8),(9,'Placa Mae Pichau B550M K, DDR4, Socket AMD AM4, M-ATX, Chipset AMD B550, B550M-K-1P','Eletrônicos',32,499.99,4),(10,'Arroz Tio João 5kg','Alimentos',100,18.50,2),(11,'Feijão Carioca 1kg','Alimentos',150,7.20,2),(12,'Macarrão Espaguete 500g','Alimentos',120,3.80,2),(13,'Azeite Extra Virgem 500ml','Alimentos',80,22.90,2),(14,'Refrigerante Coca-Cola 2L','Bebidas',200,8.90,3),(15,'Suco de Laranja Natural 1L','Bebidas',180,6.50,3),(16,'Água Mineral 500ml','Bebidas',300,1.00,3),(17,'Cerveja Heineken 600ml','Bebidas',250,6.80,3),(18,'Mouse Logitech M170','Eletrônicos',50,49.90,1),(19,'Teclado Mecânico Redragon','Eletrônicos',30,159.00,1),(20,'Monitor Samsung 24\"','Eletrônicos',20,899.90,4),(21,'Notebook Lenovo i5 8GB','Eletrônicos',10,2999.00,4),(22,'Camiseta Básica Branca G','Vestuário',100,25.00,5),(23,'Calça Jeans Slim 42','Vestuário',60,79.90,5),(24,'Jaqueta Corta Vento P','Vestuário',40,129.90,5),(25,'Tênis Esportivo 40','Vestuário',70,149.90,5),(26,'Sabão em Pó OMO 1kg','Limpeza',90,9.50,6),(27,'Desinfetante Pinho 1L','Limpeza',110,4.75,6),(28,'Detergente Ypê Neutro 500ml','Limpeza',200,2.30,6),(29,'Esponja Multiuso','Limpeza',250,1.10,6),(30,'Cadeira de Escritório Ergonômica','Móveis',15,399.90,7),(31,'Mesa de Jantar 4 Lugares','Móveis',10,749.00,7),(33,'Estante de Livros 5 Prateleiras','Móveis',12,249.90,7),(34,'Caderno Universitário 200 folhas','Papelaria',120,14.90,8),(35,'Caneta Esferográfica Azul','Papelaria',500,1.20,8),(36,'Lápis de Cor 24 cores','Papelaria',70,12.90,8),(37,'Papel Sulfite A4 500 folhas','Papelaria',80,21.00,8),(38,'Kit Upgrade - Intel Core i5-3470 + Placa Mãe B75 Lga 1155 + 16GB Ram DDR3','Eletrônicos',85,389.99,4);
/*!40000 ALTER TABLE `produtos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuarios`
--

DROP TABLE IF EXISTS `usuarios`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `usuarios` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `Nome` varchar(100) DEFAULT NULL,
  `Login` varchar(50) NOT NULL,
  `Senha` varchar(255) NOT NULL,
  `NivelAcesso` enum('Admin','Vendedor') NOT NULL,
  PRIMARY KEY (`ID`),
  UNIQUE KEY `Login` (`Login`)
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuarios`
--

LOCK TABLES `usuarios` WRITE;
/*!40000 ALTER TABLE `usuarios` DISABLE KEYS */;
INSERT INTO `usuarios` VALUES (1,'Admin','admin','8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92','Admin'),(2,'Jonas Richard','Jonas','d139aec8adab7ea14d744312e8a87c71f398e88b45dca6dc0547faf252769d6e','Vendedor'),(6,'teste','testess','d85bab5a59545850fa4c83a758ddc20428c823f03f5a63e16919aa3ce3c7909f','Vendedor'),(11,'Jonas1','Jonas1','5056a33ae88b34693e61bf87bbc6c9719e0010f2500345acadfbbc9c4924dd4b','Vendedor'),(13,'John','John18','5db6c89dee045111584e2defb6b164c8f24dd793aeddcb505fe92a9edffb839c','Admin');
/*!40000 ALTER TABLE `usuarios` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping routines for database 'estoquedb'
--
/*!50003 DROP PROCEDURE IF EXISTS `BuscarFornecedores` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `BuscarFornecedores`(
	IN p_Nome VARCHAR(100)
)
BEGIN
	SELECT * FROM Fornecedores
    WHERE Nome LIKE CONCAT('%', p_Nome, '%')
    ORDER BY Nome ASC;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `BuscarProdutos` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `BuscarProdutos`(
    IN p_Nome VARCHAR(100),
    IN p_Categoria VARCHAR(100)
)
BEGIN
    SELECT * FROM Produtos
    WHERE (p_Nome = '' OR Nome LIKE CONCAT('%', p_Nome, '%'))
      AND (p_Categoria = '-1' OR p_Categoria = '' OR Categoria LIKE CONCAT('%', p_Categoria, '%'))
    ORDER BY Nome ASC;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `BuscarUsuarios` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `BuscarUsuarios`(
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
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `DeletarFornecedor` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `DeletarFornecedor`(
	IN p_ID INT
)
BEGIN
	DELETE FROM Fornecedores WHERE ID = p_ID;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `DeletarProdutos` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `DeletarProdutos`(
	IN p_ID INT
)
BEGIN
    DECLARE CONTINUE HANDLER FOR SQLEXCEPTION
    BEGIN
        -- Caso ocorra um erro, você pode adicionar lógica para tratá-lo
        SELECT 'Erro ao deletar o produto' AS mensagem_erro;
    END;

    DELETE FROM Produtos WHERE ID = p_ID;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `DeletarUsuario` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `DeletarUsuario`(
    IN p_ID INT
)
BEGIN
    DELETE FROM Usuarios WHERE ID = p_ID;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `EditarFornecedor` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `EditarFornecedor`(
	IN p_ID INT,
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
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `EditarProdutos` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `EditarProdutos`(
	IN p_ID INT,
    IN p_Nome VARCHAR(100),
    IN p_Categoria VARCHAR(50), -- ⚠️ Troquei ENUM por VARCHAR(50)
    IN p_Quantidade INT,
    IN p_Preco DECIMAL(10,2),
    IN p_FornecedorID INT
)
BEGIN
	UPDATE Produtos
    SET 
        Nome = COALESCE(NULLIF(p_Nome, ''), Nome),
        Categoria = IF(
            p_Categoria IS NOT NULL AND p_Categoria <> '' 
            AND FIND_IN_SET(p_Categoria, 'Alimentos,Bebidas,Eletrônicos,Vestuário,Limpeza,Móveis,Papelaria'),
            p_Categoria, Categoria),
        Quantidade = COALESCE(NULLIF(p_Quantidade, 0), Quantidade),
        Preco = COALESCE(NULLIF(p_Preco, 0), Preco),
        FornecedorID = COALESCE(NULLIF(p_FornecedorID, 0), FornecedorID)
    WHERE ID = p_ID;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `EditarUsuario` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `EditarUsuario`(
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
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `EntradaEstoque` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `EntradaEstoque`(
    IN p_ProdutoID INT,
    IN p_Quantidade INT,
    IN p_FornecedorID INT,
    IN p_UsuarioID INT,
    IN p_Tipo VARCHAR(10)
)
BEGIN

    IF p_Tipo <> 'Entrada' THEN
        SIGNAL SQLSTATE '45000'
        SET MESSAGE_TEXT = 'Tipo inválido: utilize "Entrada" como tipo nesta procedure.';
    END IF;

    IF p_Quantidade <= 0 THEN
        SIGNAL SQLSTATE '45000'
        SET MESSAGE_TEXT = 'Quantidade inválida: deve ser maior que zero.';
    END IF;

    IF NOT EXISTS (SELECT 1 FROM produtos WHERE ID = p_ProdutoID) THEN
        SIGNAL SQLSTATE '45000'
        SET MESSAGE_TEXT = 'Produto não encontrado.';
    END IF;

    IF NOT EXISTS (SELECT 1 FROM fornecedores WHERE ID = p_FornecedorID) THEN
        SIGNAL SQLSTATE '45000'
        SET MESSAGE_TEXT = 'Fornecedor não encontrado.';
    END IF;

    UPDATE produtos
    SET Quantidade = Quantidade + p_Quantidade
    WHERE ID = p_ProdutoID;

    INSERT INTO movimentacao_estoque (
        produto_id, tipo, quantidade, data_movimentacao, usuario_id, fornecedor_id
    )
    VALUES (
        p_ProdutoID, p_Tipo, p_Quantidade, NOW(), p_UsuarioID, p_FornecedorID
    );
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `InserirFornecedor` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `InserirFornecedor`(
	IN p_Nome VARCHAR(100),
    IN p_Contato VARCHAR(100),
    IN p_Endereco TEXT
)
BEGIN
	INSERT INTO Fornecedores (Nome, Contato, Endereco)
    VALUES (p_Nome, p_Contato, p_Endereco);
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `InserirProdutos` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `InserirProdutos`(
	IN p_Nome VARCHAR(100),
    IN p_Categoria ENUM('Alimentos', 'Bebidas', 'Eletrônicos', 'Vestuário', 'Limpeza', 'Móveis', 'Papelaria'),
    IN p_Quantidade INT,
    IN p_Preco DECIMAL(10,2),
    IN p_FornecedorID INT
)
BEGIN
	INSERT INTO Produtos(Nome, Categoria, Quantidade, Preco, FornecedorID)
    VALUES(p_Nome, p_Categoria, p_Quantidade, p_Preco, p_FornecedorID);
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `InserirUsuario` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `InserirUsuario`(
    IN p_Nome VARCHAR(100),
    IN p_Login VARCHAR(50),
    IN p_Senha VARCHAR(255),
    IN p_NivelAcesso ENUM('Admin', 'Vendedor')
)
BEGIN
    INSERT INTO Usuarios (Nome, Login, Senha, NivelAcesso)
    VALUES (p_Nome, p_Login, sha2(p_Senha, 256), p_NivelAcesso);
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `RelatorioProdutos` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `RelatorioProdutos`(
	IN p_Nomee VARCHAR(100),
    IN p_Categorias VARCHAR(100)
)
BEGIN 
    SELECT
        p.ID AS ID,
        p.Nome AS NomeProduto,
        p.Quantidade AS Quantidade,
        p.Categoria AS Categoria,
        p.Preco AS Preco,
        f.Nome AS Fornecedor
    FROM
        produtos p
    INNER JOIN fornecedores f ON p.FornecedorID = f.ID
    WHERE (p_Nomee = '' OR p.Nome LIKE CONCAT('%', p_Nomee, '%'))
      AND (p_Categorias = '' OR p.Categoria LIKE CONCAT('%', p_Categorias, '%'))
    ORDER BY p.Nome ASC;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `SaidaEstoque` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `SaidaEstoque`(
    IN p_ProdutoID INT,
    IN p_Quantidade INT,
    IN p_UsuarioID INT,
    IN p_Tipo VARCHAR(10),
    IN p_Motivo VARCHAR(100)
)
BEGIN
    IF p_Tipo <> 'Saída' THEN
        SIGNAL SQLSTATE '45000'
        SET MESSAGE_TEXT = 'Tipo inválido: utilize "Saída" como tipo nesta procedure.';
    END IF;

    IF p_Quantidade <= 0 THEN
        SIGNAL SQLSTATE '45000'
        SET MESSAGE_TEXT = 'Quantidade inválida: deve ser maior que zero.';
    END IF;

    IF NOT EXISTS (SELECT 1 FROM produtos WHERE ID = p_ProdutoID) THEN
        SIGNAL SQLSTATE '45000'
        SET MESSAGE_TEXT = 'Produto não encontrado.';
    END IF;

    IF (SELECT Quantidade FROM produtos WHERE ID = p_ProdutoID) < p_Quantidade THEN
        SIGNAL SQLSTATE '45000'
        SET MESSAGE_TEXT = 'Estoque insuficiente para esta operação.';
    END IF;

    UPDATE produtos
    SET Quantidade = Quantidade - p_Quantidade
    WHERE ID = p_ProdutoID;

    INSERT INTO movimentacao_estoque (
        produto_id, tipo, quantidade, data_movimentacao, usuario_id, motivo
    )
    VALUES (
        p_ProdutoID, p_Tipo, p_Quantidade, NOW(), p_UsuarioID, p_Motivo
    );
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_ValidarLogin` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_ValidarLogin`(
    IN p_Usuario VARCHAR(50),
    IN p_Senha VARCHAR(255)
)
BEGIN
    DECLARE v_Nome VARCHAR(100);
    DECLARE v_NivelAcesso ENUM('Admin', 'Vendedor');
    DECLARE v_SenhaHashed VARCHAR(256);

    SET v_SenhaHashed = SHA2(p_Senha, 256);

    SELECT Nome, NivelAcesso
    INTO v_Nome, v_NivelAcesso
    FROM Usuarios 
    WHERE Login = p_Usuario AND Senha = v_SenhaHashed;

    IF v_Nome IS NOT NULL THEN
        SELECT 'SUCESSO' AS status, v_Nome AS Nome, v_NivelAcesso AS NivelAcesso;
    ELSE
        SELECT 'FALHA' AS status, NULL AS Nome, NULL AS NivelAcesso;
    END IF;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2025-05-27 16:49:36
