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
-- Table structure for table `Income`
--

DROP TABLE IF EXISTS `Income`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `Income` (
  `idIncome` int(11) NOT NULL AUTO_INCREMENT,
  `dateIncome` datetime NOT NULL,
  `artIncome` varchar(45) NOT NULL,
  `descrIncome` varchar(100) NOT NULL,
  `quantIncome` decimal(11,2) NOT NULL DEFAULT '0.00',
  `valueIncome` decimal(11,2) NOT NULL DEFAULT '0.00',
  `totalIncome` decimal(11,2) NOT NULL,
  `lojaIncome` varchar(45) NOT NULL,
  `userIncome` varchar(45) NOT NULL,
  PRIMARY KEY (`idIncome`)
) ENGINE=MyISAM AUTO_INCREMENT=59 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Income`
--

LOCK TABLES `Income` WRITE;
/*!40000 ALTER TABLE `Income` DISABLE KEYS */;
INSERT INTO `Income` VALUES (56,'0000-00-00 00:00:00','','',0.00,0.00,0.00,'',''),(55,'0000-00-00 00:00:00','','',0.00,0.00,0.00,'',''),(53,'2012-08-08 00:00:00','sda','asd',1.00,5.00,0.00,'3','3'),(54,'2012-08-08 00:00:00','','',0.00,0.00,0.00,'3','3'),(57,'0000-00-00 00:00:00','','',0.00,0.00,0.00,'',''),(58,'0000-00-00 00:00:00','','',0.00,0.00,0.00,'','');
/*!40000 ALTER TABLE `Income` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2013-01-17 12:28:25
