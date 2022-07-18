#날짜 : 2022/07/18
#이름 : 장혜영
#내용 : 교재 2장 테이블에서 데이터 검색

#------------------------------
#4강 Hello World 실행하기
#------------------------------
# 테이블 생성
CREATE TABLE `sample21` (
	`no`	     INT,
	`name`     VARCHAR(10),		
	`birthday` CHAR(10),	
	`address`  VARCHAR(100)
);


# 데이터 저장
INSERT INTO `sample21` (`no`,`name`,`birthday`,`address`) VALUES ('1','박준용','1976-10-18','대구광역시 수성구');
INSERT INTO `sample21` (`no`,`name`,`address`) VALUES ('2','김재진','대구광역시 동구');
INSERT INTO `sample21` (`no`,`name`,`address`) VALUES ('3','홍길동','서울특별시 마포구');

#p53
SELECT * FROM sample21;


#------------------------------
#5강 테이블 구조 참조하기
#------------------------------

#p62
mysql>DESC sample21;
#------------------------------
#6강 검색조건 지정하기
#------------------------------
#p66
SELECT NO,NAME FROM sample21;

#p68
SELECT * FROM sample21;
SELECT * FROM sample21 WHERE NO = 2;

#p70
SELECT * FROM sample21 WHERE NO <> 2;

#p71
SELECT * FROM sample21 WHERE NAME = '박준용';

#p72
SELECT * FROM sample21 WHERE birthday = NULL;

#p73
SELECT * FROM sample21 WHERE birthday is NULL;
#------------------------------
#7강 조건 조합하기
#------------------------------
# 테이블 생성/데이터 저장
CREATE TABLE `sample24` (
	`no` INT,
	`a` INT,
	`b` INT,
	`c` INT 
);
DROP TABLE `sample24`;

INSERT INTO `sample24` (`no`,`a`,`b`,`c`) VALUES ('1','1','0','0');
INSERT INTO `sample24` (`no`,`a`,`b`,`c`) VALUES ('2','0','1','0');
INSERT INTO `sample24` (`no`,`a`,`b`,`c`)	VALUES ('3','0','0','1');
INSERT INTO `sample24` (`no`,`a`,`b`,`c`)	VALUES ('4','2','2','0');
INSERT INTO `sample24` (`no`,`a`,`b`,`c`)	VALUES ('5','0','2','2');

#p76
SELECT * FROM sample24; 

#p77
SELECT * FROM sample24 WHERE a<>0 AND b<>0; 

#p78
SELECT * FROM sample24 WHERE a<>0 OR b <>0; 

#p80
SELECT * FROM sample24 WHERE a=1 OR a=2 AND b=1 OR b=2; 

#p82
SELECT * FROM sample24 WHERE NOT (a<>0 OR b <>0); 

#------------------------------
#8강 패턴 매칭에 의한 검색
#------------------------------
# 테이블 생성/데이터 저장
CREATE TABLE `sample25` (
	`no` INT,
	`text` VARCHAR(255)
);
DROP TABLE `sample25`;
INSERT INTO `sample25` SET `no`= 1, `text` = 'SQL은 RDBMS를 조작하는 언어이다';
INSERT INTO `sample25` SET `no`= 2, `text` = 'LIKE에서는 메타문자 %와 _를 사용할 수 있다';
INSERT INTO `sample25` SET `no`= 3, `text` = 'LIKE는 SQL에서 사용할 수 있는 술어 중 하나이다';

SELECT * FROM sample25; 

#p85
SELECT * FROM sample25 WHERE TEXT LIKE 'SQL%';

#p86
SELECT * FROM sample25 WHERE TEXT LIKE '%SQL%';

#p88
SELECT * FROM sample25 WHERE TEXT LIKE '%\%%';
