CREATE TABLE `NewTable` (
`VipLevel`  varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL ,
`VipDiscount`  double(4,3) NULL DEFAULT NULL ,
PRIMARY KEY (`VipLevel`)
)
ENGINE=InnoDB
DEFAULT CHARACTER SET=utf8 COLLATE=utf8_general_ci
ROW_FORMAT=DYNAMIC
;



INSERT INTO `viplevel` VALUES ('白银', 0.880);
INSERT INTO `viplevel` VALUES ('钻石', 0.660);
INSERT INTO `viplevel` VALUES ('青铜', 0.950);
INSERT INTO `viplevel` VALUES ('黄金', 0.770);
