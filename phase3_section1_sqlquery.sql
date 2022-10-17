create database SchoolDB
USE SchoolDB


create table Student
(
StudentId int primary key,
StudentName varchar(30),
Address varchar(100),
)

select * from Student

create table Class
(
Classid int primary key,
ClassName varchar(5)
)

create table subject
(
SubjectId int primary key,
SubjectName varchar(50),
classId int foreign key references Class(classid)
)

select * from subject
Select * from Class
Select*  from Student

alter table Student
add Classid int foreign key references Class(classid)


insert into Class values(1,'12 A')
insert into Class values(2,'12 B')
insert into Class values(3,'12 C')
insert into Class values(4,'12 D')
insert into Class values(5,'12 E')


insert into Student values(1,'Vignesh','ram nagar, Thanjavur',2)
insert into Student values(2,'Varsha','cit colony,Chennai',2),
(3,'Vidhya','greems,Coimbatore',1),
(4,'Pavithra','Ashok Nagar,Chennai',1),
(5,'Annanya','Post road, Coimbatore',3),
(6,'Nivetha','RajuStreet,Thirunelveli',3),
(7,'Raji','Dindugal',4),
(8,'Prithvi','Azeez Nagar,Chennai',4),
(9,'Sagar','Besant Nagar',5),
(10,'Gowtham','Rich Street,Vellore',5)


select * from Student

insert into subject values(1,'Physics',1),
(2,'Biology',1),(3,'Chemistry',2),
(4,'Maths',2),(5,'Economics',3),
(6,'Commerce',3),(7,'Biology',4),
(8,'Sanskrit',4),(9,'English',5),(10,'Computer Science',5)
 

 select * from Subject

