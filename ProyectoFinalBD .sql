-- MySQL dump 10.13  Distrib 8.0.19, for Win64 (x86_64)
--
-- Host: localhost    Database: proyectobd
-- ------------------------------------------------------
-- Server version	8.0.19

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `carrito`
--

DROP TABLE IF EXISTS `carrito`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `carrito` (
  `idCarrito` int NOT NULL AUTO_INCREMENT,
  `idUsuario` int NOT NULL,
  `nombreprod` varchar(35) NOT NULL,
  `FechaCompra` datetime NOT NULL,
  PRIMARY KEY (`idCarrito`),
  KEY `usuario` (`idUsuario`),
  CONSTRAINT `carrito_ibfk_1` FOREIGN KEY (`idUsuario`) REFERENCES `usuario` (`IdUsuario`)
) ENGINE=InnoDB AUTO_INCREMENT=70 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `carrito`
--

LOCK TABLES `carrito` WRITE;
/*!40000 ALTER TABLE `carrito` DISABLE KEYS */;
INSERT INTO `carrito` VALUES (5,5,'MATE CANTIMPLORA M1','2020-11-26 17:04:58'),(6,5,'MATE CANTIMPLORA M1','2020-11-26 17:04:58'),(7,5,'RAYO MCQUEEN CANTIMPLORA M1','2020-11-26 17:07:35'),(8,5,'PAW PATROL ROJO','2020-11-26 17:07:37'),(9,5,'I NEED SPACE','2020-11-26 17:07:38'),(10,5,'PAW PATROL ROJO','2020-11-26 17:07:39'),(11,5,'MATE CANTIMPLORA M1','2020-11-26 17:07:41'),(12,5,'MATE CANTIMPLORA M1','2020-11-26 17:07:42'),(13,5,'SOCK DART','2020-11-26 17:08:19'),(14,5,'SOCK DART','2020-11-26 17:08:20'),(15,5,'NIKE XP','2020-11-26 17:08:21'),(16,5,'NIKE XP','2020-11-26 17:08:22'),(17,5,'MATE CANTIMPLORA M1','2020-11-26 17:18:07'),(18,5,'MATE CANTIMPLORA M1','2020-11-26 17:18:08'),(19,5,'THOR','2020-11-26 17:18:08'),(20,5,'THOR','2020-11-26 17:18:09'),(21,5,'PAW PATROL CHUPON','2020-11-26 17:18:10'),(22,5,'PAW PATROL CHUPON','2020-11-26 17:18:10'),(23,5,'MATE CANTIMPLORA M1','2020-11-29 00:50:11'),(24,5,'THOR','2020-11-29 00:50:12'),(25,5,'RAYO MCQUEEN CANTIMPLORA M1','2020-11-29 00:50:14'),(26,5,'I NEED SPACE','2020-11-29 00:50:15'),(27,5,'I NEED SPACE','2020-11-29 00:50:15'),(28,5,'BOTELLA REY LEON','2020-11-29 00:50:17'),(29,5,'NIKE 1070 6','2020-11-29 00:50:19'),(30,5,'PUMA','2020-11-29 00:50:20'),(31,5,'PUMA','2020-11-29 00:50:21'),(32,5,'SOCK DART','2020-11-29 00:50:22'),(33,5,'SOCK DART','2020-11-29 00:50:23'),(34,5,'TENIS TRECK 501','2020-11-29 00:51:04'),(35,5,'TENIS TRECK 501','2020-11-29 00:51:05'),(36,5,'TENIS TRECK 501','2020-11-29 00:51:06'),(37,5,'TENIS TRECK 501','2020-11-29 00:51:18'),(38,5,'RAYO MCQUEEN CANTIMPLORA M1','2020-11-29 00:51:32'),(39,5,'MATE CANTIMPLORA M1','2020-11-29 00:51:33'),(40,5,'SOCK DART','2020-11-29 00:51:53'),(41,5,'TENIS TRECK 501','2020-11-29 00:51:54'),(42,5,'TENIS TRECK 501','2020-11-29 00:58:25'),(43,5,'TENIS TRECK 501','2020-11-29 00:58:36'),(44,5,'TENIS TRECK 501','2020-11-29 01:00:06'),(45,3,'TENIS TRECK 501','2020-11-29 01:13:06'),(46,3,'TENIS TRECK 501','2020-11-29 01:13:08'),(47,3,'TENIS TRECK 501','2020-11-29 01:13:09'),(48,3,'NIKE','2020-11-29 01:13:10'),(49,3,'NIKE','2020-11-29 01:13:11'),(50,3,'TENIS TRECK 501','2020-11-29 01:14:40'),(51,3,'NIKE XP','2020-11-29 01:14:41'),(52,3,'TENIS TRECK 501','2020-11-29 01:14:42'),(53,3,'TENIS TRECK 501','2020-11-29 01:14:43'),(54,3,'TENIS TRECK 501','2020-11-29 01:14:51'),(55,3,'TENIS TRECK 501','2020-11-29 01:29:05'),(56,3,'TENIS TRECK 501','2020-11-29 01:29:07'),(57,3,'SOCK DART','2020-11-29 01:29:08'),(58,3,'SOCK DART','2020-11-29 01:29:09'),(59,3,'NIKE XP','2020-11-29 01:29:10'),(60,3,'NIKE XP','2020-11-29 01:29:11'),(61,3,'TENIS TRECK 501','2020-11-29 01:29:32'),(62,3,'NIKE XP','2020-11-29 01:29:44'),(63,5,'TENIS TRECK 501','2020-11-29 15:37:32'),(64,5,'TENIS TRECK 501','2020-11-29 15:37:41'),(65,5,'N-020 7.5','2020-11-29 15:37:43'),(66,5,'NIKE 1070 6','2020-11-29 15:37:44'),(67,5,'NIKE XP','2020-11-29 15:37:44'),(68,5,'PUMA','2020-11-29 15:37:46'),(69,5,'MATE CANTIMPLORA M1','2020-11-29 15:39:17');
/*!40000 ALTER TABLE `carrito` ENABLE KEYS */;
UNLOCK TABLES;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `verificar` BEFORE INSERT ON `carrito` FOR EACH ROW begin
if exists (select dp.idproducto from detalleproducto dp 
join carrito c on dp.idcarrito=c.idcarrito)  then
update detalleproducto set cantidad =cantidad +1;
else
update detalleproducto set cantidad = 1;
end if;
end */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Table structure for table `compra`
--

