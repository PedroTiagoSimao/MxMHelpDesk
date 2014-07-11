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
-- Temporary table structure for view `selectAssistencias_view`
--

DROP TABLE IF EXISTS `selectAssistencias_view`;
/*!50001 DROP VIEW IF EXISTS `selectAssistencias_view`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE TABLE `selectAssistencias_view` (
  `datainicio` date,
  `localizacao` varchar(250),
  `registo` varchar(50),
  `numcliente` varchar(50),
  `nomecliente` varchar(50),
  `tiporeparacao` varchar(50),
  `descricaoequip` varchar(250),
  `datafim` date
) ENGINE=MyISAM */;
SET character_set_client = @saved_cs_client;

--
-- Temporary table structure for view `assistencias_view`
--

DROP TABLE IF EXISTS `assistencias_view`;
/*!50001 DROP VIEW IF EXISTS `assistencias_view`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE TABLE `assistencias_view` (
  `datainicio` date,
  `registo` varchar(50),
  `descricaoassist` text,
  `dataassist` date,
  `descricaolinha` varchar(250),
  `quant` int(11),
  `custo` decimal(11,2),
  `numcliente` varchar(50),
  `nomecliente` varchar(50),
  `telefone` varchar(50),
  `telemovel` varchar(50),
  `email` varchar(50),
  `numequip` int(10),
  `tipoequip` varchar(50),
  `descricaoequip` varchar(250),
  `serie` varchar(250),
  `Localizacao` varchar(250),
  `Telefoneloja` varchar(50),
  `tiporeparacao` varchar(50),
  `acessorios` varchar(100)
) ENGINE=MyISAM */;
SET character_set_client = @saved_cs_client;

--
-- Temporary table structure for view `mapaassist_view`
--

DROP TABLE IF EXISTS `mapaassist_view`;
/*!50001 DROP VIEW IF EXISTS `mapaassist_view`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE TABLE `mapaassist_view` (
  `datainicio` date,
  `registo` varchar(50),
  `descricaoassist` text,
  `datafim` date,
  `username` varchar(50),
  `dataassist` date,
  `descricaolinha` varchar(250),
  `quant` int(11),
  `custo` decimal(11,2),
  `numcliente` varchar(50),
  `nomecliente` varchar(50),
  `telefone` varchar(50),
  `telemovel` varchar(50),
  `email` varchar(50),
  `numequip` int(10),
  `tipoequip` varchar(50),
  `descricaoequip` varchar(250),
  `serie` varchar(250),
  `Localizacao` varchar(250),
  `Telefoneloja` varchar(50),
  `tiporeparacao` varchar(50)
) ENGINE=MyISAM */;
SET character_set_client = @saved_cs_client;

--
-- Temporary table structure for view `totalassist_view`
--

DROP TABLE IF EXISTS `totalassist_view`;
/*!50001 DROP VIEW IF EXISTS `totalassist_view`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE TABLE `totalassist_view` (
  `datainicio` date,
  `registo` varchar(50),
  `tiporeparacao` varchar(50),
  `datafim` date,
  `Loja` varchar(250),
  `username` varchar(50),
  `servicos` bigint(21),
  `Total` decimal(43,2)
) ENGINE=MyISAM */;
SET character_set_client = @saved_cs_client;

--
-- Final view structure for view `selectAssistencias_view`
--

