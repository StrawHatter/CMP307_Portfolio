-- phpMyAdmin SQL Dump
-- version 3.3.7deb11
-- http://www.phpmyadmin.net
--
-- Host: lochnagar.abertay.ac.uk
-- Generation Time: Nov 18, 2017 at 12:42 PM
-- Server version: 5.1.73
-- PHP Version: 5.3.3-7+squeeze28

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: sql???????? - whatever your database is called
--

drop table if exists order_items;  /* these are the four tables required for the shopping cart to work */
drop table if exists orders;
drop table if exists products;
drop table if exists customers;




CREATE TABLE IF NOT EXISTS `customers` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  `email` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  `phone` varchar(15) COLLATE utf8_unicode_ci NOT NULL,
  `address` text COLLATE utf8_unicode_ci NOT NULL,
  `created` datetime NOT NULL,
  `modified` datetime NOT NULL,
  `status` enum('1','0') COLLATE utf8_unicode_ci NOT NULL DEFAULT '1',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci AUTO_INCREMENT=5 ;

--
-- Dumping data for table `customers` - change this test data to your own test data
--

INSERT INTO `customers` (`id`, `name`, `email`, `phone`, `address`, `created`, `modified`, `status`) VALUES
(1, 'Euan', 'euan@gmail.com', '01241 123456', 'Arbroath, Angus, Scotland', '2017-10-16 08:21:25', '2017-10-16 08:21:25', '1'),
(2, 'John', 'John@btinternet.com', '01382 988765', 'Dundee, Tayside, Scotland', '2017-10-16 08:21:25', '2017-10-16 08:21:25', '1'),
(3, 'Mary', 'Mary@gmail.com', '01337 123456', 'Ladybank, Fife, Scotland', '2017-10-16 08:21:25', '2017-10-16 08:21:25', '1'),
(4, 'Suzanne', 'Suzanne@sky.com', '01382 897654', 'Dundee, Tayside, Scotland', '2017-10-16 08:21:25', '2017-10-16 08:21:25', '1');

-- --------------------------------------------------------

--
-- Table structure for table `orders`
--

CREATE TABLE IF NOT EXISTS `orders` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `customer_id` int(11) NOT NULL,
  `total_price` float(10,2) NOT NULL,
  `created` datetime NOT NULL,
  `modified` datetime NOT NULL,
  `status` enum('1','0') COLLATE utf8_unicode_ci NOT NULL DEFAULT '1',
  PRIMARY KEY (`id`),
  KEY `customer_id` (`customer_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci AUTO_INCREMENT=3 ;


--
-- Table structure for table `order_items`
--

CREATE TABLE IF NOT EXISTS `order_items` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `order_id` int(11) NOT NULL,
  `product_id` int(11) NOT NULL,
  `quantity` int(5) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `order_id` (`order_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci AUTO_INCREMENT=3 ;


CREATE TABLE IF NOT EXISTS `products` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(200) COLLATE utf8_unicode_ci NOT NULL,
  `description` text COLLATE utf8_unicode_ci NOT NULL,
  `price` float(10,2) NOT NULL,
  `created` datetime NOT NULL,
  `modified` datetime NOT NULL,
  `status` enum('1','0') COLLATE utf8_unicode_ci NOT NULL DEFAULT '1',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci AUTO_INCREMENT=5 ;

--
-- Dumping data for table `products`  -  change this test data to your own test data
--

INSERT INTO `products` (`id`, `name`, `description`, `price`, `created`, `modified`, `status`) VALUES
(1, 'External Hard Drive', 'Toshiba Canvio Basics 1TB Portable External Hard Drive 2.5 Inch USB 3.0 - Black - HDTB310EK3A.', 44.99, '2016-08-17 08:21:25', '2016-08-17 08:21:25', '1'),
(2, 'External Hard Drive', 'Maxtor M3 1 TB USB 3.0 Slimline Portable Hard Drive - Black.', 44.98, '2016-08-17 08:21:25', '2016-08-17 08:21:25', '1'),
(3, 'External Hard Drive', 'Maxtor M3 2 TB USB 3.0 Slimline Portable Hard Drive - Black.', 64.99, '2016-08-17 08:21:25', '2016-08-17 08:21:25', '1'),
(4, 'External Hard Drive', 'Maxtor M3 4 TB USB 3.0 Slimline Portable Hard Drive - Black.', 97.97, '2016-08-17 08:21:25', '2016-08-17 08:21:25', '1'),
(5, 'Smurfs','Smurf It','100.59','2017-11-18 22:00:15','2017-11-17 22:00:15','1');

-- --------------------------------------------------------




