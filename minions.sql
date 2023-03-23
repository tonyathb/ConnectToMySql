-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Server version:               8.0.22 - MySQL Community Server - GPL
-- Server OS:                    Win64
-- HeidiSQL Version:             11.1.0.6116
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- Dumping database structure for minions
CREATE DATABASE IF NOT EXISTS `minions` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `minions`;

-- Dumping structure for table minions.addresses
CREATE TABLE IF NOT EXISTS `addresses` (
  `id` int NOT NULL AUTO_INCREMENT,
  `adress_text` varchar(50) NOT NULL,
  `town_id` int NOT NULL,
  PRIMARY KEY (`id`),
  KEY `FK_addresses_towns` (`town_id`),
  CONSTRAINT `FK_addresses_towns` FOREIGN KEY (`town_id`) REFERENCES `towns` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Dumping data for table minions.addresses: ~4 rows (approximately)
/*!40000 ALTER TABLE `addresses` DISABLE KEYS */;
INSERT INTO `addresses` (`id`, `adress_text`, `town_id`) VALUES
	(1, 'DA 11', 1),
	(2, 'NE 13', 2),
	(3, 'Ivan Vazov No1', 3),
	(4, 'Tr Kostov No1', 3);
/*!40000 ALTER TABLE `addresses` ENABLE KEYS */;

-- Dumping structure for table minions.employees
CREATE TABLE IF NOT EXISTS `employees` (
  `id` int NOT NULL AUTO_INCREMENT,
  `first_name` varchar(50) NOT NULL,
  `middle_name` varchar(50) NOT NULL,
  `last_name` varchar(50) NOT NULL,
  `job_title` varchar(50) NOT NULL,
  `department_id` int DEFAULT NULL,
  `hire_date` date DEFAULT NULL,
  `salary` double NOT NULL,
  `address_id` int DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Dumping data for table minions.employees: ~0 rows (approximately)
/*!40000 ALTER TABLE `employees` DISABLE KEYS */;
/*!40000 ALTER TABLE `employees` ENABLE KEYS */;

-- Dumping structure for table minions.minions
CREATE TABLE IF NOT EXISTS `minions` (
  `id` int NOT NULL,
  `name` varchar(50) NOT NULL,
  `age` int DEFAULT NULL,
  `town_id` int DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `FK_minions_towns` (`town_id`),
  CONSTRAINT `FK_minions_towns` FOREIGN KEY (`town_id`) REFERENCES `towns` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Dumping data for table minions.minions: ~7 rows (approximately)
/*!40000 ALTER TABLE `minions` DISABLE KEYS */;
INSERT INTO `minions` (`id`, `name`, `age`, `town_id`) VALUES
	(1, 'Kevin', 16, 3),
	(2, 'Mitko', 20, 1),
	(3, 'Steward', 10, 2),
	(4, 'Gosho', 9, 1),
	(5, 'Pencho', 19, 3),
	(6, 'Mincho', 22, 3),
	(7, 'Tonya', 19, 3);
/*!40000 ALTER TABLE `minions` ENABLE KEYS */;

-- Dumping structure for table minions.towns
CREATE TABLE IF NOT EXISTS `towns` (
  `id` int NOT NULL,
  `name` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Dumping data for table minions.towns: ~3 rows (approximately)
/*!40000 ALTER TABLE `towns` DISABLE KEYS */;
INSERT INTO `towns` (`id`, `name`) VALUES
	(1, 'Kalofer'),
	(2, 'Sofiq'),
	(3, 'Sopot');
/*!40000 ALTER TABLE `towns` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
