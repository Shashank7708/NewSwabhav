create trigger AddInDEPT
after insert on DEPT
for each row
begin
dbms_output.put_line('New Row Added');
end;
/


select * from DEPT;