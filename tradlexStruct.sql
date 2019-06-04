-- MySQL dump 10.13  Distrib 5.6.23, for Win32 (x86)
--
-- Host: localhost    Database: tradlex
-- ------------------------------------------------------
-- Server version	5.7.22-log

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
-- Table structure for table `conjugacao_en`
--

DROP TABLE IF EXISTS `conjugacao_en`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `conjugacao_en` (
  `idconjugacao` int(11) NOT NULL AUTO_INCREMENT,
  `ConstrPresente` text COLLATE utf8_unicode_ci,
  `ExPresente` text COLLATE utf8_unicode_ci,
  `ConstrPassado` text COLLATE utf8_unicode_ci,
  `ExPassado` text COLLATE utf8_unicode_ci,
  `ConstrWill` text COLLATE utf8_unicode_ci,
  `ExWill` text COLLATE utf8_unicode_ci,
  `ConstrGoingTo` text COLLATE utf8_unicode_ci,
  `ExGoingTo` text COLLATE utf8_unicode_ci,
  `ConstrPresPer` text COLLATE utf8_unicode_ci,
  `ExPresPer` text COLLATE utf8_unicode_ci,
  `ConstrPasPer` text COLLATE utf8_unicode_ci,
  `ExPasPer` text COLLATE utf8_unicode_ci,
  `ConstrPresCon` text COLLATE utf8_unicode_ci,
  `ExPresCon` text COLLATE utf8_unicode_ci,
  `ConstrPasCon` text COLLATE utf8_unicode_ci,
  `ExPasCon` text COLLATE utf8_unicode_ci,
  PRIMARY KEY (`idconjugacao`),
  UNIQUE KEY `idconjugacao_UNIQUE` (`idconjugacao`)
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `conjugacao_pt`
--

DROP TABLE IF EXISTS `conjugacao_pt`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `conjugacao_pt` (
  `idconjugacao` int(11) NOT NULL AUTO_INCREMENT,
  `ConstrPresente` text COLLATE utf8_unicode_ci,
  `ExPresente` text COLLATE utf8_unicode_ci,
  `ConstrPretImp` text COLLATE utf8_unicode_ci,
  `ExPretImp` text COLLATE utf8_unicode_ci,
  `ConstrPretPer` text COLLATE utf8_unicode_ci,
  `ExPretPer` text COLLATE utf8_unicode_ci,
  `ConstrFutPres` text COLLATE utf8_unicode_ci,
  `ExFutPres` text COLLATE utf8_unicode_ci,
  `ConstrFutPret` text COLLATE utf8_unicode_ci,
  `ExFutPret` text COLLATE utf8_unicode_ci,
  `ConstrInfPessoal` text COLLATE utf8_unicode_ci,
  `ExInfPessoal` text COLLATE utf8_unicode_ci,
  `ConstrParticipio` text COLLATE utf8_unicode_ci,
  `ExParticipio` text COLLATE utf8_unicode_ci,
  `ConstrGerundio` text COLLATE utf8_unicode_ci,
  `ExGerundio` text COLLATE utf8_unicode_ci,
  PRIMARY KEY (`idconjugacao`),
  UNIQUE KEY `idconjugacao_UNIQUE` (`idconjugacao`)
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `equivalencias`
--

DROP TABLE IF EXISTS `equivalencias`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `equivalencias` (
  `Origem` int(11) NOT NULL,
  `equivalente` int(11) NOT NULL COMMENT '	',
  `heterogenerico` tinyint(1) NOT NULL DEFAULT '0',
  `heterotonico` tinyint(1) NOT NULL DEFAULT '0',
  `heterossemantico` tinyint(1) NOT NULL DEFAULT '0',
  `Exemplo` tinytext,
  `Exemplo_Traduzido` tinytext,
  `Referencia` int(11) DEFAULT NULL,
  `PGuia` varchar(100) DEFAULT NULL,
  `nApresentacao` int(4) NOT NULL DEFAULT '1',
  PRIMARY KEY (`Origem`,`equivalente`,`nApresentacao`),
  KEY `fk_Equivalencias_2_idx` (`equivalente`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Equivalente também vale como *Tradução*';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `fraseologia`
--

DROP TABLE IF EXISTS `fraseologia`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `fraseologia` (
  `IdPalavra` int(11) NOT NULL,
  `FraseOrig` varchar(100) NOT NULL,
  `FraseEquiv` varchar(100) NOT NULL,
  `ExemploOrig` varchar(100) DEFAULT NULL,
  `ExemploEquiv` varchar(100) DEFAULT NULL,
  `NotasCultura` text,
  `NotasGramatica` text,
  `Categoria` enum('I','C') NOT NULL,
  PRIMARY KEY (`FraseOrig`,`FraseEquiv`,`Categoria`),
  UNIQUE KEY `FraseOrig_UNIQUE` (`FraseOrig`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `palavra`
--

DROP TABLE IF EXISTS `palavra`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `palavra` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Lema` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  `ClasseGram` varchar(15) COLLATE utf8_unicode_ci NOT NULL,
  `Idioma` char(2) COLLATE utf8_unicode_ci NOT NULL DEFAULT 'PT',
  `notas_gramatica` tinytext COLLATE utf8_unicode_ci,
  `notas_cultura` text COLLATE utf8_unicode_ci,
  `Id_conjuga` int(11) DEFAULT NULL,
  `Genero` enum('M','F','N','S') COLLATE utf8_unicode_ci NOT NULL DEFAULT 'S',
  `Definicao` text COLLATE utf8_unicode_ci,
  PRIMARY KEY (`Lema`,`ClasseGram`,`Idioma`,`Genero`),
  UNIQUE KEY `Id_UNIQUE` (`Id`),
  UNIQUE KEY `IDX_EntradaUnica` (`Lema`,`Idioma`,`ClasseGram`)
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `referencias`
--

DROP TABLE IF EXISTS `referencias`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `referencias` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Cod` char(6) COLLATE utf8_unicode_ci NOT NULL,
  `Descricao` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  `Ano` int(4) DEFAULT NULL,
  `Autor` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `usr`
--

DROP TABLE IF EXISTS `usr`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `usr` (
  `usr` varchar(15) COLLATE utf8_unicode_ci NOT NULL,
  `pass` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  `nivel_permissao` enum('ADM','EDT','USR') COLLATE utf8_unicode_ci NOT NULL,
  `email` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  `nome` varchar(45) COLLATE utf8_unicode_ci DEFAULT NULL,
  `contato` varchar(45) COLLATE utf8_unicode_ci DEFAULT NULL,
  `rede_social` varchar(45) COLLATE utf8_unicode_ci DEFAULT NULL,
  `cpf` char(11) COLLATE utf8_unicode_ci NOT NULL,
  `telefone` char(13) COLLATE utf8_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`usr`),
  UNIQUE KEY `usr_UNIQUE` (`usr`),
  UNIQUE KEY `cpf_UNIQUE` (`cpf`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2019-06-04 21:09:42
