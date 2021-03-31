select * from EMP;

select * from DEPT;
insert into DEPT values(90,'Geo_Graphy','MUMBAI');

go
CREATE PROC EMP_Salary
AS
select EMP.SAL from EMP 
go

EXEC EMP_Salary


go
create function dbo.TaxAmmountNEW(@SAL decimal(10,3)) returns decimal(10,5) as
begin
declare @work decimal(10,5)

set @work=@SAL*0.1
return @work
end;
go


select EMP.SAL,dbo.TaxAmmountNEW(EMP.SAL)
from EMP;


CREATE TRIGGER [dbo].[SALARYINCREMENT] on [dbo].[EMP]
 after insert 
 AS
BEGIN
declare @SAL decimal(10,3)
Update EMP
set SAL=SAL+1000; 
END
Go

select * from EMP;

insert into EMP Values(7714,'java','CLERK',7902,'17-Nov-21',800,100,10);