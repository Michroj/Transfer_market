-- MySQL dump 10.13  Distrib 8.0.29, for Win64 (x86_64)
--
-- Host: localhost    Database: transfermarket
-- ------------------------------------------------------
-- Server version	8.0.29

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `klub`
--

DROP TABLE IF EXISTS `klub`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `klub` (
  `id` int unsigned NOT NULL AUTO_INCREMENT,
  `nazwa` char(32) DEFAULT NULL,
  `budzet` char(32) DEFAULT NULL,
  `id_ligi` int unsigned DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `id_ligi` (`id_ligi`),
  CONSTRAINT `klub_ibfk_1` FOREIGN KEY (`id_ligi`) REFERENCES `liga` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `klub`
--

LOCK TABLES `klub` WRITE;
/*!40000 ALTER TABLE `klub` DISABLE KEYS */;
INSERT INTO `klub` VALUES (2,'LKSGoczały','1000000',1),(3,'Dzbancelona','5000000',2);
/*!40000 ALTER TABLE `klub` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `kontraktm`
--

DROP TABLE IF EXISTS `kontraktm`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `kontraktm` (
  `id` int unsigned NOT NULL AUTO_INCREMENT,
  `dlugosc` int unsigned DEFAULT NULL,
  `zarobki` char(32) DEFAULT NULL,
  `id_klubu` int unsigned DEFAULT NULL,
  `id_menadzera` int unsigned DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `id_klubu` (`id_klubu`),
  KEY `id_menadzera` (`id_menadzera`),
  CONSTRAINT `kontraktm_ibfk_1` FOREIGN KEY (`id_klubu`) REFERENCES `klub` (`id`),
  CONSTRAINT `kontraktm_ibfk_2` FOREIGN KEY (`id_menadzera`) REFERENCES `menadzer` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `kontraktm`
--

LOCK TABLES `kontraktm` WRITE;
/*!40000 ALTER TABLE `kontraktm` DISABLE KEYS */;
INSERT INTO `kontraktm` VALUES (1,2,'30000',2,2),(2,4,'50000',3,3);
/*!40000 ALTER TABLE `kontraktm` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `kontraktp`
--

DROP TABLE IF EXISTS `kontraktp`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `kontraktp` (
  `id` int unsigned NOT NULL AUTO_INCREMENT,
  `wartosc` char(32) DEFAULT NULL,
  `dlugosc` int unsigned DEFAULT NULL,
  `zarobki` char(32) DEFAULT NULL,
  `id_pilkarza` int unsigned DEFAULT NULL,
  `id_klubu` int unsigned DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `id_pilkarza` (`id_pilkarza`),
  KEY `id_klubu` (`id_klubu`),
  CONSTRAINT `kontraktp_ibfk_1` FOREIGN KEY (`id_pilkarza`) REFERENCES `pilkarz` (`id`),
  CONSTRAINT `kontraktp_ibfk_2` FOREIGN KEY (`id_klubu`) REFERENCES `klub` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `kontraktp`
--

LOCK TABLES `kontraktp` WRITE;
/*!40000 ALTER TABLE `kontraktp` DISABLE KEYS */;
INSERT INTO `kontraktp` VALUES (1,'80000000',4,'100000',1,2),(2,'15000000',2,'50000',2,2),(3,'31000000',5,'49000',3,3),(4,'40000000',2,'60000',4,3),(5,'9000000',1,'39000',5,3);
/*!40000 ALTER TABLE `kontraktp` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `liga`
--

DROP TABLE IF EXISTS `liga`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `liga` (
  `id` int unsigned NOT NULL AUTO_INCREMENT,
  `nazwa` char(32) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `liga`
--

LOCK TABLES `liga` WRITE;
/*!40000 ALTER TABLE `liga` DISABLE KEYS */;
INSERT INTO `liga` VALUES (1,'Ekstraklasa'),(2,'Laliga');
/*!40000 ALTER TABLE `liga` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `lista_transferowa`
--

DROP TABLE IF EXISTS `lista_transferowa`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `lista_transferowa` (
  `id` int unsigned NOT NULL AUTO_INCREMENT,
  `wartosc` char(32) DEFAULT NULL,
  `id_pilkarza` int unsigned DEFAULT NULL,
  `id_klubu` int unsigned DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `id_pilkarza` (`id_pilkarza`),
  KEY `id_klubu` (`id_klubu`),
  CONSTRAINT `lista_transferowa_ibfk_1` FOREIGN KEY (`id_pilkarza`) REFERENCES `pilkarz` (`id`),
  CONSTRAINT `lista_transferowa_ibfk_2` FOREIGN KEY (`id_klubu`) REFERENCES `klub` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `lista_transferowa`
--

LOCK TABLES `lista_transferowa` WRITE;
/*!40000 ALTER TABLE `lista_transferowa` DISABLE KEYS */;
/*!40000 ALTER TABLE `lista_transferowa` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `menadzer`
--

DROP TABLE IF EXISTS `menadzer`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `menadzer` (
  `id` int unsigned NOT NULL AUTO_INCREMENT,
  `imie` char(32) DEFAULT NULL,
  `nazwisko` char(32) DEFAULT NULL,
  `wiek` int unsigned DEFAULT NULL,
  `narodowosc` char(32) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `menadzer`
--

LOCK TABLES `menadzer` WRITE;
/*!40000 ALTER TABLE `menadzer` DISABLE KEYS */;
INSERT INTO `menadzer` VALUES (2,'Janusz','Polak',69,'Polska'),(3,'Hans','Zimmerman',51,'Niemcy'),(4,'Tomasz','Harnaś',22,'Polska');
/*!40000 ALTER TABLE `menadzer` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `pilkarz`
--

DROP TABLE IF EXISTS `pilkarz`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `pilkarz` (
  `id` int unsigned NOT NULL AUTO_INCREMENT,
  `imie` char(32) DEFAULT NULL,
  `nazwisko` char(32) DEFAULT NULL,
  `wiek` int unsigned DEFAULT NULL,
  `wzrost` int unsigned DEFAULT NULL,
  `narodowosc` char(32) DEFAULT NULL,
  `pozycja` enum('bramkarz','obronca','pomocnik','napastnik') DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pilkarz`
--

LOCK TABLES `pilkarz` WRITE;
/*!40000 ALTER TABLE `pilkarz` DISABLE KEYS */;
INSERT INTO `pilkarz` VALUES (1,'Harry','Magłajer',28,194,'Anglia','obronca'),(2,'Max','Verstapen',24,181,'Holandia','napastnik'),(3,'Kiwa','Jako Tako',21,163,'Japonia','napastnik'),(4,'Niko','Kiwać',26,173,'Serbia','pomocnik'),(5,'Iwan','Złapać',34,200,'Chorwacja','bramkarz');
/*!40000 ALTER TABLE `pilkarz` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `zaloguj`
--

DROP TABLE IF EXISTS `zaloguj`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `zaloguj` (
  `id_user` int unsigned NOT NULL AUTO_INCREMENT,
  `login` varchar(30) NOT NULL,
  `haslo` varchar(30) NOT NULL,
  `id_klubu` int unsigned NOT NULL,
  PRIMARY KEY (`id_user`),
  KEY `id_klubu` (`id_klubu`),
  CONSTRAINT `zaloguj_ibfk_1` FOREIGN KEY (`id_klubu`) REFERENCES `klub` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `zaloguj`
--

LOCK TABLES `zaloguj` WRITE;
/*!40000 ALTER TABLE `zaloguj` DISABLE KEYS */;
INSERT INTO `zaloguj` VALUES (2,'Goczały','Piszczek',2),(3,'Dzbancelona','Puyol',3);
/*!40000 ALTER TABLE `zaloguj` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-06-17 14:15:26