/*!50001 DROP TABLE IF EXISTS `selectAssistencias_view`*/;
/*!50001 DROP VIEW IF EXISTS `selectAssistencias_view`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8 */;
/*!50001 SET character_set_results     = utf8 */;
/*!50001 SET collation_connection      = utf8_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`mxmultim_hduser`@`%` SQL SECURITY DEFINER */
/*!50001 VIEW `selectAssistencias_view` AS select `Assistencias`.`datainicio` AS `datainicio`,`Lojas`.`Localizacao` AS `localizacao`,`Assistencias`.`registo` AS `registo`,`Clientes`.`numcliente` AS `numcliente`,`Clientes`.`nomecliente` AS `nomecliente`,`TipoReparacao`.`tiporeparacao` AS `tiporeparacao`,`Equipamentos`.`descricaoequip` AS `descricaoequip`,`Assistencias`.`datafim` AS `datafim` from ((((`Assistencias` left join `Clientes` on((`Clientes`.`numcliente` = convert(`Assistencias`.`idcliente` using utf8)))) left join `TipoReparacao` on((`TipoReparacao`.`id` = `Assistencias`.`idtipo`))) left join `Equipamentos` on((`Equipamentos`.`numequip` = `Assistencias`.`idequipamento`))) left join `Lojas` on((`Lojas`.`id` = `Assistencias`.`idloja`))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `assistencias_view`
--

/*!50001 DROP TABLE IF EXISTS `assistencias_view`*/;
/*!50001 DROP VIEW IF EXISTS `assistencias_view`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8 */;
/*!50001 SET character_set_results     = utf8 */;
/*!50001 SET collation_connection      = utf8_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`mxmultim_hduser`@`%` SQL SECURITY DEFINER */
/*!50001 VIEW `assistencias_view` AS select `Assistencias`.`datainicio` AS `datainicio`,`Assistencias`.`registo` AS `registo`,`Assistencias`.`descricaoassist` AS `descricaoassist`,`AssLinhas`.`dataassist` AS `dataassist`,`AssLinhas`.`descricaolinha` AS `descricaolinha`,`AssLinhas`.`quant` AS `quant`,`AssLinhas`.`custo` AS `custo`,`Clientes`.`numcliente` AS `numcliente`,`Clientes`.`nomecliente` AS `nomecliente`,`Clientes`.`telefone` AS `telefone`,`Clientes`.`telemovel` AS `telemovel`,`Clientes`.`email` AS `email`,`Equipamentos`.`numequip` AS `numequip`,`Equipamentos`.`tipoequip` AS `tipoequip`,`Equipamentos`.`descricaoequip` AS `descricaoequip`,`Equipamentos`.`serie` AS `serie`,`Lojas`.`Localizacao` AS `Localizacao`,`Lojas`.`Telefoneloja` AS `Telefoneloja`,`TipoReparacao`.`tiporeparacao` AS `tiporeparacao`,`Assistencias`.`acessorios` AS `acessorios` from (((((`Assistencias` left join `AssLinhas` on((`Assistencias`.`registo` = `AssLinhas`.`registo`))) left join `Clientes` on((`Clientes`.`numcliente` = convert(`Assistencias`.`idcliente` using utf8)))) left join `Equipamentos` on((`Equipamentos`.`numequip` = `Assistencias`.`idequipamento`))) left join `TipoReparacao` on((`TipoReparacao`.`id` = `Assistencias`.`idtipo`))) left join `Lojas` on((`Lojas`.`id` = `Assistencias`.`idloja`))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `mapaassist_view`
--

/*!50001 DROP TABLE IF EXISTS `mapaassist_view`*/;
/*!50001 DROP VIEW IF EXISTS `mapaassist_view`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8 */;
/*!50001 SET character_set_results     = utf8 */;
/*!50001 SET collation_connection      = utf8_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`mxmultim_hduser`@`%` SQL SECURITY DEFINER */
/*!50001 VIEW `mapaassist_view` AS select `Assistencias`.`datainicio` AS `datainicio`,`Assistencias`.`registo` AS `registo`,`Assistencias`.`descricaoassist` AS `descricaoassist`,`Assistencias`.`datafim` AS `datafim`,`Users`.`username` AS `username`,`AssLinhas`.`dataassist` AS `dataassist`,`AssLinhas`.`descricaolinha` AS `descricaolinha`,`AssLinhas`.`quant` AS `quant`,`AssLinhas`.`custo` AS `custo`,`Clientes`.`numcliente` AS `numcliente`,`Clientes`.`nomecliente` AS `nomecliente`,`Clientes`.`telefone` AS `telefone`,`Clientes`.`telemovel` AS `telemovel`,`Clientes`.`email` AS `email`,`Equipamentos`.`numequip` AS `numequip`,`Equipamentos`.`tipoequip` AS `tipoequip`,`Equipamentos`.`descricaoequip` AS `descricaoequip`,`Equipamentos`.`serie` AS `serie`,`Lojas`.`Localizacao` AS `Localizacao`,`Lojas`.`Telefoneloja` AS `Telefoneloja`,`TipoReparacao`.`tiporeparacao` AS `tiporeparacao` from ((((((`Assistencias` left join `AssLinhas` on((`Assistencias`.`registo` = `AssLinhas`.`registo`))) left join `Clientes` on((`Clientes`.`numcliente` = convert(`Assistencias`.`idcliente` using utf8)))) left join `Equipamentos` on((`Equipamentos`.`numequip` = `Assistencias`.`idequipamento`))) left join `TipoReparacao` on((`TipoReparacao`.`id` = `Assistencias`.`idtipo`))) left join `Lojas` on((`Lojas`.`id` = `Assistencias`.`idloja`))) left join `Users` on((`Users`.`id` = `AssLinhas`.`userid`))) order by `Lojas`.`Localizacao`,`Assistencias`.`datainicio`,`AssLinhas`.`dataassist` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `totalassist_view`
--

/*!50001 DROP TABLE IF EXISTS `totalassist_view`*/;
/*!50001 DROP VIEW IF EXISTS `totalassist_view`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8 */;
/*!50001 SET character_set_results     = utf8 */;
/*!50001 SET collation_connection      = utf8_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`mxmultim_hduser`@`%` SQL SECURITY DEFINER */
/*!50001 VIEW `totalassist_view` AS select `Assistencias`.`datainicio` AS `datainicio`,`Assistencias`.`registo` AS `registo`,`TipoReparacao`.`tiporeparacao` AS `tiporeparacao`,`Assistencias`.`datafim` AS `datafim`,`Lojas`.`Localizacao` AS `Loja`,`Users`.`username` AS `username`,count(`AssLinhas`.`quant`) AS `servicos`,sum((`AssLinhas`.`quant` * `AssLinhas`.`custo`)) AS `Total` from (((((`Assistencias` left join `AssLinhas` on((`AssLinhas`.`registo` = `Assistencias`.`registo`))) left join `Clientes` on((`Clientes`.`numcliente` = convert(`Assistencias`.`idcliente` using utf8)))) left join `Users` on((`Users`.`id` = `Assistencias`.`userid`))) left join `TipoReparacao` on((`TipoReparacao`.`id` = `Assistencias`.`idtipo`))) left join `Lojas` on((`Lojas`.`id` = `Assistencias`.`idloja`))) group by `Assistencias`.`registo` order by `Assistencias`.`datainicio`,`Assistencias`.`datafim` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2013-01-17 12:28:28
