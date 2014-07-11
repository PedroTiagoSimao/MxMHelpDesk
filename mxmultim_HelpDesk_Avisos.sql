CREATE DATABASE  IF NOT EXISTS `mxmultim_HelpDesk` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `mxmultim_HelpDesk`;
-- MySQL dump 10.13  Distrib 5.5.16, for Win32 (x86)
--
-- Host: 80.172.235.100    Database: mxmultim_HelpDesk
-- ------------------------------------------------------
-- Server version	5.1.66-cll

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `Avisos`
--

DROP TABLE IF EXISTS `Avisos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `Avisos` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `tipo` varchar(50) NOT NULL,
  `dataaviso` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `registo` varchar(50) NOT NULL,
  `email` varchar(250) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=24 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Avisos`
--

LOCK TABLES `Avisos` WRITE;
/*!40000 ALTER TABLE `Avisos` DISABLE KEYS */;
INSERT INTO `Avisos` VALUES (1,'RepParadas','2013-01-16 11:15:26','16-01-2013 11:15:28',''),(4,'Cliente','2012-07-02 18:58:27','7173RL','pedrosimao@gmail.com'),(5,'Cliente','2012-07-03 10:03:31','9307YT','bruno24migueis@hotmail.com'),(6,'Cliente','2012-07-03 10:05:38','','bruno24migueis@hotmail.com'),(7,'Cliente','2012-07-04 14:00:16','','joaoluisrodrigues84@gmail.com'),(8,'Cliente','2012-07-05 10:49:37','','pioinformatica@gmail.com'),(9,'Cliente','2012-07-06 09:38:46','','ruivieira.mail@gmail.com'),(10,'Cliente','2012-07-06 09:40:32','','ruivieira.mail@gmail.com'),(11,'Cliente','2012-07-06 09:41:04','','ruivieira.mail@gmail.com'),(12,'Cliente','2012-07-07 12:06:41','','silvana-mendes-santos@hotmail.com'),(13,'Cliente','2012-07-09 15:55:37','1071AY','rebelo.r@hotmail.com'),(14,'Cliente','2012-07-11 17:28:18','4024IM','soniaferreira34@live.com.pt'),(15,'Cliente','2012-07-13 16:00:48','','pedrosimao@gmail.com'),(16,'Cliente','2012-08-02 17:33:20','5172MK','vilarinha@vilarinha.com'),(17,'Cliente','2012-08-06 14:28:42','3900IH','americotopografo@gmail.com'),(18,'Cliente','2012-08-07 16:32:46','','samueldsreis@gmail.com'),(19,'Cliente','2012-08-08 12:37:52','9828ZO','pedrosimao@gmail.com'),(20,'Cliente','2012-08-24 11:54:26','4807LQ','jantoniobicho@iol.pt'),(21,'Cliente','2012-08-28 09:43:55','','jorgealexmar@gmail.com'),(22,'Cliente','2012-10-25 10:04:25','','lritas@hotmail.com'),(23,'Cliente','2013-01-03 16:19:02','9235XI','flori.tiago@gmail.com');
/*!40000 ALTER TABLE `Avisos` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2013-01-17 12:28:20
