CREATE TABLE `NewTable` (
`staffName`  varchar(255) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL ,
`staffPassword`  varchar(255) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL ,
`staffSalary`  decimal(10,2) NULL DEFAULT NULL ,
PRIMARY KEY (`staffName`)
)
ENGINE=InnoDB
DEFAULT CHARACTER SET=latin1 COLLATE=latin1_swedish_ci
ROW_FORMAT=DYNAMIC
;



INSERT INTO `staff` VALUES ('boss', 'bossboss', NULL);
INSERT INTO `staff` VALUES ('test', '123456', 2000.00);
INSERT INTO `staff` VALUES ('zc', '123456', 3000.00);
