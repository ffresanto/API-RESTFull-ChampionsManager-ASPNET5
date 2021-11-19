CREATE TABLE `tb_award` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `name` VARCHAR(100) NOT NULL COMMENT 'Name of Award',
  `origin` VARCHAR(50) NULL COMMENT 'Country or origin of the award  / exemple: Brasil, Europa, America',
  `organization` VARCHAR(50) NULL COMMENT 'organization of award / exemple: CBF, UEFA, FIFA, CONMEBOL...',
  PRIMARY KEY (`id`),
  UNIQUE INDEX `id_UNIQUE` (`id` ASC) VISIBLE)
COMMENT = 'Individual Award';
