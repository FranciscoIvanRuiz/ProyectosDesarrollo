-- MySQL dump 10.13  Distrib 5.5.15, for Win32 (x86)
--
-- Host: localhost    Database: sistemajava
-- ------------------------------------------------------
-- Server version	5.5.17

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
-- Current Database: `sistemajava`
--

CREATE DATABASE /*!32312 IF NOT EXISTS*/ `sistemajava` /*!40100 DEFAULT CHARACTER SET utf8 */;

USE `sistemajava`;

--
-- Table structure for table `articulos`
--

DROP TABLE IF EXISTS `articulos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `articulos` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `codigo` varchar(45) DEFAULT NULL,
  `nombre` varchar(45) DEFAULT NULL,
  `tiposdearticulos_id` int(11) NOT NULL,
  `empresas_id` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `codigo_UNIQUE` (`codigo`),
  KEY `fk_articulos_tiposdearticulos1_idx` (`tiposdearticulos_id`),
  KEY `fk_articulos_empresas1_idx` (`empresas_id`),
  CONSTRAINT `fk_articulos_empresas1` FOREIGN KEY (`empresas_id`) REFERENCES `empresas` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_articulos_tiposdearticulos1` FOREIGN KEY (`tiposdearticulos_id`) REFERENCES `tiposdearticulos` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `articulos`
--

