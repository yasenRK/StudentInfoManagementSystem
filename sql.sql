

create DATABASE StudentrInfoDB;

use StudentInfoDb;


----用户表
create table Users(
id int auto_increment primary key not null,
userName varchar(30),
passwd varchar(30)
);

