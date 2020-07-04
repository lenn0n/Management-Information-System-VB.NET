-- phpMyAdmin SQL Dump
-- version 3.1.3.1
-- http://www.phpmyadmin.net
--
-- Host: localhost
-- Generation Time: Dec 04, 2019 at 11:36 PM
-- Server version: 5.1.33
-- PHP Version: 5.2.9

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";

--
-- Database: `fict`
--
CREATE DATABASE `fict` DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
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
(201311477, 'SORIANO, Aira Buhain', 'BSIT', '2ND', 'B', 'No', 'L', 'None'),
(201410255, 'CANAREJO, Aldrin Sabado', 'BSIT', '2ND', 'B', 'No', 'L', 'None'),
(201411378, 'BAJAO, Michael Vincent Adalla', 'BSIT', '2ND', 'B', 'No', 'L', 'None'),
(201510111, 'CORRELO, Charles Nicole Regalado', 'BSIT', '2ND', 'B', 'Paid', 'L', 'Half'),
(201510560, 'JANSUY, Lennon Benedict Digma', 'BSIT', '2ND', 'B', 'Paid', 'XXL', 'Half'),
(201511435, 'VILLEGAS, Rachelle De Vega', 'BSIT', '2ND', 'B', 'No', 'L', 'None'),
(201511439, 'VILLEGAS, Rochelle De Vega', 'BSIT', '2ND', 'B', 'No', 'L', 'None'),
(201511594, 'CLEDERA, Jenny Rose Abas', 'BSIT', '2ND', 'B', 'No', 'XS', 'None'),
(201511807, 'ABRISE, Jomar Kinazo', 'BSIT', '2ND', 'B', 'No', 'L', 'None'),
(201511832, 'LAYUGAN , John Christopher Domingo', 'BSIT', '2ND', 'B', 'No', 'L', 'None'),
(201511847, 'GUANZON, Jaymie Kate Tabal', 'BSIT', '2ND', 'B', 'No', 'L', 'Full'),
(201611474, 'OLAES, Angela Gayle S', 'BSIT', '2ND', 'B', 'No', 'L', 'None'),
(201710199, 'LUMAWAG, Gerry Mie Osano', 'BSIT', '2ND', 'B', 'No', 'L', 'None'),
(201710252, 'CLARITO, Angela Cesista', 'BSIT', '2ND', 'B', 'No', 'L', 'None'),
(201710291, 'LOZANO, Sonny Cabarangao', 'BSIT', '2ND', 'B', 'No', 'L', 'None'),
(201710296, 'TALION, Madel Pantino', 'BSIT', '2ND', 'B', 'No', 'L', 'None'),
(201710308, 'ARCENA, Carlo Ray ', 'BSIT', '2ND', 'B', 'No', 'L', 'None'),
(201710311, 'GOMEZ, Jelina Dela Vega', 'BSIT', '2ND', 'B', 'No', 'L', 'None'),
(201710352, 'PEJAN, John Lou Roculas', 'BSIT', '2ND', 'B', 'No', 'L', 'None'),
(201710369, 'DELA CRUZ, Devorah Mu—oz', 'BSIT', '2ND', 'B', 'No', 'L', 'None'),
(201710401, 'MARVAS, Kevin Ryan Bayta', 'BSIT', '2ND', 'B', 'No', 'L', 'None'),
(201710403, 'MANGUBAT, Jermaine Castro', 'BSIT', '2ND', 'B', 'No', 'L', 'None'),
(201710454, 'ERA—A, John Carlo Fabro', 'BSIT', '2ND', 'B', 'No', 'L', 'None');

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE IF NOT EXISTS `users` (
  `ID` int(200) NOT NULL AUTO_INCREMENT,
  `username` varchar(200) NOT NULL,
  `password` varchar(200) NOT NULL,
  `name` varchar(200) NOT NULL,
  `age` int(200) NOT NULL,
  `gender` varchar(200) NOT NULL,
  `address` varchar(200) NOT NULL,
  `zipcode` varchar(200) NOT NULL,
  `contact` varchar(200) NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=2 ;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`ID`, `username`, `password`, `name`, `age`, `gender`, `address`, `zipcode`, `contact`) VALUES
(1, 'lennon', 'ben', 'Lennon Benedict Jansuy', 25, 'Male', '237 Guijo St. Poblacion IV. Tanza Cavite', '4108', '09567789787');
