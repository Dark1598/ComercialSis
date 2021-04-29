-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema ComercialDb
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema ComercialDb
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `ComercialDb` DEFAULT CHARACTER SET utf8 ;
USE `ComercialDb` ;

-- -----------------------------------------------------
-- Table `ComercialDb`.`Usuarios`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `ComercialDb`.`Usuarios` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `nome` VARCHAR(45) NOT NULL,
  `email` VARCHAR(45) NOT NULL,
  `senha` VARCHAR(32) NOT NULL,
  `nivel` VARCHAR(20) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE INDEX `email_UNIQUE` (`email` ASC) )
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `ComercialDb`.`Clientes`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `ComercialDb`.`Clientes` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `nome` VARCHAR(45) NOT NULL,
  `cpf` CHAR(11) NOT NULL,
  `email` VARCHAR(45) NOT NULL,
  `telefone` VARCHAR(14) NULL,
  `data_cad` TIMESTAMP NOT NULL DEFAULT current_timestamp,
  `senha` CHAR(32) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE INDEX `cpf_UNIQUE` (`cpf` ASC) ,
  UNIQUE INDEX `email_UNIQUE` (`email` ASC) )
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `ComercialDb`.`Pedidos`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `ComercialDb`.`Pedidos` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `data` TIMESTAMP NOT NULL DEFAULT current_timestamp,
  `desconto` DECIMAL(10,2) NOT NULL,
  `situacao` CHAR(3) NOT NULL DEFAULT 'nvo',
  `id_cli` INT NOT NULL,
  `id_usu` INT NOT NULL,
  PRIMARY KEY (`id`),
  INDEX `fk_Pedidos_Clientes_idx` (`id_cli` ASC) ,
  INDEX `fk_Pedidos_Usuarios1_idx` (`id_usu` ASC) ,
  CONSTRAINT `fk_Pedidos_Clientes`
    FOREIGN KEY (`id_cli`)
    REFERENCES `ComercialDb`.`Clientes` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Pedidos_Usuarios1`
    FOREIGN KEY (`id_usu`)
    REFERENCES `ComercialDb`.`Usuarios` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `ComercialDb`.`Produtos`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `ComercialDb`.`Produtos` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `descricao` VARCHAR(90) NOT NULL,
  `cod_bar` VARCHAR(32) NOT NULL,
  `valor` DECIMAL(10,2) NOT NULL,
  `desconto` DECIMAL(10,2) NOT NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `ComercialDb`.`ItemPedido`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `ComercialDb`.`ItemPedido` (
  `id_ped` INT NOT NULL,
  `id_prod` INT NOT NULL,
  `valor` DECIMAL(10,2) NOT NULL,
  `quantidade` DECIMAL(10,2) NOT NULL,
  `desconto` DECIMAL(10,2) NOT NULL,
  INDEX `fk_ItemPedido_Pedidos1_idx` (`id_ped` ASC) ,
  INDEX `fk_ItemPedido_Produtos1_idx` (`id_prod` ASC) ,
  CONSTRAINT `fk_ItemPedido_Pedidos1`
    FOREIGN KEY (`id_ped`)
    REFERENCES `ComercialDb`.`Pedidos` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_ItemPedido_Produtos1`
    FOREIGN KEY (`id_prod`)
    REFERENCES `ComercialDb`.`Produtos` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
