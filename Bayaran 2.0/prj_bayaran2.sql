-- phpMyAdmin SQL Dump
-- version 4.0.4.1
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: May 28, 2016 at 04:31 PM
-- Server version: 5.5.16
-- PHP Version: 5.3.8

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `prj_bayaran2`
--
CREATE DATABASE IF NOT EXISTS `prj_bayaran2` DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
USE `prj_bayaran2`;

-- --------------------------------------------------------

--
-- Table structure for table `as_mhs_golongan`
--

CREATE TABLE IF NOT EXISTS `as_mhs_golongan` (
  `id` int(255) NOT NULL AUTO_INCREMENT,
  `id_mhs` int(255) NOT NULL,
  `golongan` int(255) NOT NULL,
  `timestamp` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=15 ;

--
-- Dumping data for table `as_mhs_golongan`
--

INSERT INTO `as_mhs_golongan` (`id`, `id_mhs`, `golongan`, `timestamp`) VALUES
(11, 2, 1, '2016-04-13 06:19:08'),
(12, 3, 1, '2016-04-13 06:19:08'),
(13, 4, 1, '2016-04-13 06:19:08'),
(14, 5, 1, '2016-04-13 06:19:08');

-- --------------------------------------------------------

--
-- Table structure for table `as_nominal_khusus`
--

CREATE TABLE IF NOT EXISTS `as_nominal_khusus` (
  `id` int(255) NOT NULL AUTO_INCREMENT,
  `id_mhs` int(255) NOT NULL,
  `tipe_transaksi` int(10) NOT NULL,
  `nominal` bigint(255) NOT NULL,
  `beasiswa` tinyint(1) NOT NULL,
  `timestamp` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=5 ;

--
-- Dumping data for table `as_nominal_khusus`
--

INSERT INTO `as_nominal_khusus` (`id`, `id_mhs`, `tipe_transaksi`, `nominal`, `beasiswa`, `timestamp`) VALUES
(1, 2, 1, 250000, 0, '2016-04-13 12:13:10'),
(2, 4, 2, 20000, 0, '2016-04-13 12:22:21'),
(4, 5, 5, 0, 1, '2016-04-15 14:55:22');

-- --------------------------------------------------------

--
-- Table structure for table `ms_golongan`
--

CREATE TABLE IF NOT EXISTS `ms_golongan` (
  `id` int(255) NOT NULL AUTO_INCREMENT,
  `kode_golongan` varchar(255) NOT NULL,
  `angkatan` int(5) NOT NULL,
  `timestamp` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=4 ;

--
-- Dumping data for table `ms_golongan`
--

INSERT INTO `ms_golongan` (`id`, `kode_golongan`, `angkatan`, `timestamp`) VALUES
(1, 'Golongan 1', 2015, '2016-04-08 10:52:29'),
(2, 'Golongan 2', 2015, '2016-04-08 10:53:59'),
(3, 'Golongan 3', 2015, '2016-04-08 10:54:09');

-- --------------------------------------------------------

--
-- Table structure for table `ms_mhs`
--

CREATE TABLE IF NOT EXISTS `ms_mhs` (
  `id` int(255) NOT NULL AUTO_INCREMENT,
  `nama` varchar(255) NOT NULL,
  `nim` varchar(255) NOT NULL,
  `angkatan` int(5) NOT NULL,
  `prodi` varchar(255) NOT NULL,
  `jurusan` varchar(255) NOT NULL,
  `fakultas` varchar(255) NOT NULL,
  `aux` text NOT NULL,
  `timestamp` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=10 ;

--
-- Dumping data for table `ms_mhs`
--

INSERT INTO `ms_mhs` (`id`, `nama`, `nim`, `angkatan`, `prodi`, `jurusan`, `fakultas`, `aux`, `timestamp`) VALUES
(2, 'Ridwan Achadi Nugroho', '52', 2015, 'PTIK', 'Teknik Elektro', 'Teknik', '-', '2016-04-08 10:19:06'),
(3, 'Erwin Firmansyah', '5235153381', 2015, 'PTIK', 'Elektro', 'Teknik', '-', '2016-04-08 10:26:36'),
(4, 'Arif Budi Setiawan', '5235154479', 2015, 'PTIK', 'Elektro', 'Teknik', '0', '2016-04-08 10:27:21'),
(5, 'Ananda Irwansyah', '5235145878', 2015, 'Elektronika', 'Elektro', 'Teknik', '-', '2016-04-08 10:27:44'),
(6, 'Ahmad Khoirus Syafaat', '5235151860', 2015, 'PTIK', 'Elektro', 'Teknik', '-', '2016-04-13 07:34:04'),
(8, 'GM', '02131', 2015, 'PTIK', 'Elektro', 'Teknik', '-', '2016-04-14 04:47:20'),
(9, 'Exa', '881277123', 2014, 'PTIK', 'Elektro', 'Teknik', '-', '2016-04-15 12:46:49');

-- --------------------------------------------------------

--
-- Table structure for table `ms_nominal_umum`
--

CREATE TABLE IF NOT EXISTS `ms_nominal_umum` (
  `id` int(255) NOT NULL AUTO_INCREMENT,
  `golongan` int(10) NOT NULL,
  `tipetrans` int(10) NOT NULL,
  `nominal` bigint(255) NOT NULL,
  `timestamp` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=11 ;

--
-- Dumping data for table `ms_nominal_umum`
--

INSERT INTO `ms_nominal_umum` (`id`, `golongan`, `tipetrans`, `nominal`, `timestamp`) VALUES
(1, 1, 1, 150000, '2016-04-08 12:17:23'),
(3, 2, 1, 145000, '2016-04-08 14:14:32'),
(5, 1, 3, 25000, '2016-04-12 04:16:57'),
(6, 1, 4, 10000, '2016-04-12 04:17:12'),
(7, 1, 5, 5000000, '2016-04-12 04:17:21'),
(10, 1, 6, 15000, '2016-04-16 08:09:50');

-- --------------------------------------------------------

--
-- Table structure for table `ms_type_transaksi`
--

CREATE TABLE IF NOT EXISTS `ms_type_transaksi` (
  `id` int(255) NOT NULL AUTO_INCREMENT,
  `tipe_transaksi` varchar(255) NOT NULL,
  `otp` tinyint(1) NOT NULL,
  `timestamp` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=7 ;

--
-- Dumping data for table `ms_type_transaksi`
--

INSERT INTO `ms_type_transaksi` (`id`, `tipe_transaksi`, `otp`, `timestamp`) VALUES
(1, 'SPP', 0, '2016-04-08 12:09:17'),
(2, 'Uang Gedung', 0, '2016-04-08 14:17:31'),
(3, 'PKL', 0, '2016-04-08 14:17:40'),
(4, 'KKN', 0, '2016-04-08 14:17:43'),
(5, 'Wisuda', 0, '2016-04-08 14:17:47'),
(6, 'SKS', 1, '2016-04-16 08:09:37');

-- --------------------------------------------------------

--
-- Table structure for table `tr_bayar`
--

CREATE TABLE IF NOT EXISTS `tr_bayar` (
  `id` int(255) NOT NULL AUTO_INCREMENT,
  `id_mhs` int(255) NOT NULL,
  `tipe_transaksi` varchar(255) NOT NULL,
  `nominal` bigint(255) NOT NULL,
  `invcode` text NOT NULL,
  `rincian` text NOT NULL,
  `timestamp` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=21 ;

--
-- Dumping data for table `tr_bayar`
--

INSERT INTO `tr_bayar` (`id`, `id_mhs`, `tipe_transaksi`, `nominal`, `invcode`, `rincian`, `timestamp`) VALUES
(1, 2, 'SPP', 0, '2016041900000', '-', '2016-04-19 04:07:08'),
(2, 2, 'PKL', 0, '2016041900000', '-', '2016-04-19 04:07:08'),
(3, 2, 'KKN', 0, '2016041900000', '-', '2016-04-19 04:07:08'),
(4, 2, 'Wisuda', 5000000, '2016041900000', 'Rp. 5,000,000', '2016-04-19 04:07:08'),
(5, 2, 'SKS', 300000, '2016041900000', '(20) SKS', '2016-04-19 04:07:09'),
(6, 2, 'SPP', 250000, '2016042200000', 'Rp. 250,000', '2016-04-22 08:07:21'),
(7, 2, 'PKL', 0, '2016042200000', '-', '2016-04-22 08:07:21'),
(8, 2, 'KKN', 0, '2016042200000', '-', '2016-04-22 08:07:22'),
(9, 2, 'Wisuda', 0, '2016042200000', '-', '2016-04-22 08:07:22'),
(10, 2, 'SKS', 300000, '2016042200000', '(20) SKS', '2016-04-22 08:07:22'),
(11, 2, 'SPP', 0, '2016043000000', '-', '2016-04-30 08:09:47'),
(12, 2, 'PKL', 10000, '2016043000000', 'Rp. 10,000', '2016-04-30 08:09:47'),
(13, 2, 'KKN', 0, '2016043000000', '-', '2016-04-30 08:09:47'),
(14, 2, 'Wisuda', 0, '2016043000000', '-', '2016-04-30 08:09:47'),
(15, 2, 'SKS', 0, '2016043000000', '-', '2016-04-30 08:09:47'),
(16, 3, 'SPP', 75000, '2016050700000', 'Rp. 75,000', '2016-05-07 14:30:13'),
(17, 3, 'PKL', 25000, '2016050700000', 'Rp. 25,000', '2016-05-07 14:30:14'),
(18, 3, 'KKN', 10000, '2016050700000', 'Rp. 10,000', '2016-05-07 14:30:14'),
(19, 3, 'Wisuda', 0, '2016050700000', '-', '2016-05-07 14:30:14'),
(20, 3, 'SKS', 300000, '2016050700000', '(20) SKS', '2016-05-07 14:30:14');

-- --------------------------------------------------------

--
-- Table structure for table `t_staff`
--

CREATE TABLE IF NOT EXISTS `t_staff` (
  `id` int(255) NOT NULL AUTO_INCREMENT,
  `c_username` varchar(255) NOT NULL,
  `c_password` varchar(255) NOT NULL,
  `c_level` int(255) NOT NULL,
  `c_fullname` varchar(255) NOT NULL,
  `c_contact` text NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=5 ;

--
-- Dumping data for table `t_staff`
--

INSERT INTO `t_staff` (`id`, `c_username`, `c_password`, `c_level`, `c_fullname`, `c_contact`) VALUES
(4, 'admin', 'admin', 1, 'Default Admin', '');

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
