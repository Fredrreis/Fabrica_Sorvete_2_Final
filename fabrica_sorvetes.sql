-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Tempo de geração: 19-Nov-2021 às 23:49
-- Versão do servidor: 8.0.21
-- versão do PHP: 7.3.21

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `fabrica_sorvetes`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `pedido`
--

DROP TABLE IF EXISTS `pedido`;
CREATE TABLE IF NOT EXISTS `pedido` (
  `idEntrega` int NOT NULL AUTO_INCREMENT,
  `endereco` varchar(80) NOT NULL,
  `numTelefone` varchar(45) NOT NULL,
  `CEP` char(10) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `tipoSorvete` varchar(65) NOT NULL,
  `saborSorvete` varchar(80) NOT NULL,
  `quantidade` int NOT NULL,
  PRIMARY KEY (`idEntrega`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Extraindo dados da tabela `pedido`
--

INSERT INTO `pedido` (`idEntrega`, `endereco`, `numTelefone`, `CEP`, `tipoSorvete`, `saborSorvete`, `quantidade`) VALUES
(1, 'Contagem, Alvorada, Praça Princesa Isabel 48', '(31)9121-9492', '321312-314', 'Milkshake', '', 3);

-- --------------------------------------------------------

--
-- Estrutura da tabela `sorvetes`
--

DROP TABLE IF EXISTS `sorvetes`;
CREATE TABLE IF NOT EXISTS `sorvetes` (
  `idSorvete` int NOT NULL AUTO_INCREMENT,
  `tipo` varchar(65) NOT NULL,
  `sabor` varchar(80) NOT NULL,
  `preco` decimal(10,2) NOT NULL,
  PRIMARY KEY (`idSorvete`)
) ENGINE=MyISAM AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------------

--
-- Estrutura da tabela `usuario`
--

DROP TABLE IF EXISTS `usuario`;
CREATE TABLE IF NOT EXISTS `usuario` (
  `idUsuario` int NOT NULL AUTO_INCREMENT,
  `email` varchar(80) NOT NULL,
  `senha` varchar(40) NOT NULL,
  PRIMARY KEY (`idUsuario`)
) ENGINE=InnoDB AUTO_INCREMENT=9798 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Extraindo dados da tabela `usuario`
--

INSERT INTO `usuario` (`idUsuario`, `email`, `senha`) VALUES
(1, 'frederico9630@gmail.com', '123456'),
(2, '11901055@aluno.cotemig.com.br', '123456');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
