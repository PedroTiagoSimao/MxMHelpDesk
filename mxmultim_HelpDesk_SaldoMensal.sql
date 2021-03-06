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
-- Table structure for table `SaldoMensal`
--

DROP TABLE IF EXISTS `SaldoMensal`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `SaldoMensal` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `target` double DEFAULT NULL,
  `achieved` double DEFAULT NULL,
  `month` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=8 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `SaldoMensal`
--

LOCK TABLES `SaldoMensal` WRITE;
/*!40000 ALTER TABLE `SaldoMensal` DISABLE KEYS */;
INSERT INTO `SaldoMensal` VALUES (1,0,NULL,'07-2012'),(3,4505,NULL,'09-2012'),(2,3200,NULL,'08-2012'),(4,4700,NULL,'10-2012'),(5,2350,NULL,'11-2012'),(6,3417,NULL,'12-2012'),(7,2773,NULL,'01-2013');
/*!40000 ALTER TABLE `SaldoMensal` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2013-01-17 12:28:27
