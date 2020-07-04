-- phpMyAdmin SQL Dump
-- version 4.0.4
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Mar 17, 2019 at 03:26 AM
-- Server version: 5.5.32
-- PHP Version: 5.4.16

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `fict`
--
CREATE DATABASE IF NOT EXISTS `fict` DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
USE `fict`;

-- --------------------------------------------------------

--
-- Table structure for table `members`
--

CREATE TABLE IF NOT EXISTS `members` (
  `ID` int(20) NOT NULL,
  `name` varchar(40) NOT NULL,
  `course` varchar(10) NOT NULL,
  `year` varchar(3) NOT NULL,
  `section` varchar(1) NOT NULL,
  `membersfee` varchar(10) NOT NULL,
  `size` varchar(3) NOT NULL,
  `tshirtfee` varchar(10) NOT NULL,
  UNIQUE KEY `ID` (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `members`
--

INSERT INTO `members` (`ID`, `name`, `course`, `year`, `section`, `membersfee`, `size`, `tshirtfee`) VALUES
(201311477, 'SORIANO, Aira Buhain', 'BSIT', '2ND', 'B', 'No', 'L', 'No'),
(201410255, 'CANAREJO, Aldrin Sabado', 'BSIT', '2ND', 'B', 'No', 'L', 'No'),
(201411378, 'BAJAO, Michael Vincent Adalla', 'BSIT', '2ND', 'B', 'No', 'L', 'No'),
(201510111, 'CORRELO, Charles Nicole Regalado', 'BSIT', '2ND', 'B', 'No', 'L', 'No'),
(201510560, 'JANSUY, Lennon Benedict Digma', 'BSIT', '2ND', 'B', 'No', 'M', 'No'),
(201511435, 'VILLEGAS, Rachelle De Vega', 'BSIT', '2ND', 'B', 'No', 'L', 'No'),
(201511439, 'VILLEGAS, Rochelle De Vega', 'BSIT', '2ND', 'B', 'No', 'L', 'No'),
(201511594, 'CLEDERA, Jenny Rose Abas', 'BSIT', '2ND', 'B', 'Paid', 'XS', 'Paid'),
(201511807, 'ABRISE, Jomar Kinazo', 'BSIT', '2ND', 'B', 'No', 'L', 'No'),
(201511832, 'LAYUGAN , John Christopher Domingo', 'BSIT', '2ND', 'B', 'No', 'L', 'No'),
(201511847, 'GUANZON, Jaymie Kate Tabal', 'BSIT', '2ND', 'B', 'No', 'L', 'No'),
(201611474, 'OLAES, Angela Gayle S', 'BSIT', '2ND', 'B', 'No', 'L', 'No'),
(201710199, 'LUMAWAG, Gerry Mie Osano', 'BSIT', '2ND', 'B', 'No', 'L', 'No'),
(201710252, 'CLARITO, Angela Cesista', 'BSIT', '2ND', 'B', 'No', 'L', 'No'),
(201710291, 'LOZANO, Sonny Cabarangao', 'BSIT', '2ND', 'B', 'No', 'L', 'No'),
(201710296, 'TALION, Madel Pantino', 'BSIT', '2ND', 'B', 'No', 'L', 'No'),
(201710308, 'ARCENA, Carlo Ray ', 'BSIT', '2ND', 'B', 'No', 'L', 'No'),
(201710311, 'GOMEZ, Jelina Dela Vega', 'BSIT', '2ND', 'B', 'No', 'L', 'No'),
(201710352, 'PEJAN, John Lou Roculas', 'BSIT', '2ND', 'B', 'No', 'L', 'No'),
(201710369, 'DELA CRUZ, Devorah MuÑoz', 'BSIT', '2ND', 'B', 'No', 'L', 'No'),
(201710401, 'MARVAS, Kevin Ryan Bayta', 'BSIT', '2ND', 'B', 'No', 'L', 'No'),
(201710403, 'MANGUBAT, Jermaine Castro', 'BSIT', '2ND', 'B', 'No', 'L', 'No'),
(201710454, 'ERAÑA, John Carlo Fabro', 'BSIT', '2ND', 'B', 'No', 'L', 'No');

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
