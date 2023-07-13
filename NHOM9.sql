create database planning
use planning

create table users(
	user_code char(5) primary key not null,
	full_name nvarchar(30),
	permission varchar(15),
	production_line varchar(10),
	updated_by varchar(10),
	updated_date datetime
)
create table account(
	username varchar(20) primary key not null,
	pass int,
	user_code char(5),
	CONSTRAINT fk_usercode FOREIGN KEY (user_code) REFERENCES users(user_code)
)
create table master_data(
	item char(8) primary key not null,
	machine varchar(10),
	process_code varchar(20),
	width int,
	height int,
	scrap int,
	updated_by varchar(10),
	updated_date datetime
)
create table master_process(
	process_code varchar(10) primary key not null,
	process_name nvarchar(20),
	process_status int
)
insert into users values ('ST007','Cao Don Phuong','1','htl','an.tran','');
insert into users values ('ST002','Ly Gia Bao','1','thermal','an.tran','');
insert into users values ('ST004','Nguyen Huu','1','thermal','tan.doan','');
insert into users values ('ST005','Nguyen Tran Hoang Cong Danh','standar','htl','an.vu','');
insert into users values ('ST003','Tran Gia Bao','admin','thermal','tan.doan','');
insert into users values ('AD001','Tran Thuan An','super','htl','an.vu','');
select * from users

insert into account values ('an.toan',123456,'AD001');
insert into account values ('truong.hoang',123456,'ST007');
insert into account values ('anh.vu',123456,'ST004');
insert into account values ('binh.nguyen',123456,'ST002');
insert into account values ('khanh.dang',123456,'ST003');
insert into account values ('tan.doan',123456,'ST005');
select * from account

insert into master_data values ('AT106331','ATMA','INK-ADM-AG-BACKER',330,480,15,'tan.doan','');
insert into master_data values ('AT108292','AWT','INK-ADM-AG',550,700,17,'tan.doan','');
insert into master_data values ('AT108299','ATMA','INK-AG-BACKER',450,600,12,'tan.doan','');
insert into master_data values ('AT488405','SAKURAI','INK-ADM-AG-BACKER',330,480,15,'tan.doan','');
insert into master_data values ('AT488760','AWT','INK-CLEAR-BACKER-AG',550,700,17,'tan.doan','');
select * from master_data

insert into master_process values ('ADM','Keo ADM',1);
insert into master_process values ('AG','Lop lot AG',1);
insert into master_process values ('BACKER','Muc sau Backer',1);
insert into master_process values ('CLEAR','Lop Clear',1);
insert into master_process values ('INK','Muc truoc',1);
select * from master_process



