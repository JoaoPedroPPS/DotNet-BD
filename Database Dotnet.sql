-- --------------------------------------------------------
-- Servidor:                     127.0.0.1
-- Versão do servidor:           10.4.22-MariaDB - mariadb.org binary distribution
-- OS do Servidor:               Win64
-- HeidiSQL Versão:              11.3.0.6295
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- Copiando estrutura do banco de dados para dotnet
CREATE DATABASE IF NOT EXISTS `dotnet` /*!40100 DEFAULT CHARACTER SET utf8mb4 */;
USE `dotnet`;

-- Copiando estrutura para procedure dotnet.alteraCategoria
DELIMITER //
CREATE PROCEDURE `alteraCategoria`(nomeCategoria VARCHAR(100), idCategoria int)
BEGIN
UPDATE `dotnet`.`categoria`
SET
`nomeCategoria` = nomeCategoria
WHERE `idCategoria` = idCategoria;
END//
DELIMITER ;

-- Copiando estrutura para procedure dotnet.alteraProduto
DELIMITER //
CREATE PROCEDURE `alteraProduto`(nomeProduto varchar(50), 
     descricaoProduto varchar(50), precoProduto float, idFornecedor INT, idCategoria int)
BEGIN
UPDATE `dotnet`.`produto`
SET
`nomeProduto` = nomeProduto,
`idCategoria` = idCategoria,
`idFornecedor` = idFornecedor,
`descricaoProduto` = descricaoProduto,
`precoProduto` = precoProduto
WHERE `idProduto` = idProduto;
END//
DELIMITER ;

-- Copiando estrutura para procedure dotnet.altera_fornecedor
DELIMITER //
CREATE PROCEDURE `altera_fornecedor`(idfor
int, nomeFornecedor VARCHAR(15), cnpj int)
BEGIN
UPDATE `dotnet`.`fornecedor`
SET
`nomeFornecedor` = nomeFornecedor,
`cnpj` = cnpj
WHERE `idFornecedor` = idfor;
END//
DELIMITER ;

