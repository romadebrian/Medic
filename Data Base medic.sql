/*
SQLyog Enterprise - MySQL GUI v5.26
Host - 5.0.45-community-nt : Database - medical
*********************************************************************
Server version : 5.0.45-community-nt
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

create database if not exists `medical`;

USE `medical`;

/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;

/*Table structure for table `dokter` */

DROP TABLE IF EXISTS `dokter`;

CREATE TABLE `dokter` (
  `kd_dokter` varchar(10) NOT NULL,
  `nama_dokter` varchar(40) default NULL,
  `sip` varchar(15) default NULL,
  `alamat` varchar(50) default NULL,
  `telp` varchar(15) default NULL,
  PRIMARY KEY  (`kd_dokter`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

/*Data for the table `dokter` */

insert  into `dokter`(`kd_dokter`,`nama_dokter`,`sip`,`alamat`,`telp`) values ('1','Abraham','SU883','Jl.Pamungkas','08956456456'),('2','Suratman','SU0876','JL.Astor','087676767645'),('3','Maborosiki','SU007','Jl.Rumah Bahagia','099798789698'),('4','Fahmi','SU9977','Jl. Rawa bacang','09987879978'),('5','Leha','Su004','Jl.Kebangkitan Dari Kematian','09886768998');

/*Table structure for table `obat` */

DROP TABLE IF EXISTS `obat`;

CREATE TABLE `obat` (
  `kd_obat` varchar(10) NOT NULL,
  `nama_obat` varchar(50) default NULL,
  `stok` double default NULL,
  `ukuran` varchar(15) default NULL,
  `harga` varchar(255) default NULL,
  PRIMARY KEY  (`kd_obat`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

/*Data for the table `obat` */

insert  into `obat`(`kd_obat`,`nama_obat`,`stok`,`ukuran`,`harga`) values ('OBT001','Komidin',2,'10','10,000'),('OBT002','Paramex',19,'5','7,000'),('OBT003','Ansaplast',60,'8','11,000'),('OBT004','Konimex',3,'10','10,000'),('OBT005','Betadin',10,'2','12,000'),('OBT006','Maspirin',100,'5','10,000'),('OBT007','OBH',80,'10','15,000'),('OBT008','Repanol',54,'4','8,000'),('OBT009','Konimex',11,'4','14,000'),('OBT010','Parasetamol',23,'10','8,000'),('OBT011','Venik',40,'6','3,000'),('OBT012','Bodrex',100,'5','5,000'),('OBT013','Jefuk',57,'10','10,000'),('OBT014','Kontraflu',100,'6','10,000'),('OBT015','Helium',180,'10','15,000'),('OBT016','Antangin',100,'12','11,000'),('OBT017','Promag',90,'10','15,000'),('OBT018','Hena',10,'5','18,000');

/*Table structure for table `pasien` */

DROP TABLE IF EXISTS `pasien`;

CREATE TABLE `pasien` (
  `no_pasien` varchar(10) NOT NULL,
  `nama_pasien` varchar(40) default NULL,
  `jenkel` varchar(20) default NULL,
  `agama` varchar(20) default NULL,
  `alamat` varchar(50) default NULL,
  `tgl_lahir` date default NULL,
  `telp` varchar(15) default NULL,
  PRIMARY KEY  (`no_pasien`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

/*Data for the table `pasien` */

insert  into `pasien`(`no_pasien`,`nama_pasien`,`jenkel`,`agama`,`alamat`,`tgl_lahir`,`telp`) values ('1','Danang','Laki - Laki','Protestan','Jl.Keluar','2017-09-25','1'),('2','Kasima','Perempuan','Kristen','Jl.Gekkan Shojo','1994-06-17','0809809809a'),('3','Brain','Laki - Laki','Katolik','kfkshefkshfk','2000-11-01','0210000989800'),('4','Alice','Perempuan','Kristen','Jl. Mawar 1','1992-06-19','4'),('5','Runa','Perempuan','Hindu','Jl. Frost','2003-05-11','5'),('6','Maryam','Perempuan','Islam','Jl. Kebenaran','2017-11-05','083877587343'),('7','Maling','Perempuan','Hindu','Jl.Ngak Bener','2015-06-08','7');

/*Table structure for table `rekam_medis` */

DROP TABLE IF EXISTS `rekam_medis`;

CREATE TABLE `rekam_medis` (
  `no_rekam` varchar(20) NOT NULL,
  `tgl` date default NULL,
  `keluhan` varchar(100) default NULL,
  `diagnosa` varchar(70) default NULL,
  `keterangan` varchar(50) default NULL,
  `jumlah_obat` int(11) default NULL,
  `biaya_dokter` varchar(100) default NULL,
  `biaya_obat` varchar(100) default NULL,
  `total` varchar(100) default NULL,
  `kd_dokter` varchar(10) default NULL,
  `no_pasien` varchar(10) default NULL,
  `kd_user` varchar(10) default NULL,
  PRIMARY KEY  (`no_rekam`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

/*Data for the table `rekam_medis` */

insert  into `rekam_medis`(`no_rekam`,`tgl`,`keluhan`,`diagnosa`,`keterangan`,`jumlah_obat`,`biaya_dokter`,`biaya_obat`,`total`,`kd_dokter`,`no_pasien`,`kd_user`) values ('RKM/2017/000001','2017-11-13','Lapar','Mag','Kaga Punya Diut',102,'20,000','1,530,000','1,550,000','3','5',''),('RKM/2017/000002','2017-11-14','gdg','hgfnhgf','gfdnhg',32,'20,000','448,000','468,000','4','3','');

/*Table structure for table `user` */

DROP TABLE IF EXISTS `user`;

CREATE TABLE `user` (
  `kd_user` varchar(10) NOT NULL,
  `nama` varchar(25) default NULL,
  `password` varchar(30) default NULL,
  PRIMARY KEY  (`kd_user`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

/*Data for the table `user` */

insert  into `user`(`kd_user`,`nama`,`password`) values ('1','Roma','1'),('2','Roma Debrian','1'),('3','Gilgamesh','1'),('4','Hero','1'),('5','Admin','1');

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
