CREATE TABLE `NewTable` (
`goodsID`  varchar(255) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL ,
`goodsName`  varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL ,
`goodsPriceOut`  double(10,2) NULL DEFAULT NULL ,
`goodsAmount`  decimal(10,0) NULL DEFAULT NULL ,
`goodsPriceIn`  double(10,2) NULL DEFAULT NULL ,
`goodsUnit`  varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL ,
PRIMARY KEY (`goodsID`)
)
ENGINE=InnoDB
DEFAULT CHARACTER SET=latin1 COLLATE=latin1_swedish_ci
ROW_FORMAT=DYNAMIC
;



INSERT INTO `goods` VALUES ('001', '百岁山', 5.00, 100, 3.00, '瓶');
INSERT INTO `goods` VALUES ('002', '恒大冰泉', 1.50, 20, 1.00, '瓶');
INSERT INTO `goods` VALUES ('003', '农夫山泉', 2.50, 30, 1.50, '瓶');
INSERT INTO `goods` VALUES ('004', '康师傅', 1.70, 40, 0.80, '瓶');
