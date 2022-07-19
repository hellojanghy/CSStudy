#날짜: 2022/07/19
#이름: 장혜영
#내용: SQL 확인문제

#실습 4-1
CREATE TABLE `tblmemeber`(
`memberID`   VARCHAR(10) PRIMARY KEY NOT NULL, 
`memberName` VARCHAR(10) NOT NULL,
`memberHp`   VARCHAR(13) UNIQUE  ,
`memberAge`  INT,
`memberAddr` VARCHAR(20)
);

CREATE TABLE `tblproduct`(
`productCode`   INT PRIMARY KEY AUTO_INCREMENT, 
`producName` VARCHAR(10) NOT NULL,
`price`   INT NOT NULL ,
`amount`  INT NOT NULL DEFAULT 0,
`company` VARCHAR(10),
`makeDate` DATETIME
);


#실습 4-2
INSERT INTO `tblmemeber` VALUES ('p101','김유신','010-1234-1001',25,'신라');
INSERT INTO `tblmemeber` VALUES ('p102','김춘추','010-1234-1002',23,'신라');
INSERT INTO `tblmemeber` SET `memberID`='p103',`memberName`='장보고', `memberAge`=31,`memberAddr`='통일신라';
INSERT INTO `tblmemeber` SET `memberID`='p104',`memberName`='강감찬',`memberAddr`='고려';
INSERT INTO `tblmemeber` SET `memberID`='p105',`memberName`='이순신', `memberHp`='010-1234-1005',`memberAge` = 50;


INSERT INTO `tblproduct` (`producName`,`price`,`amount`,`company`,`makeDate`) VALUES ('냉장고',800,10,'LG','2022-01-06');
INSERT INTO `tblproduct` (`producName`,`price`,`amount`,`company`,`makeDate`) VALUES ('노트북',1200,20,'삼성','2022-01-06');
INSERT INTO `tblproduct` (`producName`,`price`,`amount`,`company`,`makeDate`) VALUES ('TV',1400,6,'LG','2022-01-06');
INSERT INTO `tblproduct` (`producName`,`price`,`amount`,`company`,`makeDate`) VALUES ('세탁기',1000,8,'LG','2022-01-06');
INSERT INTO `tblproduct` (`producName`,`price`,`amount`) VALUES ('컴퓨터',1100,0);
INSERT INTO `tblproduct` (`producName`,`price`,`amount`,`company`,`makeDate`) VALUES ('휴대폰',900,102,'삼성','2022-01-06');


#실습 4-3
SELECT `memberName` FROM `tblmemeber`;
SELECT `memberName`,`memberHp` FROM `tblmemeber`;
SELECT * FROM `tblmemeber` WHERE `memberID`='p102';
SELECT * FROM `tblmemeber` WHERE `memberID`='p104' OR `memberID`='p105';
SELECT * FROM `tblmemeber` WHERE `memberAddr`='신라';
SELECT * FROM `tblmemeber` WHERE `memberAge`> 30;
SELECT * FROM `tblmemeber` WHERE `memberHp` IS NULL ;
UPDATE `tblmemeber` SET `memberAge` = 42 WHERE `memberID`= 'p104';
UPDATE `tblmemeber` SET `memberAddr`='조선' WHERE `memberID`= 'p105';
DELETE FROM  `tblmemeber` WHERE `memberID`='p103';
SELECT * FROM `tblmemeber`;

SELECT `producName` FROM `tblproduct`;
SELECT `producName`,`price` FROM `tblproduct`;
SELECT * FROM `tblproduct` WHERE `company` ='삼성';
UPDATE `tblproduct` SET 
                          `company` ='삼성',
                          `makeDate`='2021-01-01'
                          WHERE 
                        	`productCode`=5;
SELECT * FROM `tblproduct`;


