create database School
use School

create table Students
(StudentId int primary key,
FirstName nvarchar(25) not null,
LastName nvarchar(25) not null,
DateofBirth date,
Gender char(10)
)

create table Subjects(
SubjectCode int primary key,
SubjectName nvarchar(30)
)

create table Classes(
ClassID int primary key,
ClassName nvarchar(20),
TeacherName nvarchar(20),
SubjectCode int,
foreign key(SubjectCode) references Subjects(SubjectCode)
)

create index idx_LastName on Students (LastName)
create index idx_SubjectName on Subjects (SubjectName)
create index idx_ClassID on Classes (ClassID)

insert into Students (StudentID, FirstName, LastName, DateofBirth, Gender) values
(1, 'Viya', 'Gandhi', '2001-06-05', 'Female'),
(7, 'Ravi', 'Krishna', '2002-01-11', 'Male'),
(5, 'Somu', 'Saran', '2003-08-02', 'Male'),
(2, 'Janani', 'Sakthi', '2002-11-22', 'Female')

insert into Subjects (SubjectCode, SubjectName) values
(103,'English'),
(101, 'Mathematics'),
(102, 'Science'),
(105,'Tamil')

insert into Classes (ClassID, ClassName, TeacherName, SubjectCode) values
(1, 'Maths 109', 'Ms. Janani', 105),
(2, 'Science 201', 'Mr. Shiva', 102),
(8, 'Bio 101', 'Mr. Somu', 101),
(6, 'Social 205', 'Ms. Viya', 103)

select * from Students
select * from Subjects
select * from Classes






