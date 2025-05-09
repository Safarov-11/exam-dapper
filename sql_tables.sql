create table parent
(
	id serial primary key,
	code varchar(12),
	fullName varchar(50),
	email varchar(50),
	phone varchar(50),
	createdAt date,
	updatedAt date
); 

create table student
(
	id serial primary key,
	code varchar(12),
	fullName varchar(50),
	gender int,
	dob date,
	email varchar(50),
	phone varchar(50),
	schoolId int,
	stage int,
	section varchar(2),
	isActive int,
	joinDate date,
	createdAt date,
	updatedAt date
); 

create table teacher
(
	id serial primary key,
	code varchar(12),
	fullName varchar(75),
	gender int,
	dob date,
	email varchar(50),
	phone varchar(50),
	isActive int,
	joinDate date,
	workingDays int,
	createdAt date,
	updatedAt date
); 

create table studentParent
(
	id serial primary key,
	parentId int references parent(id),
	studentId int references student(id),
	relationship int
); 

create table school
(
	id serial primary key,
	schoolTitle varchar(50),
	levelCount int,
	isActive int,
	createdAt date,
	updatedAt date
); 

create table subject
(
	id serial primary key,
	title varchar(50),
	schoolId int references school(id),
	stage int,
	term int,	
	carryMark int,
	createdAt date,
	updatedAt date
); 

create table classroom
(
	id serial primary key,
	capacity int,
	roomType int,
	description varchar(50),
	createdAt date,
	updatedAt date
); 

create table classStudent
(
	id serial primary key,
	classId int references class(id),
	studentId int references student(id)
	
); 


create table class
(
	id serial primary key,
	className varchar(50),
	subjectId int references subject(id),
	teacherId int references teacher(id),
	classroomId int references classroom(id),
	section varchar(2),
	createdAt date,
	updatedAt date
); 

select * from parent
select * from student
select * from studentparent
select * from school
select * from class
select * from classroom
select * from classstudent
select * from teacher
select * from subject














