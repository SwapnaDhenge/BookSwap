use master;
CREATE TABLE Emp(
emp_id int primary key identity,
name varchar(50),
location varchar(50),
experience int,
age int


create TABLE Location3(
id int primary key identity,
location_name varchar(40),
office_size int,
location_id int FOREIGN KEY REFERENCES Emp(emp_id))
drop table Location2;
select * from Emp;
select * from Location3;

create proc spEmp1
(
@name varchar(50),
@location varchar(50),
@experiance int,
@age int,

@location_name varchar(40),
@office_size int

)
as
begin
insert into Emp(name,location,experience,age)
values(@name,@location,@experiance ,@age)
declare @id int
select @id= SCOPE_IDENTITY()
insert into Location3(location_name,office_size,location_id)values(@location_name,@office_size,@id)
end 
exec spEmp1 'swapnali','elec',1,25,'mumbai',30 
exec spEmp1 'swapna','elec1',3,35,'mumbai1',20 
exec spEmp1 'Dnyanaa','elec1',3,35,'Pune',20 

select *from Emp,Location3 where Emp.emp_id=Location3.id;
select *from Emp where emp_id=5;