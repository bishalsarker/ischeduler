create database ishedulerdb;

create table users(
	user_id int IDENTITY(1,1) primary key,
	username varchar(max) not null,
	fullname varchar(max) not null,
	email varchar(max) not null,
	password varchar(max) not null
);	

create table schedules(
	schedule_id int IDENTITY(1,1) primary key,
	schedule_title varchar(max) not null,
	date varchar(50) not null,
	month varchar(50) not null,
	year varchar(50) not null,
	hh varchar(50) not null,
	mm varchar(50) not null,
	tt varchar(50) not null,
	location varchar(max) not null,
	priority int not null,
	repeat int not  null,
	user_id int foreign key references users(user_id)
);

create table notes(
	note_id int IDENTITY(1,1) primary key,
	note_title varchar(max) not null,
	note varchar(max) not null,
	schedule_id int foreign key references schedules(schedule_id)
);