DROP TABLE IF EXISTS `compra`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `compra` (
  `idCompra` int NOT NULL AUTO_INCREMENT,
  `Idusuario` int NOT NULL,
  `NombreUsuario` varchar(50) NOT NULL,
  `Descripcion` text NOT NULL,
  `Cantidad_Venta` decimal(10,2) NOT NULL,
  PRIMARY KEY (`idCompra`),
  KEY `compra` (`Idusuario`),
  CONSTRAINT `compra_ibfk_1` FOREIGN KEY (`Idusuario`) REFERENCES `usuario` (`IdUsuario`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `compra`
--

LOCK TABLES `compra` WRITE;
/*!40000 ALTER TABLE `compra` DISABLE KEYS */;
INSERT INTO `compra` VALUES (1,5,'Omar Martinez Gaytan','idCarrito: 0	| \n  idUsuario: 5	| \n  idProducto: 1	| \n  NombreProducto: MATE CANTIMPLORA M1	| \n  FechaCompra: 26/11/2020 05:04:58 p. m.	| \n  Precio: 60.00	| \n  cantidad: 12	| \n  Total: 720.00	| \n  \n ---------------------------------------------------------------------------------------\nidCarrito: 0	| \n  idUsuario: 5	| \n  idProducto: 3	| \n  NombreProducto: RAYO MCQUEEN CANTIMPLORA M1	| \n  FechaCompra: 26/11/2020 05:07:35 p. m.	| \n  Precio: 60.00	| \n  cantidad: 10	| \n  Total: 600.00	| \n  \n ---------------------------------------------------------------------------------------\nidCarrito: 0	| \n  idUsuario: 5	| \n  idProducto: 6	| \n  NombreProducto: PAW PATROL ROJO	| \n  FechaCompra: 26/11/2020 05:07:37 p. m.	| \n  Precio: 45.00	| \n  cantidad: 9	| \n  Total: 405.00	| \n  \n ---------------------------------------------------------------------------------------\nidCarrito: 0	| \n  idUsuario: 5	| \n  idProducto: 9	| \n  NombreProducto: I NEED SPACE	| \n  FechaCompra: 26/11/2020 05:07:38 p. m.	| \n  Precio: 35.00	| \n  cantidad: 8	| \n  Total: 280.00	| \n  \n ---------------------------------------------------------------------------------------\nidCarrito: 0	| \n  idUsuario: 5	| \n  idProducto: 58	| \n  NombreProducto: SOCK DART	| \n  FechaCompra: 26/11/2020 05:08:19 p. m.	| \n  Precio: 180.00	| \n  cantidad: 4	| \n  Total: 720.00	| \n  \n ---------------------------------------------------------------------------------------\nidCarrito: 0	| \n  idUsuario: 5	| \n  idProducto: 57	| \n  NombreProducto: NIKE XP	| \n  FechaCompra: 26/11/2020 05:08:21 p. m.	| \n  Precio: 180.00	| \n  cantidad: 2	| \n  Total: 360.00	| \n  \n ---------------------------------------------------------------------------------------\n\nOmar Martinez Gaytan				Total: $3085.00',3085.00),(2,5,'Omar Martinez Gaytan','idCarrito: 0	| \n  idUsuario: 5	| \n  idProducto: 1	| \n  NombreProducto: MATE CANTIMPLORA M1	| \n  FechaCompra: 26/11/2020 05:04:58 p. m.	| \n  Precio: 60.00	| \n  cantidad: 6	| \n  Total: 360.00	| \n  \n ---------------------------------------------------------------------------------------\nidCarrito: 0	| \n  idUsuario: 5	| \n  idProducto: 4	| \n  NombreProducto: THOR	| \n  FechaCompra: 26/11/2020 05:18:08 p. m.	| \n  Precio: 50.00	| \n  cantidad: 4	| \n  Total: 200.00	| \n  \n ---------------------------------------------------------------------------------------\nidCarrito: 0	| \n  idUsuario: 5	| \n  idProducto: 5	| \n  NombreProducto: PAW PATROL CHUPON	| \n  FechaCompra: 26/11/2020 05:18:10 p. m.	| \n  Precio: 35.00	| \n  cantidad: 2	| \n  Total: 70.00	| \n  \n ---------------------------------------------------------------------------------------\nidCarrito: 0	| \n  idUsuario: 5	| \n  idProducto: 3	| \n  NombreProducto: RAYO MCQUEEN CANTIMPLORA M1	| \n  FechaCompra: 26/11/2020 05:07:35 p. m.	| \n  Precio: 60.00	| \n  cantidad: 1	| \n  Total: 60.00	| \n  \n ---------------------------------------------------------------------------------------\nidCarrito: 0	| \n  idUsuario: 5	| \n  idProducto: 9	| \n  NombreProducto: I NEED SPACE	| \n  FechaCompra: 26/11/2020 05:07:38 p. m.	| \n  Precio: 35.00	| \n  cantidad: 1	| \n  Total: 35.00	| \n  \n ---------------------------------------------------------------------------------------\nidCarrito: 0	| \n  idUsuario: 5	| \n  idProducto: 38	| \n  NombreProducto: BOTELLA REY LEON	| \n  FechaCompra: 29/11/2020 12:50:17 a. m.	| \n  Precio: 80.00	| \n  cantidad: 1	| \n  Total: 80.00	| \n  \n ---------------------------------------------------------------------------------------\nidCarrito: 0	| \n  idUsuario: 5	| \n  idProducto: 55	| \n  NombreProducto: NIKE 1070 6	| \n  FechaCompra: 29/11/2020 12:50:19 a. m.	| \n  Precio: 180.00	| \n  cantidad: 1	| \n  Total: 180.00	| \n  \n ---------------------------------------------------------------------------------------\nidCarrito: 0	| \n  idUsuario: 5	| \n  idProducto: 52	| \n  NombreProducto: PUMA	| \n  FechaCompra: 29/11/2020 12:50:20 a. m.	| \n  Precio: 180.00	| \n  cantidad: 1	| \n  Total: 180.00	| \n  \n ---------------------------------------------------------------------------------------\nidCarrito: 0	| \n  idUsuario: 5	| \n  idProducto: 58	| \n  NombreProducto: SOCK DART	| \n  FechaCompra: 26/11/2020 05:08:19 p. m.	| \n  Precio: 180.00	| \n  cantidad: 1	| \n  Total: 180.00	| \n  \n ---------------------------------------------------------------------------------------\nidCarrito: 0	| \n  idUsuario: 5	| \n  idProducto: 59	| \n  NombreProducto: TENIS TRECK 501	| \n  FechaCompra: 29/11/2020 12:51:04 a. m.	| \n  Precio: 180.00	| \n  cantidad: 1	| \n  Total: 180.00	| \n  \n ---------------------------------------------------------------------------------------\n\nOmar Martinez Gaytan				1525.00',1525.00),(3,3,'Omar Martinez Gaytan','idCarrito: 0	| \n  idUsuario: 3	| \n  idProducto: 59	| \n  NombreProducto: TENIS TRECK 501	| \n  FechaCompra: 29/11/2020 01:13:06 a. m.	| \n  Precio: 180.00	| \n  cantidad: 6	| \n  Total: 1080.00	| \n  \n ---------------------------------------------------------------------------------------\nidCarrito: 0	| \n  idUsuario: 3	| \n  idProducto: 56	| \n  NombreProducto: NIKE	| \n  FechaCompra: 29/11/2020 01:13:10 a. m.	| \n  Precio: 180.00	| \n  cantidad: 6	| \n  Total: 1080.00	| \n  \n ---------------------------------------------------------------------------------------\nidCarrito: 0	| \n  idUsuario: 3	| \n  idProducto: 57	| \n  NombreProducto: NIKE XP	| \n  FechaCompra: 29/11/2020 01:14:41 a. m.	| \n  Precio: 180.00	| \n  cantidad: 4	| \n  Total: 720.00	| \n  \n ---------------------------------------------------------------------------------------\n\nLuis Rojas				2880.00',2880.00),(4,3,'Omar Martinez Gaytan','idCarrito: 0	| \n  idUsuario: 3	| \n  idProducto: 59	| \n  NombreProducto: TENIS TRECK 501	| \n  FechaCompra: 29/11/2020 01:13:06 a. m.	| \n  Precio: 180.00	| \n  cantidad: 8	| \n  Total: 1440.00	| \n  \n ---------------------------------------------------------------------------------------\nidCarrito: 0	| \n  idUsuario: 3	| \n  idProducto: 58	| \n  NombreProducto: SOCK DART	| \n  FechaCompra: 29/11/2020 01:29:08 a. m.	| \n  Precio: 180.00	| \n  cantidad: 6	| \n  Total: 1080.00	| \n  \n ---------------------------------------------------------------------------------------\nidCarrito: 0	| \n  idUsuario: 3	| \n  idProducto: 57	| \n  NombreProducto: NIKE XP	| \n  FechaCompra: 29/11/2020 01:14:41 a. m.	| \n  Precio: 180.00	| \n  cantidad: 4	| \n  Total: 720.00	| \n  \n ---------------------------------------------------------------------------------------\n\nLuis Rojas				3240.00',3240.00),(5,5,'Omar Martinez Gaytan','idCarrito: 0	| \n  idUsuario: 5	| \n  idProducto: 59	| \n  NombreProducto: TENIS TRECK 501	| \n  FechaCompra: 29/11/2020 12:51:04 a. m.	| \n  Precio: 180.00	| \n  cantidad: 6	| \n  Total: 1080.00	| \n  \n ---------------------------------------------------------------------------------------\nidCarrito: 0	| \n  idUsuario: 5	| \n  idProducto: 53	| \n  NombreProducto: N-020 7.5	| \n  FechaCompra: 29/11/2020 03:37:43 p. m.	| \n  Precio: 180.00	| \n  cantidad: 4	| \n  Total: 720.00	| \n  \n ---------------------------------------------------------------------------------------\nidCarrito: 0	| \n  idUsuario: 5	| \n  idProducto: 55	| \n  NombreProducto: NIKE 1070 6	| \n  FechaCompra: 29/11/2020 12:50:19 a. m.	| \n  Precio: 180.00	| \n  cantidad: 3	| \n  Total: 540.00	| \n  \n ---------------------------------------------------------------------------------------\nidCarrito: 0	| \n  idUsuario: 5	| \n  idProducto: 57	| \n  NombreProducto: NIKE XP	| \n  FechaCompra: 26/11/2020 05:08:21 p. m.	| \n  Precio: 180.00	| \n  cantidad: 2	| \n  Total: 360.00	| \n  \n ---------------------------------------------------------------------------------------\nidCarrito: 0	| \n  idUsuario: 5	| \n  idProducto: 52	| \n  NombreProducto: PUMA	| \n  FechaCompra: 29/11/2020 12:50:20 a. m.	| \n  Precio: 180.00	| \n  cantidad: 1	| \n  Total: 180.00	| \n  \n ---------------------------------------------------------------------------------------\n\nOmar Martinez Gaytan				2880.00',2880.00);
/*!40000 ALTER TABLE `compra` ENABLE KEYS */;
UNLOCK TABLES;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `log_registros` AFTER INSERT ON `compra` FOR EACH ROW begin
insert into log_Registro values(default,now(),new.idusuario,new.NombreUsuario,new.Descripcion,new.Cantidad_Venta);
end */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Table structure for table `detalleproducto`
--

DROP TABLE IF EXISTS `detalleproducto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `detalleproducto` (
  `idCarrito` int NOT NULL,
  `idProducto` int NOT NULL,
  `precio` decimal(10,2) NOT NULL,
  `cantidad` int NOT NULL,
  KEY `detalle` (`idCarrito`),
  KEY `producto` (`idProducto`),
  CONSTRAINT `detalleproducto_ibfk_1` FOREIGN KEY (`idCarrito`) REFERENCES `carrito` (`idCarrito`),
  CONSTRAINT `detalleproducto_ibfk_2` FOREIGN KEY (`idProducto`) REFERENCES `producto` (`IdProducto`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `detalleproducto`
--

LOCK TABLES `detalleproducto` WRITE;
/*!40000 ALTER TABLE `detalleproducto` DISABLE KEYS */;
INSERT INTO `detalleproducto` VALUES (5,1,60.00,1);
/*!40000 ALTER TABLE `detalleproducto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `log_registro`
--

DROP TABLE IF EXISTS `log_registro`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `log_registro` (
  `idlog` int NOT NULL AUTO_INCREMENT,
  `fecha` datetime NOT NULL,
  `idusuario` varchar(50) NOT NULL,
  `NombreUsuario` varchar(50) NOT NULL,
  `Descripcion` text NOT NULL,
  `Cantidad_Venta` decimal(10,2) DEFAULT NULL,
  PRIMARY KEY (`idlog`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `log_registro`
--

LOCK TABLES `log_registro` WRITE;
/*!40000 ALTER TABLE `log_registro` DISABLE KEYS */;
INSERT INTO `log_registro` VALUES (1,'2020-11-25 19:28:34','5','Omar Martinez Gaytan','idCarrito: 117	| \n  idUsuario: 5	| \n  idProducto: 59	| \n  NombreProducto: TENIS TRECK 501	| \n  Precio: 180.00	| \n  Cantidad: 3	| \n  Total: 540.00	| \n  \n ---------------------------------------------------------------------------------------\nidCarrito: 118	| \n  idUsuario: 5	| \n  idProducto: 58	| \n  NombreProducto: SOCK DART	| \n  Precio: 180.00	| \n  Cantidad: 3	| \n  Total: 540.00	| \n  \n ---------------------------------------------------------------------------------------\nidCarrito: 119	| \n  idUsuario: 5	| \n  idProducto: 57	| \n  NombreProducto: NIKE XP	| \n  Precio: 180.00	| \n  Cantidad: 2	| \n  Total: 360.00	| \n  \n ---------------------------------------------------------------------------------------\n\nOmar Martinez Gaytan				Total: $1440.00',NULL),(2,'2020-11-29 01:02:11','5','Omar Martinez Gaytan','idCarrito: 0	| \n  idUsuario: 5	| \n  idProducto: 1	| \n  NombreProducto: MATE CANTIMPLORA M1	| \n  FechaCompra: 26/11/2020 05:04:58 p. m.	| \n  Precio: 60.00	| \n  cantidad: 6	| \n  Total: 360.00	| \n  \n ---------------------------------------------------------------------------------------\nidCarrito: 0	| \n  idUsuario: 5	| \n  idProducto: 4	| \n  NombreProducto: THOR	| \n  FechaCompra: 26/11/2020 05:18:08 p. m.	| \n  Precio: 50.00	| \n  cantidad: 4	| \n  Total: 200.00	| \n  \n ---------------------------------------------------------------------------------------\nidCarrito: 0	| \n  idUsuario: 5	| \n  idProducto: 5	| \n  NombreProducto: PAW PATROL CHUPON	| \n  FechaCompra: 26/11/2020 05:18:10 p. m.	| \n  Precio: 35.00	| \n  cantidad: 2	| \n  Total: 70.00	| \n  \n ---------------------------------------------------------------------------------------\nidCarrito: 0	| \n  idUsuario: 5	| \n  idProducto: 3	| \n  NombreProducto: RAYO MCQUEEN CANTIMPLORA M1	| \n  FechaCompra: 26/11/2020 05:07:35 p. m.	| \n  Precio: 60.00	| \n  cantidad: 1	| \n  Total: 60.00	| \n  \n ---------------------------------------------------------------------------------------\nidCarrito: 0	| \n  idUsuario: 5	| \n  idProducto: 9	| \n  NombreProducto: I NEED SPACE	| \n  FechaCompra: 26/11/2020 05:07:38 p. m.	| \n  Precio: 35.00	| \n  cantidad: 1	| \n  Total: 35.00	| \n  \n ---------------------------------------------------------------------------------------\nidCarrito: 0	| \n  idUsuario: 5	| \n  idProducto: 38	| \n  NombreProducto: BOTELLA REY LEON	| \n  FechaCompra: 29/11/2020 12:50:17 a. m.	| \n  Precio: 80.00	| \n  cantidad: 1	| \n  Total: 80.00	| \n  \n ---------------------------------------------------------------------------------------\nidCarrito: 0	| \n  idUsuario: 5	| \n  idProducto: 55	| \n  NombreProducto: NIKE 1070 6	| \n  FechaCompra: 29/11/2020 12:50:19 a. m.	| \n  Precio: 180.00	| \n  cantidad: 1	| \n  Total: 180.00	| \n  \n ---------------------------------------------------------------------------------------\nidCarrito: 0	| \n  idUsuario: 5	| \n  idProducto: 52	| \n  NombreProducto: PUMA	| \n  FechaCompra: 29/11/2020 12:50:20 a. m.	| \n  Precio: 180.00	| \n  cantidad: 1	| \n  Total: 180.00	| \n  \n ---------------------------------------------------------------------------------------\nidCarrito: 0	| \n  idUsuario: 5	| \n  idProducto: 58	| \n  NombreProducto: SOCK DART	| \n  FechaCompra: 26/11/2020 05:08:19 p. m.	| \n  Precio: 180.00	| \n  cantidad: 1	| \n  Total: 180.00	| \n  \n ---------------------------------------------------------------------------------------\nidCarrito: 0	| \n  idUsuario: 5	| \n  idProducto: 59	| \n  NombreProducto: TENIS TRECK 501	| \n  FechaCompra: 29/11/2020 12:51:04 a. m.	| \n  Precio: 180.00	| \n  cantidad: 1	| \n  Total: 180.00	| \n  \n ---------------------------------------------------------------------------------------\n\nOmar Martinez Gaytan				1525.00',1525.00),(3,'2020-11-29 01:18:03','3','Luis Rojas','idCarrito: 0	| \n  idUsuario: 3	| \n  idProducto: 59	| \n  NombreProducto: TENIS TRECK 501	| \n  FechaCompra: 29/11/2020 01:13:06 a. m.	| \n  Precio: 180.00	| \n  cantidad: 6	| \n  Total: 1080.00	| \n  \n ---------------------------------------------------------------------------------------\nidCarrito: 0	| \n  idUsuario: 3	| \n  idProducto: 56	| \n  NombreProducto: NIKE	| \n  FechaCompra: 29/11/2020 01:13:10 a. m.	| \n  Precio: 180.00	| \n  cantidad: 6	| \n  Total: 1080.00	| \n  \n ---------------------------------------------------------------------------------------\nidCarrito: 0	| \n  idUsuario: 3	| \n  idProducto: 57	| \n  NombreProducto: NIKE XP	| \n  FechaCompra: 29/11/2020 01:14:41 a. m.	| \n  Precio: 180.00	| \n  cantidad: 4	| \n  Total: 720.00	| \n  \n ---------------------------------------------------------------------------------------\n\nLuis Rojas				2880.00',2880.00),(4,'2020-11-29 01:29:49','3','Luis Rojas','idCarrito: 0	| \n  idUsuario: 3	| \n  idProducto: 59	| \n  NombreProducto: TENIS TRECK 501	| \n  FechaCompra: 29/11/2020 01:13:06 a. m.	| \n  Precio: 180.00	| \n  cantidad: 8	| \n  Total: 1440.00	| \n  \n ---------------------------------------------------------------------------------------\nidCarrito: 0	| \n  idUsuario: 3	| \n  idProducto: 58	| \n  NombreProducto: SOCK DART	| \n  FechaCompra: 29/11/2020 01:29:08 a. m.	| \n  Precio: 180.00	| \n  cantidad: 6	| \n  Total: 1080.00	| \n  \n ---------------------------------------------------------------------------------------\nidCarrito: 0	| \n  idUsuario: 3	| \n  idProducto: 57	| \n  NombreProducto: NIKE XP	| \n  FechaCompra: 29/11/2020 01:14:41 a. m.	| \n  Precio: 180.00	| \n  cantidad: 4	| \n  Total: 720.00	| \n  \n ---------------------------------------------------------------------------------------\n\nLuis Rojas				3240.00',3240.00),(5,'2020-11-29 15:38:15','5','Omar Martinez Gaytan','idCarrito: 0	| \n  idUsuario: 5	| \n  idProducto: 59	| \n  NombreProducto: TENIS TRECK 501	| \n  FechaCompra: 29/11/2020 12:51:04 a. m.	| \n  Precio: 180.00	| \n  cantidad: 6	| \n  Total: 1080.00	| \n  \n ---------------------------------------------------------------------------------------\nidCarrito: 0	| \n  idUsuario: 5	| \n  idProducto: 53	| \n  NombreProducto: N-020 7.5	| \n  FechaCompra: 29/11/2020 03:37:43 p. m.	| \n  Precio: 180.00	| \n  cantidad: 4	| \n  Total: 720.00	| \n  \n ---------------------------------------------------------------------------------------\nidCarrito: 0	| \n  idUsuario: 5	| \n  idProducto: 55	| \n  NombreProducto: NIKE 1070 6	| \n  FechaCompra: 29/11/2020 12:50:19 a. m.	| \n  Precio: 180.00	| \n  cantidad: 3	| \n  Total: 540.00	| \n  \n ---------------------------------------------------------------------------------------\nidCarrito: 0	| \n  idUsuario: 5	| \n  idProducto: 57	| \n  NombreProducto: NIKE XP	| \n  FechaCompra: 26/11/2020 05:08:21 p. m.	| \n  Precio: 180.00	| \n  cantidad: 2	| \n  Total: 360.00	| \n  \n ---------------------------------------------------------------------------------------\nidCarrito: 0	| \n  idUsuario: 5	| \n  idProducto: 52	| \n  NombreProducto: PUMA	| \n  FechaCompra: 29/11/2020 12:50:20 a. m.	| \n  Precio: 180.00	| \n  cantidad: 1	| \n  Total: 180.00	| \n  \n ---------------------------------------------------------------------------------------\n\nOmar Martinez Gaytan				2880.00',2880.00);
/*!40000 ALTER TABLE `log_registro` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `producto`
--

DROP TABLE IF EXISTS `producto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `producto` (
  `IdProducto` int NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(35) NOT NULL,
  `precio` decimal(10,2) NOT NULL,
  `Descripcion` text NOT NULL,
  `Categoria` varchar(15) NOT NULL,
  PRIMARY KEY (`IdProducto`)
) ENGINE=InnoDB AUTO_INCREMENT=60 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `producto`
--

LOCK TABLES `producto` WRITE;
/*!40000 ALTER TABLE `producto` DISABLE KEYS */;
INSERT INTO `producto` VALUES (1,'MATE CANTIMPLORA M1',60.00,'500 ml','Termo'),(2,'PAW PATROL CANTIMPLORA M1',60.00,'500 ml','Termo'),(3,'RAYO MCQUEEN CANTIMPLORA M1',60.00,' 500 ml','Termo'),(4,'THOR',50.00,' 420 ML','Termo'),(5,'PAW PATROL CHUPON',35.00,'530 ml','Termo'),(6,'PAW PATROL ROJO',45.00,'490 ml','Termo'),(7,'VASO ENTRENADOR',25.00,'300 ml','Termo'),(8,'AVENGERS CANTIMPLORA M2',60.00,'500 ml','Termo'),(9,'I NEED SPACE',35.00,'473 ml','Termo'),(10,'JARRA MARVEL (HULK)',20.00,'1.0 litros','Termo'),(11,'PRINCESAS CANTIMPLORA M2',60.00,'500 ml','Termo'),(12,'WOODY  CANTIMPLORA M2',60.00,'500 ml','Termo'),(13,'BUZZ LIGHTYEAR CANTIMPLORA M1',60.00,' 500 ml','Termo'),(14,'BOTELLA MINNIE & MICKEY MOUSE',35.00,'850 ml','Termo'),(15,'PAW PATROL SNACK',85.00,'300 ml','Termo'),(16,'TAZA OSITO',100.00,' ','Termo'),(17,'BOTELLAS TOY STORY',60.00,'900 ml','Termo'),(18,'BOTELLA FROZEN',60.00,'750 ml','Termo'),(19,'PAW PATROL LLAVE',80.00,'550 ml','Termo'),(20,'FROZEN CANTINFLORA M1',60.00,'500 ml','Termo'),(21,'MISTER VASO',35.00,' ','Termo'),(22,'FROZEN CANTINFLORA M2',60.00,'500 ml','Termo'),(23,'TARRO MARVEL',35.00,' ','Termo'),(24,'BOTELLA TROLLS',60.00,'870 ml','Termo'),(25,'SPIDERMAN LLAVE',70.00,'500 ml','Termo'),(26,'BOTELLA AVENGERS',60.00,' 900 ml','Termo'),(27,'BOTELLA MICKEY',60.00,'900 ml','Termo'),(28,'AVENGERS LLAVE',80.00,'700 ml','Termo'),(29,'PRINCESAS CHUPON',35.00,'530 ml','Termo'),(30,'CARS CHUPON',35.00,'530 ml','Termo'),(31,'BOTELLA COLORES',35.00,'850 ml','Termo'),(32,'AVENGERS CHUPON',60.00,'530 ml','Termo'),(33,'BOTELLA DEPORTIVA',35.00,'750 ml ','Termo'),(34,'BOTELLA MINIONS',60.00,'850 ml','Termo'),(35,'BOTELLA MINIE MOUSE',70.00,'500 ml','Termo'),(36,'BOTELLA PRINCESAS ROSA',60.00,' 900 ml','Termo'),(37,'BOTELLA PRINCESAS TRANPARENTE',60.00,'900 ml','Termo'),(38,'BOTELLA REY LEON',80.00,'900 ml','Termo'),(39,'BOTELLA SPIDERMAN',35.00,'900 ml','Termo'),(40,'BOTELLA MINIONS',35.00,'900 ml','Termo'),(41,'BOTELLA FROZEN AZUL',80.00,'900 ml','Termo'),(42,'BOTELLA FROZEN TRANSPARENTE',35.00,'900 ml','Termo'),(43,'BOTELLA AVENGERS',35.00,'900 ml','Termo'),(44,'SHADOW',180.00,'BLANCO VINO','Tenis'),(45,'NIKE',180.00,'N-20','Tenis'),(46,'NIKE KYWIS',180.00,' ','Tenis'),(47,'PUMA ROMA ',180.00,'AMARILLO','Tenis'),(48,'AFI NIKE',180.00,'NEGRO TOTAL','Tenis'),(49,'TRECK 1010 ',180.00,'BLANCO PLATA','Tenis'),(50,'ADIDAS',180.00,'CONCHA FRANCIA','Tenis'),(51,'VANS 500',180.00,'OXFORD','Tenis'),(52,'PUMA',180.00,'TRANSFORT 8.5','Tenis'),(53,'N-020 7.5',180.00,' ','Tenis'),(54,'ADIDAS 006',180.00,'NEGRO BLANCO','Tenis'),(55,'NIKE 1070 6',180.00,'','Tenis'),(56,'NIKE',180.00,'NEGRO NEON','Tenis'),(57,'NIKE XP',180.00,' ','Tenis'),(58,'SOCK DART',180.00,' ','Tenis'),(59,'TENIS TRECK 501',180.00,' ','Tenis');
/*!40000 ALTER TABLE `producto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuario`
--

DROP TABLE IF EXISTS `usuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `usuario` (
  `IdUsuario` int NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(20) NOT NULL,
  `Apellidos` varchar(30) NOT NULL,
  `UserName` varchar(10) NOT NULL,
  `password` varchar(40) NOT NULL,
  `Tipo` enum('Cliente','Administrador') NOT NULL,
  PRIMARY KEY (`IdUsuario`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuario`
--

LOCK TABLES `usuario` WRITE;
/*!40000 ALTER TABLE `usuario` DISABLE KEYS */;
INSERT INTO `usuario` VALUES (3,'Luis','Rojas','Chito','8292806e2f95f2aca6ec689dce86a18da94760b8','Cliente'),(4,'Omar','Martinez','Cat1106','6c7c317c264cae7f65d8996a8e16875e718250d8','Administrador'),(5,'Omar','Martinez Gaytan','Cat0610','6c7c317c264cae7f65d8996a8e16875e718250d8','Cliente');
/*!40000 ALTER TABLE `usuario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping routines for database 'proyectobd'
--
/*!50003 DROP PROCEDURE IF EXISTS `Reporte_Compras_Cliente` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `Reporte_Compras_Cliente`(in anio int(4),in mes int(2))
begin 
Select idUsuario,NombreUsuario,count(*) as Cantidad_Compras,
sum(Cantidad_Venta) as Cantidad_Total
from log_Registro where (year(fecha)=anio and month(fecha)=mes) group by idUsuario
having Cantidad_Total order by Cantidad_Total desc ;
end ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `Reporte_Ventas_Periodo` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `Reporte_Ventas_Periodo`(in FechaI varchar(11),in FechaF varchar(11))
begin 
select c.idCompra,l.fecha,c.Cantidad_Venta,l.NombreUsuario 
from Compra c join log_Registro l 
where c.idUsuario = l.Idusuario and 
fecha between FechaI and FechaF
group by c.idcompra;
end ;;
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

-- Dump completed on 2020-12-03 18:32:13
