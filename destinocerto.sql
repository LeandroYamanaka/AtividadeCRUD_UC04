-- phpMyAdmin SQL Dump
-- version 5.0.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 18, 2020 at 06:40 PM
-- Server version: 10.4.17-MariaDB
-- PHP Version: 8.0.0

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `destinocerto`
--

-- --------------------------------------------------------

--
-- Table structure for table `contato`
--

CREATE TABLE `contato` (
  `IdContato` int(11) NOT NULL,
  `Email` varchar(50) NOT NULL,
  `Telefone` varchar(12) NOT NULL,
  `Duvida` varchar(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `contato`
--

INSERT INTO `contato` (`IdContato`, `Email`, `Telefone`, `Duvida`) VALUES
(1, 'leandroyamanaka@gmail.com', '11963264010', 'dsadasdadad');

-- --------------------------------------------------------

--
-- Table structure for table `pacote`
--

CREATE TABLE `pacote` (
  `IdPacote` int(11) NOT NULL,
  `Destino` varchar(50) NOT NULL,
  `Partida` varchar(50) NOT NULL,
  `Saida` varchar(12) NOT NULL,
  `Retorno` varchar(12) NOT NULL,
  `Preco` double NOT NULL,
  `Usuario` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `pacote`
--

INSERT INTO `pacote` (`IdPacote`, `Destino`, `Partida`, `Saida`, `Retorno`, `Preco`, `Usuario`) VALUES
(1, 'Bahia', 'São Paulo', '2021-03-04', '2021-07-04', 500, 1),
(2, 'Manaus', 'São Paulo', '2021-01-01', '2021-01-02', 700, 1),
(3, 'Orlando', 'São Paulo', '2021-10-11', '2022-03-01', 3000, 2);

-- --------------------------------------------------------

--
-- Table structure for table `usuario`
--

CREATE TABLE `usuario` (
  `IdUsuario` int(11) NOT NULL,
  `Email` varchar(50) NOT NULL,
  `Telefone` varchar(15) NOT NULL,
  `Senha` varchar(50) NOT NULL,
  `Login` varchar(50) NOT NULL,
  `Nome` varchar(50) NOT NULL,
  `Nascimento` varchar(50) NOT NULL,
  `Nivel` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `usuario`
--

INSERT INTO `usuario` (`IdUsuario`, `Email`, `Telefone`, `Senha`, `Login`, `Nome`, `Nascimento`, `Nivel`) VALUES
(1, 'leandro@email.com', '1196326-4010', '123456', 'leandro', 'Leandro', '25/08/1990', 'Administrador'),
(2, 'joao@email.com', '11234356671', '123', 'joao', 'João', '04/03/1989', 'Usuario'),
(3, 'thiago@email.com', '11985423597', '1234', 'thiago', 'Thiago', '24/11/1986', 'Usuario');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `contato`
--
ALTER TABLE `contato`
  ADD PRIMARY KEY (`IdContato`);

--
-- Indexes for table `pacote`
--
ALTER TABLE `pacote`
  ADD PRIMARY KEY (`IdPacote`);

--
-- Indexes for table `usuario`
--
ALTER TABLE `usuario`
  ADD PRIMARY KEY (`IdUsuario`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `contato`
--
ALTER TABLE `contato`
  MODIFY `IdContato` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `pacote`
--
ALTER TABLE `pacote`
  MODIFY `IdPacote` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `usuario`
--
ALTER TABLE `usuario`
  MODIFY `IdUsuario` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
