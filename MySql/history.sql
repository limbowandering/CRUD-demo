CREATE TABLE `NewTable` (
`goodsID`  varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL ,
`goodsName`  varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL ,
`goodsAmount`  decimal(10,0) NULL DEFAULT NULL ,
`VipId`  varchar(10) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL ,
`Date`  date NULL DEFAULT NULL 
)
ENGINE=InnoDB
DEFAULT CHARACTER SET=utf8 COLLATE=utf8_general_ci
ROW_FORMAT=DYNAMIC
;

