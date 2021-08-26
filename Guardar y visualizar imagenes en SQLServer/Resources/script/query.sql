use master;
create database db_file_server;
use db_file_server;
drop table tbl_contents;
create table tbl_contents (
	id int identity,
	content varbinary(max),
	constraint pk_tbl_contents primary key(id)
);
select * from tbl_contents;