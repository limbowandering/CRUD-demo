CREATE TABLE `NewTable` (
`VipId`  varchar(10) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL ,
`VipMobile`  varchar(11) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL ,
`VipName`  varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL ,
`VipLevel`  varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL ,
`VipDiscount`  double(4,3) NULL DEFAULT NULL ,
`VipSignUpDate`  date NULL DEFAULT NULL ,
`VipBalance`  varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL ,
PRIMARY KEY (`VipId`)
)
ENGINE=InnoDB
DEFAULT CHARACTER SET=utf8 COLLATE=utf8_general_ci
ROW_FORMAT=DYNAMIC
;



INSERT INTO `vip` VALUES ('1527406002', '15262485201', '张灿', '钻石', 0.660, '2018-3-17', '666');
