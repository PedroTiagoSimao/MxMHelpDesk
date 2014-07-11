-- phpMyAdmin SQL Dump
-- version 3.3.7deb7
-- http://www.phpmyadmin.net
--
-- Host: localhost
-- Generation Time: May 22, 2012 at 03:16 PM
-- Server version: 5.1.61
-- PHP Version: 5.3.3-7+squeeze8

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `HelpDesk`
--

-- --------------------------------------------------------

--
-- Table structure for table `Assistencias`
--

CREATE TABLE IF NOT EXISTS `Assistencias` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `datainicio` date NOT NULL,
  `idloja` int(11) NOT NULL,
  `registo` varchar(50) CHARACTER SET utf8 NOT NULL,
  `idcliente` varchar(50) NOT NULL,
  `idequipamento` int(11) NOT NULL,
  `idtipo` int(11) NOT NULL,
  `descricao` text CHARACTER SET utf8 NOT NULL,
  `datafim` date NOT NULL DEFAULT '1999-01-01',
  UNIQUE KEY `id` (`id`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=9 ;

--
-- Dumping data for table `Assistencias`
--

INSERT INTO `Assistencias` (`id`, `datainicio`, `idloja`, `registo`, `idcliente`, `idequipamento`, `idtipo`, `descricao`, `datafim`) VALUES
(8, '2012-05-30', 3, '9037XR', '6548fg', 965412, 1, '', '1999-01-01');

-- --------------------------------------------------------

--
-- Table structure for table `AssLinhas`
--

CREATE TABLE IF NOT EXISTS `AssLinhas` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `registo` varchar(50) CHARACTER SET utf8 NOT NULL,
  `descricao` varchar(250) CHARACTER SET utf8 NOT NULL,
  `quant` int(11) NOT NULL,
  `custo` decimal(11,2) NOT NULL,
  `dataassist` date NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=58 ;

--
-- Dumping data for table `AssLinhas`
--


-- --------------------------------------------------------

--
-- Table structure for table `Clientes`
--

CREATE TABLE IF NOT EXISTS `Clientes` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `numcliente` varchar(50) CHARACTER SET utf8 NOT NULL,
  `dataregisto` date NOT NULL,
  `nomecliente` varchar(50) CHARACTER SET utf8 NOT NULL,
  `telefone` varchar(50) CHARACTER SET utf8 NOT NULL,
  `telemovel` varchar(50) NOT NULL,
  `email` varchar(50) CHARACTER SET utf8 NOT NULL,
  `skype` varchar(50) CHARACTER SET utf8 NOT NULL,
  `morada` varchar(250) CHARACTER SET utf8 NOT NULL,
  `cp` varchar(50) CHARACTER SET utf8 NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=9 ;

--
-- Dumping data for table `Clientes`
--

INSERT INTO `Clientes` (`id`, `numcliente`, `dataregisto`, `nomecliente`, `telefone`, `telemovel`, `email`, `skype`, `morada`, `cp`) VALUES
(1, '6548FG', '2012-05-29', 'Pedro Simão', '262382454', '917502470', 'pedrosimao@gmail.com', 'pedrotsimao', 'Rua Cor. Andrada Mendoça, 25 - 1º Dto', '2500-148 Caldas da Rainha'),
(7, '8209UF', '2012-05-29', 'Carlos Miguel', '262458965', '954587587', 'carlos.miguel@hotmail.com', '', '', '2500 Caldas da Rainha');

-- --------------------------------------------------------

--
-- Table structure for table `Equipamentos`
--

CREATE TABLE IF NOT EXISTS `Equipamentos` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `numequip` int(10) NOT NULL,
  `idcliente` varchar(50) NOT NULL,
  `tipo` varchar(50) CHARACTER SET utf8 NOT NULL,
  `descricao` varchar(250) CHARACTER SET utf8 NOT NULL,
  `serie` varchar(250) CHARACTER SET utf8 NOT NULL,
  UNIQUE KEY `id` (`id`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=26 ;

--
-- Dumping data for table `Equipamentos`
--

INSERT INTO `Equipamentos` (`id`, `numequip`, `idcliente`, `tipo`, `descricao`, `serie`) VALUES
(3, 856321, '5487KL', 'Impressora', 'HP Deskjet 640c', '9345853495'),
(16, 859652, '8209UF', 'Impressora', 'Epson SX125', '0959n5j585'),
(24, 452874, '6548FG', 'Monitor', 'Acer 22"', 'PS767494J54.X'),
(23, 965412, '6548FG', 'Computador', 'MacBook Pro 2.4', 'PR5564'),
(25, 325489, '6548FG', 'Impressora', 'HP Deskjet', '');

-- --------------------------------------------------------

--
-- Table structure for table `Lojas`
--

CREATE TABLE IF NOT EXISTS `Lojas` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `Nome` varchar(50) NOT NULL,
  `Email` varchar(50) NOT NULL,
  `Telefone` varchar(50) NOT NULL,
  `Localizacao` varchar(250) NOT NULL,
  `CodLoja` varchar(50) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=4 ;

--
-- Dumping data for table `Lojas`
--

INSERT INTO `Lojas` (`id`, `Nome`, `Email`, `Telefone`, `Localizacao`, `CodLoja`) VALUES
(1, 'Loja 1', 'loja1@mxmultimedia.com', '262', 'Alfeizerão', 'ALF'),
(2, 'Loja 2', 'loja2@mxmultimedia.com', '262', 'S. Martinho do Porto', 'SMP'),
(3, 'Loja 3', 'loja3@mxmultimedia.com', '262', 'Caldas da Rainha', 'CR');

-- --------------------------------------------------------

--
-- Table structure for table `TipoReparacao`
--

CREATE TABLE IF NOT EXISTS `TipoReparacao` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `tipo` varchar(50) CHARACTER SET utf8 NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=11 ;

--
-- Dumping data for table `TipoReparacao`
--

INSERT INTO `TipoReparacao` (`id`, `tipo`) VALUES
(1, 'Orçamentar'),
(2, 'Reparação'),
(3, 'Vírus'),
(4, 'Optimização'),
(5, 'Software'),
(6, 'Limpeza'),
(7, 'SO'),
(8, 'Shell'),
(9, 'Backup'),
(10, 'Outros');

-- --------------------------------------------------------

--
-- Table structure for table `Users`
--

CREATE TABLE IF NOT EXISTS `Users` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `username` varchar(50) NOT NULL,
  `password` varchar(50) NOT NULL,
  `email` varchar(50) NOT NULL,
  `idloja` int(11) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=6 ;

--
-- Dumping data for table `Users`
--

INSERT INTO `Users` (`id`, `username`, `password`, `email`, `idloja`) VALUES
(1, 'Pedro Simão', '123', 'pedrosimao@gmail.com', 3),
(2, 'Rui Vieira', '123', 'rui@mxmultimedia.com', 3),
(5, 'a', 'a', 'a', 3);