-- Copiando estrutura para tabela dotnet.categoria
CREATE TABLE IF NOT EXISTS `categoria` (
  `idCategoria` int(11) NOT NULL AUTO_INCREMENT,
  `nomeCategoria` varchar(40) NOT NULL,
  PRIMARY KEY (`idCategoria`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4;

-- Copiando dados para a tabela dotnet.categoria: ~6 rows (aproximadamente)
/*!40000 ALTER TABLE `categoria` DISABLE KEYS */;
INSERT INTO `categoria` (`idCategoria`, `nomeCategoria`) VALUES
	(1, 'computadores'),
	(2, 'processador'),
	(3, 'perifericos'),
	(4, 'celulares'),
	(5, 'gpu'),
	(6, 'apu');
/*!40000 ALTER TABLE `categoria` ENABLE KEYS */;

-- Copiando estrutura para procedure dotnet.deletaProduto
DELIMITER //
CREATE PROCEDURE `deletaProduto`(idProduto int)
BEGIN
DELETE FROM `dotnet`.`produto`
WHERE produto.idProduto = idproduto;
END//
DELIMITER ;

-- Copiando estrutura para procedure dotnet.deleta_categoria
DELIMITER //
CREATE PROCEDURE `deleta_categoria`(idca
integer)
BEGIN
DELETE FROM `dotnet`.`categoria`
WHERE categoria.idCategoria = idca;
END//
DELIMITER ;

-- Copiando estrutura para procedure dotnet.deleta_fornecedor
DELIMITER //
CREATE PROCEDURE `deleta_fornecedor`(idfor
integer)
BEGIN
DELETE FROM `dotnet`.`fornecedor`
WHERE fornecedor.idFornecedor = idfor;
END//
DELIMITER ;

-- Copiando estrutura para tabela dotnet.fornecedor
CREATE TABLE IF NOT EXISTS `fornecedor` (
  `idFornecedor` int(11) NOT NULL AUTO_INCREMENT,
  `nomeFornecedor` varchar(10) NOT NULL,
  `cnpj` int(11) NOT NULL,
  PRIMARY KEY (`idFornecedor`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4;

-- Copiando dados para a tabela dotnet.fornecedor: ~4 rows (aproximadamente)
/*!40000 ALTER TABLE `fornecedor` DISABLE KEYS */;
INSERT INTO `fornecedor` (`idFornecedor`, `nomeFornecedor`, `cnpj`) VALUES
	(1, 'nvidia', 599),
	(2, 'intel', 363),
	(3, 'corsair', 459),
	(4, 'nzxt', 872);
/*!40000 ALTER TABLE `fornecedor` ENABLE KEYS */;

-- Copiando estrutura para procedure dotnet.insereCategoria
DELIMITER //
CREATE PROCEDURE `insereCategoria`(nomeCategoria VARCHAR(100))
BEGIN
INSERT INTO dotnet.categoria
(`nomeCategoria`)
VALUES
(nomeCategoria);
END//
DELIMITER ;

-- Copiando estrutura para procedure dotnet.insereFornecedor
DELIMITER //
CREATE PROCEDURE `insereFornecedor`(nomeFornecedor VARCHAR(100), cnpj INT)
BEGIN
INSERT INTO dotnet.produto
(`nomeFornecedor`,
`cnpj`)
VALUES
(nomeFornecedor,
cnpj);
END//
DELIMITER ;

-- Copiando estrutura para procedure dotnet.insereProduto
DELIMITER //
CREATE PROCEDURE `insereProduto`(nomeProduto varchar(50), 
     descricaoProduto varchar(50), precoProduto float, idFornecedor INT, idCategoria int)
BEGIN
INSERT INTO dotnet.produto
(`nomeProduto`,
`descricaoProduto`,
`precoProduto`,`idFornecedor`,`idCategoria`)
VALUES
(`nomeProduto`,
`descricaoProduto`,
`precoProduto`,`idFornecedor`,`idCategoria`);
END//
DELIMITER ;

-- Copiando estrutura para procedure dotnet.insere_categoria
DELIMITER //
CREATE PROCEDURE `insere_categoria`(idcat int,
nomeCategoria VARCHAR(15))
BEGIN
INSERT INTO dotnet.categoria
(`nomeCategoria`)
VALUES
(nomeCategoria);
END//
DELIMITER ;

-- Copiando estrutura para procedure dotnet.lista_categoria
DELIMITER //
CREATE PROCEDURE `lista_categoria`()
BEGIN
 SELECT * FROM dotnet.categoria;
END//
DELIMITER ;

-- Copiando estrutura para procedure dotnet.lista_fornecedor
DELIMITER //
CREATE PROCEDURE `lista_fornecedor`()
BEGIN
 SELECT * FROM dotnet.fornecedor;
END//
DELIMITER ;

-- Copiando estrutura para procedure dotnet.lista_produto
DELIMITER //
CREATE PROCEDURE `lista_produto`()
BEGIN
 SELECT * FROM dotnet.produto;
END//
DELIMITER ;

-- Copiando estrutura para tabela dotnet.produto
CREATE TABLE IF NOT EXISTS `produto` (
  `idProduto` int(11) NOT NULL AUTO_INCREMENT,
  `idFornecedor` int(11) DEFAULT NULL,
  `idCategoria` int(10) DEFAULT NULL,
  `nomeProduto` varchar(15) NOT NULL,
  `descricaoProduto` varchar(45) NOT NULL,
  `precoProduto` decimal(10,0) NOT NULL,
  PRIMARY KEY (`idProduto`),
  KEY `idCategoria` (`idCategoria`),
  KEY `idFornecedor` (`idFornecedor`),
  CONSTRAINT `produto_ibfk_1` FOREIGN KEY (`idCategoria`) REFERENCES `categoria` (`idCategoria`),
  CONSTRAINT `produto_ibfk_2` FOREIGN KEY (`idFornecedor`) REFERENCES `fornecedor` (`idFornecedor`)
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=utf8;

-- Copiando dados para a tabela dotnet.produto: ~2 rows (aproximadamente)
/*!40000 ALTER TABLE `produto` DISABLE KEYS */;
INSERT INTO `produto` (`idProduto`, `idFornecedor`, `idCategoria`, `nomeProduto`, `descricaoProduto`, `precoProduto`) VALUES
	(12, 2, 2, 'corei9', 'processor', 1500),
	(13, 2, 2, 'corei9', 'processor', 1500);
/*!40000 ALTER TABLE `produto` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
