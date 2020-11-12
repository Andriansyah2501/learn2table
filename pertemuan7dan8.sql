/*
SQLyog Ultimate v11.11 (64 bit)
MySQL - 5.5.27 : Database - pratikum7
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`pratikum7` /*!40100 DEFAULT CHARACTER SET latin1 */;

USE `pratikum7`;

/*Table structure for table `buku` */

DROP TABLE IF EXISTS `buku`;

CREATE TABLE `buku` (
  `bukuid` char(5) NOT NULL DEFAULT '',
  `bukujudul` varchar(100) DEFAULT NULL,
  `jenisid` int(11) DEFAULT NULL,
  PRIMARY KEY (`bukuid`),
  KEY `FK_buku_jenis` (`jenisid`),
  CONSTRAINT `FK_buku_jenis` FOREIGN KEY (`jenisid`) REFERENCES `jenis` (`jenisid`) ON DELETE NO ACTION ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `buku` */

/*Table structure for table `jenis` */

DROP TABLE IF EXISTS `jenis`;

CREATE TABLE `jenis` (
  `jenisid` int(11) NOT NULL AUTO_INCREMENT,
  `jenisnama` varchar(50) NOT NULL DEFAULT '',
  PRIMARY KEY (`jenisid`)
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=latin1;

/*Data for the table `jenis` */

insert  into `jenis`(`jenisid`,`jenisnama`) values (1,'Novel Islami'),(2,'Sejarah'),(3,'Teknologi'),(4,'Belajar'),(5,'Makanan'),(6,'Minuman'),(7,'Travelling'),(8,'baju'),(9,'pakaian'),(10,'celana'),(11,'teknik'),(12,'pokok'),(13,'dapurmama');

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
