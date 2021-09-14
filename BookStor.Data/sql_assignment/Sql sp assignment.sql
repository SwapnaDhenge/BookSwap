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

create proc spEm1
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
exec spEm1 'swapnali','elec',1,25,'mumbai',30 
exec spEm1 'swapna','elec1',3,35,'mumbai1',20 
exec spEm1 'Dnyanaa','elec1',3,35,'Pune',20 
exec spEm1 

select *from Emp,Location3 where Emp.emp_id=Location3.id;
select *from Emp where emp_id=5;


alter procedure Spfetchdata1 
(
@id int
)
as
begin
 if(isnull(@id,'') !='')
 begin
 select E.emp_id,E.name,E.location,E.experience,E.age,E1.location_name,E1.office_size,E1.location_id
from Emp E join Location3 E1
on E.emp_id=E1.location_id
and E.emp_id=@id
end
else 
begin
select E.emp_id,E.name,E.location,E.experience,E.age,E1.location_name,E1.office_size,E1.location_id
from Emp E join Location3 E1
on E.emp_id=E1.location_id
end
end 
exec Spfetchdata1 null







