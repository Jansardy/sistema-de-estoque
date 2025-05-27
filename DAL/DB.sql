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
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2025-05-27 16:45:30
