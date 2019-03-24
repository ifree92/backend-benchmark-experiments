-- MySQL dump 10.13  Distrib 5.7.25, for Linux (x86_64)
--
-- Host: localhost    Database: mydb
-- ------------------------------------------------------
-- Server version	5.7.25

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
-- Table structure for table `education`
--

DROP TABLE IF EXISTS `education`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `education` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(255) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `education`
--

LOCK TABLES `education` WRITE;
/*!40000 ALTER TABLE `education` DISABLE KEYS */;
INSERT INTO `education` VALUES (1,'Primary'),(2,'Master'),(3,'Bachelor'),(4,'Lower secondary'),(5,'Upper secondary'),(6,'Doctoral');
/*!40000 ALTER TABLE `education` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `gender`
--

DROP TABLE IF EXISTS `gender`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `gender` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(255) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `gender`
--

LOCK TABLES `gender` WRITE;
/*!40000 ALTER TABLE `gender` DISABLE KEYS */;
INSERT INTO `gender` VALUES (1,'Female'),(2,'Male');
/*!40000 ALTER TABLE `gender` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `user`
--

DROP TABLE IF EXISTS `user`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `user` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `firstName` varchar(255) NOT NULL,
  `lastName` varchar(255) NOT NULL,
  `age` int(11) NOT NULL,
  `email` varchar(255) NOT NULL,
  `educationId` int(11) DEFAULT NULL,
  `genderId` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `FK_acb88f5966421db9fc6db79345e` (`educationId`),
  KEY `FK_6273b1aa12d5d17f8e1284200be` (`genderId`),
  CONSTRAINT `FK_6273b1aa12d5d17f8e1284200be` FOREIGN KEY (`genderId`) REFERENCES `gender` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `FK_acb88f5966421db9fc6db79345e` FOREIGN KEY (`educationId`) REFERENCES `education` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=101 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `user`
--

LOCK TABLES `user` WRITE;
/*!40000 ALTER TABLE `user` DISABLE KEYS */;
INSERT INTO `user` VALUES (1,'Rubie','Richards',27,'r.richards@randatmail.com',1,1),(2,'April','Mitchell',23,'a.mitchell@randatmail.com',1,1),(3,'Thomas','Crawford',25,'t.crawford@randatmail.com',1,1),(4,'Lucy','Wright',26,'l.wright@randatmail.com',1,1),(5,'Derek','Harper',21,'d.harper@randatmail.com',1,1),(6,'Clark','Gibson',19,'c.gibson@randatmail.com',1,1),(7,'Kimberly','Baker',26,'k.baker@randatmail.com',1,1),(8,'Caroline','Kelley',30,'c.kelley@randatmail.com',1,1),(9,'Maya','Harris',22,'m.harris@randatmail.com',1,1),(10,'Kevin','Clark',27,'k.clark@randatmail.com',1,1),(11,'Roland','Cameron',30,'r.cameron@randatmail.com',1,1),(12,'Rebecca','Williams',27,'r.williams@randatmail.com',1,1),(13,'Adison','Johnson',19,'a.johnson@randatmail.com',1,1),(14,'Derek','Moore',20,'d.moore@randatmail.com',1,1),(15,'Preston','Barnes',23,'p.barnes@randatmail.com',1,1),(16,'James','Richardson',27,'j.richardson@randatmail.com',1,1),(17,'Walter','Henderson',24,'w.henderson@randatmail.com',1,1),(18,'Emily','Morris',21,'e.morris@randatmail.com',1,1),(19,'Emma','Warren',27,'e.warren@randatmail.com',1,1),(20,'Cadie','Ellis',24,'c.ellis@randatmail.com',1,1),(21,'Maximilian','Hall',28,'m.hall@randatmail.com',1,1),(22,'Alissa','Hall',22,'a.hall@randatmail.com',1,1),(23,'Vincent','Hunt',23,'v.hunt@randatmail.com',1,1),(24,'Deanna','Thomas',29,'d.thomas@randatmail.com',1,1),(25,'Vanessa','Martin',29,'v.martin@randatmail.com',1,1),(26,'Lilianna','Kelley',29,'l.kelley@randatmail.com',1,1),(27,'Roland','Alexander',26,'r.alexander@randatmail.com',1,1),(28,'Aiden','Johnson',22,'a.johnson@randatmail.com',1,1),(29,'Florrie','Spencer',27,'f.spencer@randatmail.com',1,1),(30,'David','Crawford',30,'d.crawford@randatmail.com',1,1),(31,'Max','Elliott',28,'m.elliott@randatmail.com',1,1),(32,'Chloe','Lloyd',21,'c.lloyd@randatmail.com',1,1),(33,'Adam','Dixon',26,'a.dixon@randatmail.com',1,1),(34,'Byron','Russell',20,'b.russell@randatmail.com',1,1),(35,'Kelsey','Cunningham',27,'k.cunningham@randatmail.com',1,1),(36,'Garry','Johnson',25,'g.johnson@randatmail.com',1,1),(37,'Alina','Davis',22,'a.davis@randatmail.com',1,1),(38,'Frederick','Phillips',23,'f.phillips@randatmail.com',1,1),(39,'Abigail','Barnes',21,'a.barnes@randatmail.com',1,1),(40,'John','Farrell',29,'j.farrell@randatmail.com',1,1),(41,'Aldus','Grant',30,'a.grant@randatmail.com',1,1),(42,'Roland','Armstrong',24,'r.armstrong@randatmail.com',1,1),(43,'Dexter','Adams',20,'d.adams@randatmail.com',1,1),(44,'Kate','Watson',25,'k.watson@randatmail.com',1,1),(45,'Julia','Hall',18,'j.hall@randatmail.com',1,1),(46,'Steven','Jones',27,'s.jones@randatmail.com',1,1),(47,'Aston','Morris',21,'a.morris@randatmail.com',1,1),(48,'Penelope','Alexander',29,'p.alexander@randatmail.com',1,1),(49,'Dominik','Jones',19,'d.jones@randatmail.com',1,1),(50,'Martin','Williams',28,'m.williams@randatmail.com',1,1),(51,'Freddie','Carroll',27,'f.carroll@randatmail.com',1,1),(52,'Chelsea','Moore',25,'c.moore@randatmail.com',1,1),(53,'Oscar','Warren',23,'o.warren@randatmail.com',1,1),(54,'Alford','Dixon',25,'a.dixon@randatmail.com',1,1),(55,'Henry','Roberts',25,'h.roberts@randatmail.com',1,1),(56,'Lily','Russell',27,'l.russell@randatmail.com',1,1),(57,'Nicole','Murray',25,'n.murray@randatmail.com',1,1),(58,'Justin','Riley',19,'j.riley@randatmail.com',1,1),(59,'Henry','Evans',20,'h.evans@randatmail.com',1,1),(60,'Preston','Cole',21,'p.cole@randatmail.com',1,1),(61,'Ellia','Hall',30,'e.hall@randatmail.com',1,1),(62,'Oscar','Taylor',23,'o.taylor@randatmail.com',1,1),(63,'Tess','Cunningham',24,'t.cunningham@randatmail.com',1,1),(64,'Reid','Williams',22,'r.williams@randatmail.com',1,1),(65,'Alexander','Murphy',28,'a.murphy@randatmail.com',1,1),(66,'Emma','Cole',26,'e.cole@randatmail.com',1,1),(67,'Joyce','Barrett',20,'j.barrett@randatmail.com',1,1),(68,'Freddie','Stewart',21,'f.stewart@randatmail.com',1,1),(69,'Ryan','Johnson',27,'r.johnson@randatmail.com',1,1),(70,'Owen','Murphy',30,'o.murphy@randatmail.com',1,1),(71,'Dale','Richardson',28,'d.richardson@randatmail.com',1,1),(72,'Richard','Harrison',18,'r.harrison@randatmail.com',1,1),(73,'Isabella','Scott',22,'i.scott@randatmail.com',1,1),(74,'Adam','Ross',23,'a.ross@randatmail.com',1,1),(75,'Sienna','Casey',23,'s.casey@randatmail.com',1,1),(76,'Maddie','Turner',28,'m.turner@randatmail.com',1,1),(77,'Julian','Spencer',23,'j.spencer@randatmail.com',1,1),(78,'Isabella','Perry',30,'i.perry@randatmail.com',1,1),(79,'Elian','Ferguson',19,'e.ferguson@randatmail.com',1,1),(80,'Jordan','Bailey',25,'j.bailey@randatmail.com',1,1),(81,'Maximilian','Kelly',26,'m.kelly@randatmail.com',1,1),(82,'Brad','Grant',24,'b.grant@randatmail.com',1,1),(83,'Martin','Scott',23,'m.scott@randatmail.com',1,1),(84,'Michelle','Thompson',22,'m.thompson@randatmail.com',1,1),(85,'Vanessa','Nelson',22,'v.nelson@randatmail.com',1,1),(86,'Alan','Casey',18,'a.casey@randatmail.com',1,1),(87,'Dale','Henderson',29,'d.henderson@randatmail.com',1,1),(88,'Amanda','Reed',21,'a.reed@randatmail.com',1,1),(89,'Vivian','Grant',24,'v.grant@randatmail.com',1,1),(90,'Chester','Nelson',18,'c.nelson@randatmail.com',1,1),(91,'Oscar','Martin',27,'o.martin@randatmail.com',1,1),(92,'Wilson','Howard',22,'w.howard@randatmail.com',1,1),(93,'Grace','Perkins',27,'g.perkins@randatmail.com',1,1),(94,'Tess','Wilson',21,'t.wilson@randatmail.com',1,1),(95,'Miller','Morrison',22,'m.morrison@randatmail.com',1,1),(96,'Adelaide','Ryan',30,'a.ryan@randatmail.com',1,1),(97,'Edward','Myers',18,'e.myers@randatmail.com',1,1),(98,'Lenny','Richards',22,'l.richards@randatmail.com',1,1),(99,'Adrianna','Cameron',21,'a.cameron@randatmail.com',1,1),(100,'Alan','Cole',24,'a.cole@randatmail.com',1,1);
/*!40000 ALTER TABLE `user` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2019-03-24 12:49:41