LOCK TABLES `articulos` WRITE;
/*!40000 ALTER TABLE `articulos` DISABLE KEYS */;
INSERT INTO `articulos` VALUES (1,'001','CONSULTORIAS',1,5),(2,'002','MOVILIZACION',2,5);
/*!40000 ALTER TABLE `articulos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `centrosdecostos`
--

DROP TABLE IF EXISTS `centrosdecostos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `centrosdecostos` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `codigo` varchar(45) DEFAULT NULL,
  `empresas_id` int(11) NOT NULL,
  `nombre` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `codigo_UNIQUE` (`codigo`),
  KEY `fk_centrosdecostos_empresas1_idx` (`empresas_id`),
  CONSTRAINT `fk_centrosdecostos_empresas1` FOREIGN KEY (`empresas_id`) REFERENCES `empresas` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `centrosdecostos`
--

LOCK TABLES `centrosdecostos` WRITE;
/*!40000 ALTER TABLE `centrosdecostos` DISABLE KEYS */;
INSERT INTO `centrosdecostos` VALUES (1,'001',2,'PROYECTO STRATUS'),(2,'002',5,'PROYECTO MINI'),(3,'003',4,'PROYECTO CONTABILIDADES');
/*!40000 ALTER TABLE `centrosdecostos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `contadores`
--

DROP TABLE IF EXISTS `contadores`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `contadores` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `codigo` varchar(45) DEFAULT NULL,
  `nombre` varchar(45) DEFAULT NULL,
  `digitos` int(11) DEFAULT NULL,
  `desde` varchar(45) DEFAULT NULL,
  `hasta` varchar(45) DEFAULT NULL,
  `empresas_id` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `codigo_UNIQUE` (`codigo`),
  KEY `fk_contadores_empresas1_idx` (`empresas_id`),
  CONSTRAINT `fk_contadores_empresas1` FOREIGN KEY (`empresas_id`) REFERENCES `empresas` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `contadores`
--

LOCK TABLES `contadores` WRITE;
/*!40000 ALTER TABLE `contadores` DISABLE KEYS */;
INSERT INTO `contadores` VALUES (1,'001','contador',4,'1','999',5);
/*!40000 ALTER TABLE `contadores` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `dcontadores`
--

DROP TABLE IF EXISTS `dcontadores`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `dcontadores` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `codigo` varchar(45) DEFAULT NULL,
  `utilizado` varchar(1) DEFAULT NULL,
  `contadores_id` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_dcontadores_contadores1_idx` (`contadores_id`),
  CONSTRAINT `fk_dcontadores_contadores1` FOREIGN KEY (`contadores_id`) REFERENCES `contadores` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=5995 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `dcontadores`
--

LOCK TABLES `dcontadores` WRITE;
/*!40000 ALTER TABLE `dcontadores` DISABLE KEYS */;
INSERT INTO `dcontadores` VALUES (4996,'0001','N',1),(4997,'0002','N',1),(4998,'0003','N',1),(4999,'0004','N',1),(5000,'0005','N',1),(5001,'0006','N',1),(5002,'0007','N',1),(5003,'0008','N',1),(5004,'0009','N',1),(5005,'0010','N',1),(5006,'0011','N',1),(5007,'0012','N',1),(5008,'0013','N',1),(5009,'0014','N',1),(5010,'0015','N',1),(5011,'0016','N',1),(5012,'0017','N',1),(5013,'0018','N',1),(5014,'0019','N',1),(5015,'0020','N',1),(5016,'0021','N',1),(5017,'0022','N',1),(5018,'0023','N',1),(5019,'0024','N',1),(5020,'0025','N',1),(5021,'0026','N',1),(5022,'0027','N',1),(5023,'0028','N',1),(5024,'0029','N',1),(5025,'0030','N',1),(5026,'0031','N',1),(5027,'0032','N',1),(5028,'0033','N',1),(5029,'0034','N',1),(5030,'0035','N',1),(5031,'0036','N',1),(5032,'0037','N',1),(5033,'0038','N',1),(5034,'0039','N',1),(5035,'0040','N',1),(5036,'0041','N',1),(5037,'0042','N',1),(5038,'0043','N',1),(5039,'0044','N',1),(5040,'0045','N',1),(5041,'0046','N',1),(5042,'0047','N',1),(5043,'0048','N',1),(5044,'0049','N',1),(5045,'0050','N',1),(5046,'0051','N',1),(5047,'0052','N',1),(5048,'0053','N',1),(5049,'0054','N',1),(5050,'0055','N',1),(5051,'0056','N',1),(5052,'0057','N',1),(5053,'0058','N',1),(5054,'0059','N',1),(5055,'0060','N',1),(5056,'0061','N',1),(5057,'0062','N',1),(5058,'0063','N',1),(5059,'0064','N',1),(5060,'0065','N',1),(5061,'0066','N',1),(5062,'0067','N',1),(5063,'0068','N',1),(5064,'0069','N',1),(5065,'0070','N',1),(5066,'0071','N',1),(5067,'0072','N',1),(5068,'0073','N',1),(5069,'0074','N',1),(5070,'0075','N',1),(5071,'0076','N',1),(5072,'0077','N',1),(5073,'0078','N',1),(5074,'0079','N',1),(5075,'0080','N',1),(5076,'0081','N',1),(5077,'0082','N',1),(5078,'0083','N',1),(5079,'0084','N',1),(5080,'0085','N',1),(5081,'0086','N',1),(5082,'0087','N',1),(5083,'0088','N',1),(5084,'0089','N',1),(5085,'0090','N',1),(5086,'0091','N',1),(5087,'0092','N',1),(5088,'0093','N',1),(5089,'0094','N',1),(5090,'0095','N',1),(5091,'0096','N',1),(5092,'0097','N',1),(5093,'0098','N',1),(5094,'0099','N',1),(5095,'0100','N',1),(5096,'0101','N',1),(5097,'0102','N',1),(5098,'0103','N',1),(5099,'0104','N',1),(5100,'0105','N',1),(5101,'0106','N',1),(5102,'0107','N',1),(5103,'0108','N',1),(5104,'0109','N',1),(5105,'0110','N',1),(5106,'0111','N',1),(5107,'0112','N',1),(5108,'0113','N',1),(5109,'0114','N',1),(5110,'0115','N',1),(5111,'0116','N',1),(5112,'0117','N',1),(5113,'0118','N',1),(5114,'0119','N',1),(5115,'0120','N',1),(5116,'0121','N',1),(5117,'0122','N',1),(5118,'0123','N',1),(5119,'0124','N',1),(5120,'0125','N',1),(5121,'0126','N',1),(5122,'0127','N',1),(5123,'0128','N',1),(5124,'0129','N',1),(5125,'0130','N',1),(5126,'0131','N',1),(5127,'0132','N',1),(5128,'0133','N',1),(5129,'0134','N',1),(5130,'0135','N',1),(5131,'0136','N',1),(5132,'0137','N',1),(5133,'0138','N',1),(5134,'0139','N',1),(5135,'0140','N',1),(5136,'0141','N',1),(5137,'0142','N',1),(5138,'0143','N',1),(5139,'0144','N',1),(5140,'0145','N',1),(5141,'0146','N',1),(5142,'0147','N',1),(5143,'0148','N',1),(5144,'0149','N',1),(5145,'0150','N',1),(5146,'0151','N',1),(5147,'0152','N',1),(5148,'0153','N',1),(5149,'0154','N',1),(5150,'0155','N',1),(5151,'0156','N',1),(5152,'0157','N',1),(5153,'0158','N',1),(5154,'0159','N',1),(5155,'0160','N',1),(5156,'0161','N',1),(5157,'0162','N',1),(5158,'0163','N',1),(5159,'0164','N',1),(5160,'0165','N',1),(5161,'0166','N',1),(5162,'0167','N',1),(5163,'0168','N',1),(5164,'0169','N',1),(5165,'0170','N',1),(5166,'0171','N',1),(5167,'0172','N',1),(5168,'0173','N',1),(5169,'0174','N',1),(5170,'0175','N',1),(5171,'0176','N',1),(5172,'0177','N',1),(5173,'0178','N',1),(5174,'0179','N',1),(5175,'0180','N',1),(5176,'0181','N',1),(5177,'0182','N',1),(5178,'0183','N',1),(5179,'0184','N',1),(5180,'0185','N',1),(5181,'0186','N',1),(5182,'0187','N',1),(5183,'0188','N',1),(5184,'0189','N',1),(5185,'0190','N',1),(5186,'0191','N',1),(5187,'0192','N',1),(5188,'0193','N',1),(5189,'0194','N',1),(5190,'0195','N',1),(5191,'0196','N',1),(5192,'0197','N',1),(5193,'0198','N',1),(5194,'0199','N',1),(5195,'0200','N',1),(5196,'0201','N',1),(5197,'0202','N',1),(5198,'0203','N',1),(5199,'0204','N',1),(5200,'0205','N',1),(5201,'0206','N',1),(5202,'0207','N',1),(5203,'0208','N',1),(5204,'0209','N',1),(5205,'0210','N',1),(5206,'0211','N',1),(5207,'0212','N',1),(5208,'0213','N',1),(5209,'0214','N',1),(5210,'0215','N',1),(5211,'0216','N',1),(5212,'0217','N',1),(5213,'0218','N',1),(5214,'0219','N',1),(5215,'0220','N',1),(5216,'0221','N',1),(5217,'0222','N',1),(5218,'0223','N',1),(5219,'0224','N',1),(5220,'0225','N',1),(5221,'0226','N',1),(5222,'0227','N',1),(5223,'0228','N',1),(5224,'0229','N',1),(5225,'0230','N',1),(5226,'0231','N',1),(5227,'0232','N',1),(5228,'0233','N',1),(5229,'0234','N',1),(5230,'0235','N',1),(5231,'0236','N',1),(5232,'0237','N',1),(5233,'0238','N',1),(5234,'0239','N',1),(5235,'0240','N',1),(5236,'0241','N',1),(5237,'0242','N',1),(5238,'0243','N',1),(5239,'0244','N',1),(5240,'0245','N',1),(5241,'0246','N',1),(5242,'0247','N',1),(5243,'0248','N',1),(5244,'0249','N',1),(5245,'0250','N',1),(5246,'0251','N',1),(5247,'0252','N',1),(5248,'0253','N',1),(5249,'0254','N',1),(5250,'0255','N',1),(5251,'0256','N',1),(5252,'0257','N',1),(5253,'0258','N',1),(5254,'0259','N',1),(5255,'0260','N',1),(5256,'0261','N',1),(5257,'0262','N',1),(5258,'0263','N',1),(5259,'0264','N',1),(5260,'0265','N',1),(5261,'0266','N',1),(5262,'0267','N',1),(5263,'0268','N',1),(5264,'0269','N',1),(5265,'0270','N',1),(5266,'0271','N',1),(5267,'0272','N',1),(5268,'0273','N',1),(5269,'0274','N',1),(5270,'0275','N',1),(5271,'0276','N',1),(5272,'0277','N',1),(5273,'0278','N',1),(5274,'0279','N',1),(5275,'0280','N',1),(5276,'0281','N',1),(5277,'0282','N',1),(5278,'0283','N',1),(5279,'0284','N',1),(5280,'0285','N',1),(5281,'0286','N',1),(5282,'0287','N',1),(5283,'0288','N',1),(5284,'0289','N',1),(5285,'0290','N',1),(5286,'0291','N',1),(5287,'0292','N',1),(5288,'0293','N',1),(5289,'0294','N',1),(5290,'0295','N',1),(5291,'0296','N',1),(5292,'0297','N',1),(5293,'0298','N',1),(5294,'0299','N',1),(5295,'0300','N',1),(5296,'0301','N',1),(5297,'0302','N',1),(5298,'0303','N',1),(5299,'0304','N',1),(5300,'0305','N',1),(5301,'0306','N',1),(5302,'0307','N',1),(5303,'0308','N',1),(5304,'0309','N',1),(5305,'0310','N',1),(5306,'0311','N',1),(5307,'0312','N',1),(5308,'0313','N',1),(5309,'0314','N',1),(5310,'0315','N',1),(5311,'0316','N',1),(5312,'0317','N',1),(5313,'0318','N',1),(5314,'0319','N',1),(5315,'0320','N',1),(5316,'0321','N',1),(5317,'0322','N',1),(5318,'0323','N',1),(5319,'0324','N',1),(5320,'0325','N',1),(5321,'0326','N',1),(5322,'0327','N',1),(5323,'0328','N',1),(5324,'0329','N',1),(5325,'0330','N',1),(5326,'0331','N',1),(5327,'0332','N',1),(5328,'0333','N',1),(5329,'0334','N',1),(5330,'0335','N',1),(5331,'0336','N',1),(5332,'0337','N',1),(5333,'0338','N',1),(5334,'0339','N',1),(5335,'0340','N',1),(5336,'0341','N',1),(5337,'0342','N',1),(5338,'0343','N',1),(5339,'0344','N',1),(5340,'0345','N',1),(5341,'0346','N',1),(5342,'0347','N',1),(5343,'0348','N',1),(5344,'0349','N',1),(5345,'0350','N',1),(5346,'0351','N',1),(5347,'0352','N',1),(5348,'0353','N',1),(5349,'0354','N',1),(5350,'0355','N',1),(5351,'0356','N',1),(5352,'0357','N',1),(5353,'0358','N',1),(5354,'0359','N',1),(5355,'0360','N',1),(5356,'0361','N',1),(5357,'0362','N',1),(5358,'0363','N',1),(5359,'0364','N',1),(5360,'0365','N',1),(5361,'0366','N',1),(5362,'0367','N',1),(5363,'0368','N',1),(5364,'0369','N',1),(5365,'0370','N',1),(5366,'0371','N',1),(5367,'0372','N',1),(5368,'0373','N',1),(5369,'0374','N',1),(5370,'0375','N',1),(5371,'0376','N',1),(5372,'0377','N',1),(5373,'0378','N',1),(5374,'0379','N',1),(5375,'0380','N',1),(5376,'0381','N',1),(5377,'0382','N',1),(5378,'0383','N',1),(5379,'0384','N',1),(5380,'0385','N',1),(5381,'0386','N',1),(5382,'0387','N',1),(5383,'0388','N',1),(5384,'0389','N',1),(5385,'0390','N',1),(5386,'0391','N',1),(5387,'0392','N',1),(5388,'0393','N',1),(5389,'0394','N',1),(5390,'0395','N',1),(5391,'0396','N',1),(5392,'0397','N',1),(5393,'0398','N',1),(5394,'0399','N',1),(5395,'0400','N',1),(5396,'0401','N',1),(5397,'0402','N',1),(5398,'0403','N',1),(5399,'0404','N',1),(5400,'0405','N',1),(5401,'0406','N',1),(5402,'0407','N',1),(5403,'0408','N',1),(5404,'0409','N',1),(5405,'0410','N',1),(5406,'0411','N',1),(5407,'0412','N',1),(5408,'0413','N',1),(5409,'0414','N',1),(5410,'0415','N',1),(5411,'0416','N',1),(5412,'0417','N',1),(5413,'0418','N',1),(5414,'0419','N',1),(5415,'0420','N',1),(5416,'0421','N',1),(5417,'0422','N',1),(5418,'0423','N',1),(5419,'0424','N',1),(5420,'0425','N',1),(5421,'0426','N',1),(5422,'0427','N',1),(5423,'0428','N',1),(5424,'0429','N',1),(5425,'0430','N',1),(5426,'0431','N',1),(5427,'0432','N',1),(5428,'0433','N',1),(5429,'0434','N',1),(5430,'0435','N',1),(5431,'0436','N',1),(5432,'0437','N',1),(5433,'0438','N',1),(5434,'0439','N',1),(5435,'0440','N',1),(5436,'0441','N',1),(5437,'0442','N',1),(5438,'0443','N',1),(5439,'0444','N',1),(5440,'0445','N',1),(5441,'0446','N',1),(5442,'0447','N',1),(5443,'0448','N',1),(5444,'0449','N',1),(5445,'0450','N',1),(5446,'0451','N',1),(5447,'0452','N',1),(5448,'0453','N',1),(5449,'0454','N',1),(5450,'0455','N',1),(5451,'0456','N',1),(5452,'0457','N',1),(5453,'0458','N',1),(5454,'0459','N',1),(5455,'0460','N',1),(5456,'0461','N',1),(5457,'0462','N',1),(5458,'0463','N',1),(5459,'0464','N',1),(5460,'0465','N',1),(5461,'0466','N',1),(5462,'0467','N',1),(5463,'0468','N',1),(5464,'0469','N',1),(5465,'0470','N',1),(5466,'0471','N',1),(5467,'0472','N',1),(5468,'0473','N',1),(5469,'0474','N',1),(5470,'0475','N',1),(5471,'0476','N',1),(5472,'0477','N',1),(5473,'0478','N',1),(5474,'0479','N',1),(5475,'0480','N',1),(5476,'0481','N',1),(5477,'0482','N',1),(5478,'0483','N',1),(5479,'0484','N',1),(5480,'0485','N',1),(5481,'0486','N',1),(5482,'0487','N',1),(5483,'0488','N',1),(5484,'0489','N',1),(5485,'0490','N',1),(5486,'0491','N',1),(5487,'0492','N',1),(5488,'0493','N',1),(5489,'0494','N',1),(5490,'0495','N',1),(5491,'0496','N',1),(5492,'0497','N',1),(5493,'0498','N',1),(5494,'0499','N',1),(5495,'0500','N',1),(5496,'0501','N',1),(5497,'0502','N',1),(5498,'0503','N',1),(5499,'0504','N',1),(5500,'0505','N',1),(5501,'0506','N',1),(5502,'0507','N',1),(5503,'0508','N',1),(5504,'0509','N',1),(5505,'0510','N',1),(5506,'0511','N',1),(5507,'0512','N',1),(5508,'0513','N',1),(5509,'0514','N',1),(5510,'0515','N',1),(5511,'0516','N',1),(5512,'0517','N',1),(5513,'0518','N',1),(5514,'0519','N',1),(5515,'0520','N',1),(5516,'0521','N',1),(5517,'0522','N',1),(5518,'0523','N',1),(5519,'0524','N',1),(5520,'0525','N',1),(5521,'0526','N',1),(5522,'0527','N',1),(5523,'0528','N',1),(5524,'0529','N',1),(5525,'0530','N',1),(5526,'0531','N',1),(5527,'0532','N',1),(5528,'0533','N',1),(5529,'0534','N',1),(5530,'0535','N',1),(5531,'0536','N',1),(5532,'0537','N',1),(5533,'0538','N',1),(5534,'0539','N',1),(5535,'0540','N',1),(5536,'0541','N',1),(5537,'0542','N',1),(5538,'0543','N',1),(5539,'0544','N',1),(5540,'0545','N',1),(5541,'0546','N',1),(5542,'0547','N',1),(5543,'0548','N',1),(5544,'0549','N',1),(5545,'0550','N',1),(5546,'0551','N',1),(5547,'0552','N',1),(5548,'0553','N',1),(5549,'0554','N',1),(5550,'0555','N',1),(5551,'0556','N',1),(5552,'0557','N',1),(5553,'0558','N',1),(5554,'0559','N',1),(5555,'0560','N',1),(5556,'0561','N',1),(5557,'0562','N',1),(5558,'0563','N',1),(5559,'0564','N',1),(5560,'0565','N',1),(5561,'0566','N',1),(5562,'0567','N',1),(5563,'0568','N',1),(5564,'0569','N',1),(5565,'0570','N',1),(5566,'0571','N',1),(5567,'0572','N',1),(5568,'0573','N',1),(5569,'0574','N',1),(5570,'0575','N',1),(5571,'0576','N',1),(5572,'0577','N',1),(5573,'0578','N',1),(5574,'0579','N',1),(5575,'0580','N',1),(5576,'0581','N',1),(5577,'0582','N',1),(5578,'0583','N',1),(5579,'0584','N',1),(5580,'0585','N',1),(5581,'0586','N',1),(5582,'0587','N',1),(5583,'0588','N',1),(5584,'0589','N',1),(5585,'0590','N',1),(5586,'0591','N',1),(5587,'0592','N',1),(5588,'0593','N',1),(5589,'0594','N',1),(5590,'0595','N',1),(5591,'0596','N',1),(5592,'0597','N',1),(5593,'0598','N',1),(5594,'0599','N',1),(5595,'0600','N',1),(5596,'0601','N',1),(5597,'0602','N',1),(5598,'0603','N',1),(5599,'0604','N',1),(5600,'0605','N',1),(5601,'0606','N',1),(5602,'0607','N',1),(5603,'0608','N',1),(5604,'0609','N',1),(5605,'0610','N',1),(5606,'0611','N',1),(5607,'0612','N',1),(5608,'0613','N',1),(5609,'0614','N',1),(5610,'0615','N',1),(5611,'0616','N',1),(5612,'0617','N',1),(5613,'0618','N',1),(5614,'0619','N',1),(5615,'0620','N',1),(5616,'0621','N',1),(5617,'0622','N',1),(5618,'0623','N',1),(5619,'0624','N',1),(5620,'0625','N',1),(5621,'0626','N',1),(5622,'0627','N',1),(5623,'0628','N',1),(5624,'0629','N',1),(5625,'0630','N',1),(5626,'0631','N',1),(5627,'0632','N',1),(5628,'0633','N',1),(5629,'0634','N',1),(5630,'0635','N',1),(5631,'0636','N',1),(5632,'0637','N',1),(5633,'0638','N',1),(5634,'0639','N',1),(5635,'0640','N',1),(5636,'0641','N',1),(5637,'0642','N',1),(5638,'0643','N',1),(5639,'0644','N',1),(5640,'0645','N',1),(5641,'0646','N',1),(5642,'0647','N',1),(5643,'0648','N',1),(5644,'0649','N',1),(5645,'0650','N',1),(5646,'0651','N',1),(5647,'0652','N',1),(5648,'0653','N',1),(5649,'0654','N',1),(5650,'0655','N',1),(5651,'0656','N',1),(5652,'0657','N',1),(5653,'0658','N',1),(5654,'0659','N',1),(5655,'0660','N',1),(5656,'0661','N',1),(5657,'0662','N',1),(5658,'0663','N',1),(5659,'0664','N',1),(5660,'0665','N',1),(5661,'0666','N',1),(5662,'0667','N',1),(5663,'0668','N',1),(5664,'0669','N',1),(5665,'0670','N',1),(5666,'0671','N',1),(5667,'0672','N',1),(5668,'0673','N',1),(5669,'0674','N',1),(5670,'0675','N',1),(5671,'0676','N',1),(5672,'0677','N',1),(5673,'0678','N',1),(5674,'0679','N',1),(5675,'0680','N',1),(5676,'0681','N',1),(5677,'0682','N',1),(5678,'0683','N',1),(5679,'0684','N',1),(5680,'0685','N',1),(5681,'0686','N',1),(5682,'0687','N',1),(5683,'0688','N',1),(5684,'0689','N',1),(5685,'0690','N',1),(5686,'0691','N',1),(5687,'0692','N',1),(5688,'0693','N',1),(5689,'0694','N',1),(5690,'0695','N',1),(5691,'0696','N',1),(5692,'0697','N',1),(5693,'0698','N',1),(5694,'0699','N',1),(5695,'0700','N',1),(5696,'0701','N',1),(5697,'0702','N',1),(5698,'0703','N',1),(5699,'0704','N',1),(5700,'0705','N',1),(5701,'0706','N',1),(5702,'0707','N',1),(5703,'0708','N',1),(5704,'0709','N',1),(5705,'0710','N',1),(5706,'0711','N',1),(5707,'0712','N',1),(5708,'0713','N',1),(5709,'0714','N',1),(5710,'0715','N',1),(5711,'0716','N',1),(5712,'0717','N',1),(5713,'0718','N',1),(5714,'0719','N',1),(5715,'0720','N',1),(5716,'0721','N',1),(5717,'0722','N',1),(5718,'0723','N',1),(5719,'0724','N',1),(5720,'0725','N',1),(5721,'0726','N',1),(5722,'0727','N',1),(5723,'0728','N',1),(5724,'0729','N',1),(5725,'0730','N',1),(5726,'0731','N',1),(5727,'0732','N',1),(5728,'0733','N',1),(5729,'0734','N',1),(5730,'0735','N',1),(5731,'0736','N',1),(5732,'0737','N',1),(5733,'0738','N',1),(5734,'0739','N',1),(5735,'0740','N',1),(5736,'0741','N',1),(5737,'0742','N',1),(5738,'0743','N',1),(5739,'0744','N',1),(5740,'0745','N',1),(5741,'0746','N',1),(5742,'0747','N',1),(5743,'0748','N',1),(5744,'0749','N',1),(5745,'0750','N',1),(5746,'0751','N',1),(5747,'0752','N',1),(5748,'0753','N',1),(5749,'0754','N',1),(5750,'0755','N',1),(5751,'0756','N',1),(5752,'0757','N',1),(5753,'0758','N',1),(5754,'0759','N',1),(5755,'0760','N',1),(5756,'0761','N',1),(5757,'0762','N',1),(5758,'0763','N',1),(5759,'0764','N',1),(5760,'0765','N',1),(5761,'0766','N',1),(5762,'0767','N',1),(5763,'0768','N',1),(5764,'0769','N',1),(5765,'0770','N',1),(5766,'0771','N',1),(5767,'0772','N',1),(5768,'0773','N',1),(5769,'0774','N',1),(5770,'0775','N',1),(5771,'0776','N',1),(5772,'0777','N',1),(5773,'0778','N',1),(5774,'0779','N',1),(5775,'0780','N',1),(5776,'0781','N',1),(5777,'0782','N',1),(5778,'0783','N',1),(5779,'0784','N',1),(5780,'0785','N',1),(5781,'0786','N',1),(5782,'0787','N',1),(5783,'0788','N',1),(5784,'0789','N',1),(5785,'0790','N',1),(5786,'0791','N',1),(5787,'0792','N',1),(5788,'0793','N',1),(5789,'0794','N',1),(5790,'0795','N',1),(5791,'0796','N',1),(5792,'0797','N',1),(5793,'0798','N',1),(5794,'0799','N',1),(5795,'0800','N',1),(5796,'0801','N',1),(5797,'0802','N',1),(5798,'0803','N',1),(5799,'0804','N',1),(5800,'0805','N',1),(5801,'0806','N',1),(5802,'0807','N',1),(5803,'0808','N',1),(5804,'0809','N',1),(5805,'0810','N',1),(5806,'0811','N',1),(5807,'0812','N',1),(5808,'0813','N',1),(5809,'0814','N',1),(5810,'0815','N',1),(5811,'0816','N',1),(5812,'0817','N',1),(5813,'0818','N',1),(5814,'0819','N',1),(5815,'0820','N',1),(5816,'0821','N',1),(5817,'0822','N',1),(5818,'0823','N',1),(5819,'0824','N',1),(5820,'0825','N',1),(5821,'0826','N',1),(5822,'0827','N',1),(5823,'0828','N',1),(5824,'0829','N',1),(5825,'0830','N',1),(5826,'0831','N',1),(5827,'0832','N',1),(5828,'0833','N',1),(5829,'0834','N',1),(5830,'0835','N',1),(5831,'0836','N',1),(5832,'0837','N',1),(5833,'0838','N',1),(5834,'0839','N',1),(5835,'0840','N',1),(5836,'0841','N',1),(5837,'0842','N',1),(5838,'0843','N',1),(5839,'0844','N',1),(5840,'0845','N',1),(5841,'0846','N',1),(5842,'0847','N',1),(5843,'0848','N',1),(5844,'0849','N',1),(5845,'0850','N',1),(5846,'0851','N',1),(5847,'0852','N',1),(5848,'0853','N',1),(5849,'0854','N',1),(5850,'0855','N',1),(5851,'0856','N',1),(5852,'0857','N',1),(5853,'0858','N',1),(5854,'0859','N',1),(5855,'0860','N',1),(5856,'0861','N',1),(5857,'0862','N',1),(5858,'0863','N',1),(5859,'0864','N',1),(5860,'0865','N',1),(5861,'0866','N',1),(5862,'0867','N',1),(5863,'0868','N',1),(5864,'0869','N',1),(5865,'0870','N',1),(5866,'0871','N',1),(5867,'0872','N',1),(5868,'0873','N',1),(5869,'0874','N',1),(5870,'0875','N',1),(5871,'0876','N',1),(5872,'0877','N',1),(5873,'0878','N',1),(5874,'0879','N',1),(5875,'0880','N',1),(5876,'0881','N',1),(5877,'0882','N',1),(5878,'0883','N',1),(5879,'0884','N',1),(5880,'0885','N',1),(5881,'0886','N',1),(5882,'0887','N',1),(5883,'0888','N',1),(5884,'0889','N',1),(5885,'0890','N',1),(5886,'0891','N',1),(5887,'0892','N',1),(5888,'0893','N',1),(5889,'0894','N',1),(5890,'0895','N',1),(5891,'0896','N',1),(5892,'0897','N',1),(5893,'0898','N',1),(5894,'0899','N',1),(5895,'0900','N',1),(5896,'0901','N',1),(5897,'0902','N',1),(5898,'0903','N',1),(5899,'0904','N',1),(5900,'0905','N',1),(5901,'0906','N',1),(5902,'0907','N',1),(5903,'0908','N',1),(5904,'0909','N',1),(5905,'0910','N',1),(5906,'0911','N',1),(5907,'0912','N',1),(5908,'0913','N',1),(5909,'0914','N',1),(5910,'0915','N',1),(5911,'0916','N',1),(5912,'0917','N',1),(5913,'0918','N',1),(5914,'0919','N',1),(5915,'0920','N',1),(5916,'0921','N',1),(5917,'0922','N',1),(5918,'0923','N',1),(5919,'0924','N',1),(5920,'0925','N',1),(5921,'0926','N',1),(5922,'0927','N',1),(5923,'0928','N',1),(5924,'0929','N',1),(5925,'0930','N',1),(5926,'0931','N',1),(5927,'0932','N',1),(5928,'0933','N',1),(5929,'0934','N',1),(5930,'0935','N',1),(5931,'0936','N',1),(5932,'0937','N',1),(5933,'0938','N',1),(5934,'0939','N',1),(5935,'0940','N',1),(5936,'0941','N',1),(5937,'0942','N',1),(5938,'0943','N',1),(5939,'0944','N',1),(5940,'0945','N',1),(5941,'0946','N',1),(5942,'0947','N',1),(5943,'0948','N',1),(5944,'0949','N',1),(5945,'0950','N',1),(5946,'0951','N',1),(5947,'0952','N',1),(5948,'0953','N',1),(5949,'0954','N',1),(5950,'0955','N',1),(5951,'0956','N',1),(5952,'0957','N',1),(5953,'0958','N',1),(5954,'0959','N',1),(5955,'0960','N',1),(5956,'0961','N',1),(5957,'0962','N',1),(5958,'0963','N',1),(5959,'0964','N',1),(5960,'0965','N',1),(5961,'0966','N',1),(5962,'0967','N',1),(5963,'0968','N',1),(5964,'0969','N',1),(5965,'0970','N',1),(5966,'0971','N',1),(5967,'0972','N',1),(5968,'0973','N',1),(5969,'0974','N',1),(5970,'0975','N',1),(5971,'0976','N',1),(5972,'0977','N',1),(5973,'0978','N',1),(5974,'0979','N',1),(5975,'0980','N',1),(5976,'0981','N',1),(5977,'0982','N',1),(5978,'0983','N',1),(5979,'0984','N',1),(5980,'0985','N',1),(5981,'0986','N',1),(5982,'0987','N',1),(5983,'0988','N',1),(5984,'0989','N',1),(5985,'0990','N',1),(5986,'0991','N',1),(5987,'0992','N',1),(5988,'0993','N',1),(5989,'0994','N',1),(5990,'0995','N',1),(5991,'0996','N',1),(5992,'0997','N',1),(5993,'0998','N',1),(5994,'0999','N',1);
/*!40000 ALTER TABLE `dcontadores` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `dmovimientos`
--

DROP TABLE IF EXISTS `dmovimientos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `dmovimientos` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `movimientos_id` int(11) NOT NULL,
  `articulos_id` int(11) NOT NULL,
  `cantidad` decimal(18,6) DEFAULT NULL,
  `precio` decimal(18,6) DEFAULT NULL,
  `iva` decimal(18,6) DEFAULT NULL,
  `descuento` decimal(18,6) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_dmovimiento_movimiento1` (`movimientos_id`),
  KEY `fk_dmovimientos_articulos1` (`articulos_id`),
  CONSTRAINT `fk_dmovimientos_articulos1` FOREIGN KEY (`articulos_id`) REFERENCES `articulos` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_dmovimiento_movimiento1` FOREIGN KEY (`movimientos_id`) REFERENCES `movimientos` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `dmovimientos`
--

LOCK TABLES `dmovimientos` WRITE;
/*!40000 ALTER TABLE `dmovimientos` DISABLE KEYS */;
/*!40000 ALTER TABLE `dmovimientos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `empresas`
--

DROP TABLE IF EXISTS `empresas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `empresas` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(45) DEFAULT NULL,
  `ruc` varchar(45) DEFAULT NULL,
  `telefono` varchar(45) DEFAULT NULL,
  `fax` varchar(45) DEFAULT NULL,
  `correo` varchar(45) DEFAULT NULL,
  `direccion` varchar(45) DEFAULT NULL,
  `web` varchar(45) DEFAULT NULL,
  `personas_id` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `ruc_UNIQUE` (`ruc`),
  KEY `fk_empresas_personas_idx` (`personas_id`),
  CONSTRAINT `fk_empresas_personas` FOREIGN KEY (`personas_id`) REFERENCES `personas` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `empresas`
--

LOCK TABLES `empresas` WRITE;
/*!40000 ALTER TABLE `empresas` DISABLE KEYS */;
INSERT INTO `empresas` VALUES (2,'SISTEMAS INFORMATICOS','1714688213001','022866316','022866316','francisco.ivan.ruiz@gmail.com','VALLE DE LOS CHILLOS','www.sistemas.com',1),(4,'CONTABILIDADES RUIZ','1714688212001','0984495050','0984495050','francisco.ivan.ruiz@icloud.com','CAPELO','WWW',1),(5,'MINI RUIZ','1714688213003','2866360','2866360','mini.com','mini.com','mini.com',1);
/*!40000 ALTER TABLE `empresas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `modulos`
--

DROP TABLE IF EXISTS `modulos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `modulos` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `nombre_UNIQUE` (`nombre`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `modulos`
--

LOCK TABLES `modulos` WRITE;
/*!40000 ALTER TABLE `modulos` DISABLE KEYS */;
INSERT INTO `modulos` VALUES (1,'Configuraciones'),(3,'Contabilidad'),(2,'Logistica');
/*!40000 ALTER TABLE `modulos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `movimientos`
--

DROP TABLE IF EXISTS `movimientos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `movimientos` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `empresas_id` int(11) NOT NULL,
  `tipo` varchar(2) DEFAULT NULL,
  `proveedoresclientes_id` int(11) NOT NULL,
  `transacciones_id` int(11) NOT NULL,
  `serie1` varchar(45) DEFAULT NULL,
  `serie2` varchar(45) DEFAULT NULL,
  `factura` varchar(45) DEFAULT NULL,
  `fecha` date DEFAULT NULL,
  `secuencial` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_movimiento_empresas1` (`empresas_id`),
  KEY `fk_movimientos_proveedoresclientes1` (`proveedoresclientes_id`),
  KEY `fk_movimientos_transacciones1` (`transacciones_id`),
  CONSTRAINT `fk_movimiento_empresas1` FOREIGN KEY (`empresas_id`) REFERENCES `empresas` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_movimientos_proveedoresclientes1` FOREIGN KEY (`proveedoresclientes_id`) REFERENCES `proveedoresclientes` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_movimientos_transacciones1` FOREIGN KEY (`transacciones_id`) REFERENCES `transacciones` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `movimientos`
--

LOCK TABLES `movimientos` WRITE;
/*!40000 ALTER TABLE `movimientos` DISABLE KEYS */;
/*!40000 ALTER TABLE `movimientos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `parametros`
--

DROP TABLE IF EXISTS `parametros`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `parametros` (
  `ventas` int(11) DEFAULT NULL,
  `compras` int(11) DEFAULT NULL,
  `nventas` int(11) DEFAULT NULL,
  `ncompras` int(11) DEFAULT NULL,
  `empresas_id` int(11) NOT NULL,
  PRIMARY KEY (`empresas_id`),
  CONSTRAINT `fk_parametros_empresas1` FOREIGN KEY (`empresas_id`) REFERENCES `empresas` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `parametros`
--

LOCK TABLES `parametros` WRITE;
/*!40000 ALTER TABLE `parametros` DISABLE KEYS */;
/*!40000 ALTER TABLE `parametros` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `pbcatcol`
--

DROP TABLE IF EXISTS `pbcatcol`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `pbcatcol` (
  `pbc_tnam` char(193) NOT NULL,
  `pbc_tid` int(11) DEFAULT NULL,
  `pbc_ownr` char(193) NOT NULL,
  `pbc_cnam` char(193) NOT NULL,
  `pbc_cid` smallint(6) DEFAULT NULL,
  `pbc_labl` varchar(254) DEFAULT NULL,
  `pbc_lpos` smallint(6) DEFAULT NULL,
  `pbc_hdr` varchar(254) DEFAULT NULL,
  `pbc_hpos` smallint(6) DEFAULT NULL,
  `pbc_jtfy` smallint(6) DEFAULT NULL,
  `pbc_mask` varchar(31) DEFAULT NULL,
  `pbc_case` smallint(6) DEFAULT NULL,
  `pbc_hght` smallint(6) DEFAULT NULL,
  `pbc_wdth` smallint(6) DEFAULT NULL,
  `pbc_ptrn` varchar(31) DEFAULT NULL,
  `pbc_bmap` char(1) DEFAULT NULL,
  `pbc_init` varchar(254) DEFAULT NULL,
  `pbc_cmnt` varchar(254) DEFAULT NULL,
  `pbc_edit` varchar(31) DEFAULT NULL,
  `pbc_tag` varchar(254) DEFAULT NULL,
  UNIQUE KEY `pbcatc_x` (`pbc_tnam`,`pbc_ownr`,`pbc_cnam`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pbcatcol`
--

LOCK TABLES `pbcatcol` WRITE;
/*!40000 ALTER TABLE `pbcatcol` DISABLE KEYS */;
/*!40000 ALTER TABLE `pbcatcol` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `pbcatedt`
--

DROP TABLE IF EXISTS `pbcatedt`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `pbcatedt` (
  `pbe_name` varchar(30) NOT NULL,
  `pbe_edit` varchar(254) DEFAULT NULL,
  `pbe_type` smallint(6) DEFAULT NULL,
  `pbe_cntr` int(11) DEFAULT NULL,
  `pbe_seqn` smallint(6) NOT NULL,
  `pbe_flag` int(11) DEFAULT NULL,
  `pbe_work` char(32) DEFAULT NULL,
  UNIQUE KEY `pbcate_x` (`pbe_name`,`pbe_seqn`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pbcatedt`
--

LOCK TABLES `pbcatedt` WRITE;
/*!40000 ALTER TABLE `pbcatedt` DISABLE KEYS */;
INSERT INTO `pbcatedt` VALUES ('#####','#####',90,1,1,32,'10'),('###,###.00','###,###.00',90,1,1,32,'10'),('###-##-####','###-##-####',90,1,1,32,'00'),('DD/MM/YY','DD/MM/YY',90,1,1,32,'20'),('DD/MM/YY HH:MM:SS','DD/MM/YY HH:MM:SS',90,1,1,32,'40'),('DD/MM/YY HH:MM:SS:FFFFFF','DD/MM/YY HH:MM:SS:FFFFFF',90,1,1,32,'40'),('DD/MM/YYYY','DD/MM/YYYY',90,1,1,32,'20'),('DD/MM/YYYY HH:MM:SS','DD/MM/YYYY HH:MM:SS',90,1,1,32,'40'),('DD/MMM/YY','DD/MMM/YY',90,1,1,32,'20'),('DD/MMM/YY HH:MM:SS','DD/MMM/YY HH:MM:SS',90,1,1,32,'40'),('HH:MM:SS','HH:MM:SS',90,1,1,32,'30'),('HH:MM:SS:FFF','HH:MM:SS:FFF',90,1,1,32,'30'),('HH:MM:SS:FFFFFF','HH:MM:SS:FFFFFF',90,1,1,32,'30'),('JJJ/YY','JJJ/YY',90,1,1,32,'20'),('JJJ/YY HH:MM:SS','JJJ/YY HH:MM:SS',90,1,1,32,'40'),('JJJ/YYYY','JJJ/YYYY',90,1,1,32,'20'),('JJJ/YYYY HH:MM:SS','JJJ/YYYY HH:MM:SS',90,1,1,32,'40'),('MM/DD/YY','MM/DD/YY',90,1,1,32,'20'),('MM/DD/YY HH:MM:SS','MM/DD/YY HH:MM:SS',90,1,1,32,'40'),('MM/DD/YYYY','MM/DD/YYYY',90,1,1,32,'20'),('MM/DD/YYYY HH:MM:SS','MM/DD/YYYY HH:MM:SS',90,1,1,32,'40');
/*!40000 ALTER TABLE `pbcatedt` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `pbcatfmt`
--

DROP TABLE IF EXISTS `pbcatfmt`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `pbcatfmt` (
  `pbf_name` varchar(30) NOT NULL,
  `pbf_frmt` varchar(254) DEFAULT NULL,
  `pbf_type` smallint(6) DEFAULT NULL,
  `pbf_cntr` int(11) DEFAULT NULL,
  UNIQUE KEY `pbcatf_x` (`pbf_name`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pbcatfmt`
--

LOCK TABLES `pbcatfmt` WRITE;
/*!40000 ALTER TABLE `pbcatfmt` DISABLE KEYS */;
INSERT INTO `pbcatfmt` VALUES ('#,##0','#,##0',81,0),('#,##0.00','#,##0.00',81,0),('$#,##0.00;($#,##0.00)','$#,##0.00;($#,##0.00)',81,0),('$#,##0.00;[RED]($#,##0.00)','$#,##0.00;[RED]($#,##0.00)',81,0),('$#,##0;($#,##0)','$#,##0;($#,##0)',81,0),('$#,##0;[RED]($#,##0)','$#,##0;[RED]($#,##0)',81,0),('0','0',81,0),('0%','0%',81,0),('0.00','0.00',81,0),('0.00%','0.00%',81,0),('0.00E+00','0.00E+00',81,0),('d-mmm','d-mmm',84,0),('d-mmm-yy','d-mmm-yy',84,0),('h:mm AM/PM','h:mm AM/PM',84,0),('h:mm:ss','h:mm:ss',84,0),('h:mm:ss AM/PM','h:mm:ss AM/PM',84,0),('m/d/yy','m/d/yy',84,0),('m/d/yy h:mm','m/d/yy h:mm',84,0),('mmm-yy','mmm-yy',84,0),('[General]','[General]',81,0);
/*!40000 ALTER TABLE `pbcatfmt` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `pbcattbl`
--

DROP TABLE IF EXISTS `pbcattbl`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `pbcattbl` (
  `pbt_tnam` char(193) NOT NULL,
  `pbt_tid` int(11) DEFAULT NULL,
  `pbt_ownr` char(193) NOT NULL,
  `pbd_fhgt` smallint(6) DEFAULT NULL,
  `pbd_fwgt` smallint(6) DEFAULT NULL,
  `pbd_fitl` char(1) DEFAULT NULL,
  `pbd_funl` char(1) DEFAULT NULL,
  `pbd_fchr` smallint(6) DEFAULT NULL,
  `pbd_fptc` smallint(6) DEFAULT NULL,
  `pbd_ffce` char(18) DEFAULT NULL,
  `pbh_fhgt` smallint(6) DEFAULT NULL,
  `pbh_fwgt` smallint(6) DEFAULT NULL,
  `pbh_fitl` char(1) DEFAULT NULL,
  `pbh_funl` char(1) DEFAULT NULL,
  `pbh_fchr` smallint(6) DEFAULT NULL,
  `pbh_fptc` smallint(6) DEFAULT NULL,
  `pbh_ffce` char(18) DEFAULT NULL,
  `pbl_fhgt` smallint(6) DEFAULT NULL,
  `pbl_fwgt` smallint(6) DEFAULT NULL,
  `pbl_fitl` char(1) DEFAULT NULL,
  `pbl_funl` char(1) DEFAULT NULL,
  `pbl_fchr` smallint(6) DEFAULT NULL,
  `pbl_fptc` smallint(6) DEFAULT NULL,
  `pbl_ffce` char(18) DEFAULT NULL,
  `pbt_cmnt` varchar(254) DEFAULT NULL,
  UNIQUE KEY `pbcatt_x` (`pbt_tnam`,`pbt_ownr`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pbcattbl`
--

LOCK TABLES `pbcattbl` WRITE;
/*!40000 ALTER TABLE `pbcattbl` DISABLE KEYS */;
/*!40000 ALTER TABLE `pbcattbl` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `pbcatvld`
--

DROP TABLE IF EXISTS `pbcatvld`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `pbcatvld` (
  `pbv_name` varchar(30) NOT NULL,
  `pbv_vald` varchar(254) DEFAULT NULL,
  `pbv_type` smallint(6) DEFAULT NULL,
  `pbv_cntr` int(11) DEFAULT NULL,
  `pbv_msg` varchar(254) DEFAULT NULL,
  UNIQUE KEY `pbcatv_x` (`pbv_name`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pbcatvld`
--

LOCK TABLES `pbcatvld` WRITE;
/*!40000 ALTER TABLE `pbcatvld` DISABLE KEYS */;
/*!40000 ALTER TABLE `pbcatvld` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `personas`
--

DROP TABLE IF EXISTS `personas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `personas` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `cedula` varchar(45) DEFAULT NULL,
  `nombre1` varchar(45) DEFAULT NULL,
  `nombre2` varchar(45) DEFAULT NULL,
  `apellido1` varchar(45) DEFAULT NULL,
  `apellido2` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `cedula_UNIQUE` (`cedula`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `personas`
--

LOCK TABLES `personas` WRITE;
/*!40000 ALTER TABLE `personas` DISABLE KEYS */;
INSERT INTO `personas` VALUES (1,'1714688213','FRANCISCO','IVAN','RUIZ','SIMBANA');
/*!40000 ALTER TABLE `personas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `proveedoresclientes`
--

DROP TABLE IF EXISTS `proveedoresclientes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `proveedoresclientes` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `codigo` varchar(45) DEFAULT NULL,
  `ruc` varchar(45) DEFAULT NULL,
  `nombres` varchar(45) DEFAULT NULL,
  `direccion` varchar(45) DEFAULT NULL,
  `telefono1` varchar(45) DEFAULT NULL,
  `telefono2` varchar(45) DEFAULT NULL,
  `telefono3` varchar(45) DEFAULT NULL,
  `correo` varchar(45) DEFAULT NULL,
  `representante` varchar(45) DEFAULT NULL,
  `empresas_id` int(11) NOT NULL,
  `rentabien` int(11) DEFAULT NULL,
  `rentaservicio` int(11) DEFAULT NULL,
  `rentatransporte` int(11) DEFAULT NULL,
  `ivabien` int(11) DEFAULT NULL,
  `ivaservicios` int(11) DEFAULT NULL,
  `ivatransporte` int(11) DEFAULT NULL,
  `tipo` varchar(2) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_proveedores_empresas1` (`empresas_id`),
  CONSTRAINT `fk_proveedores_empresas1` FOREIGN KEY (`empresas_id`) REFERENCES `empresas` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `proveedoresclientes`
--

LOCK TABLES `proveedoresclientes` WRITE;
/*!40000 ALTER TABLE `proveedoresclientes` DISABLE KEYS */;
INSERT INTO `proveedoresclientes` VALUES (1,'001','1714688213','FRANCISCO IVAN RUIZ SIMBANA','VALLE DE LOS CHILLOS','2866136','0984495050',NULL,'francisco.ivan.ruiz@gmail.com','FRANCISCO RUIZ',5,1,2,3,4,4,4,'PR');
/*!40000 ALTER TABLE `proveedoresclientes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `retenciones`
--

DROP TABLE IF EXISTS `retenciones`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `retenciones` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `movimientos_id` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_retenciones_movimientos1` (`movimientos_id`),
  CONSTRAINT `fk_retenciones_movimientos1` FOREIGN KEY (`movimientos_id`) REFERENCES `movimientos` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `retenciones`
--

LOCK TABLES `retenciones` WRITE;
/*!40000 ALTER TABLE `retenciones` DISABLE KEYS */;
/*!40000 ALTER TABLE `retenciones` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tiposdearticulos`
--

DROP TABLE IF EXISTS `tiposdearticulos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tiposdearticulos` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `codigo` varchar(45) DEFAULT NULL,
  `nombre` varchar(45) DEFAULT NULL,
  `tipo` varchar(2) DEFAULT NULL,
  `empresas_id` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `codigo_UNIQUE` (`codigo`),
  KEY `fk_tiposdearticulos_empresas1_idx` (`empresas_id`),
  CONSTRAINT `fk_tiposdearticulos_empresas1` FOREIGN KEY (`empresas_id`) REFERENCES `empresas` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tiposdearticulos`
--

LOCK TABLES `tiposdearticulos` WRITE;
/*!40000 ALTER TABLE `tiposdearticulos` DISABLE KEYS */;
INSERT INTO `tiposdearticulos` VALUES (1,'001','COMPUTADORAS','01',5),(2,'002','TAXIS FRANCISCO RUIZ','02',5),(3,'003','CONTABILIDADES','02',4),(4,'004','TRASNPORTES','03',4);
/*!40000 ALTER TABLE `tiposdearticulos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tiposderetenciones`
--

DROP TABLE IF EXISTS `tiposderetenciones`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tiposderetenciones` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `codigo` varchar(45) DEFAULT NULL,
  `nombre` varchar(45) DEFAULT NULL,
  `porcentaje` decimal(10,0) DEFAULT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `codigo_UNIQUE` (`codigo`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tiposderetenciones`
--

LOCK TABLES `tiposderetenciones` WRITE;
/*!40000 ALTER TABLE `tiposderetenciones` DISABLE KEYS */;
INSERT INTO `tiposderetenciones` VALUES (1,'341','OTRAS RETENCIONES DE SERVICIOS 2%',2),(2,'312','TRANS.DE BIENES MUEBLE DE NAT. CORPORAL',1),(3,'721','RETENCION IVA 30%',30),(4,'723','RETENCION IVA 70%',70),(5,'725','RETENCION IVA 100%',100);
/*!40000 ALTER TABLE `tiposderetenciones` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `transacciones`
--

DROP TABLE IF EXISTS `transacciones`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `transacciones` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `codigo` varchar(45) DEFAULT NULL,
  `nombre` varchar(45) DEFAULT NULL,
  `empresas_id` int(11) NOT NULL,
  `tipo` varchar(2) DEFAULT NULL,
  `contadores_id` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `codigo_UNIQUE` (`codigo`),
  KEY `fk_transacciones_empresas1_idx` (`empresas_id`),
  KEY `fk_transacciones_contadores1` (`contadores_id`),
  CONSTRAINT `fk_transacciones_contadores1` FOREIGN KEY (`contadores_id`) REFERENCES `contadores` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_transacciones_empresas1` FOREIGN KEY (`empresas_id`) REFERENCES `empresas` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `transacciones`
--

LOCK TABLES `transacciones` WRITE;
/*!40000 ALTER TABLE `transacciones` DISABLE KEYS */;
INSERT INTO `transacciones` VALUES (1,'001','001',5,'I',1);
/*!40000 ALTER TABLE `transacciones` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuarios`
--

DROP TABLE IF EXISTS `usuarios`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `usuarios` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `usuario` varchar(10) DEFAULT NULL,
  `clave` varchar(10) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuarios`
--

LOCK TABLES `usuarios` WRITE;
/*!40000 ALTER TABLE `usuarios` DISABLE KEYS */;
INSERT INTO `usuarios` VALUES (1,'ADMIN','ADMIN');
/*!40000 ALTER TABLE `usuarios` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2014-08-05 21:40:40
