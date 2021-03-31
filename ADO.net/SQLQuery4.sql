create table Customer(
customerid int,
customername varchar(20),
CONSTRAINT Customer_PRIMARY_KEY PRIMARY KEY (customerid));

insert into Customer values(12,'Vishal');
create table Order_Table(
orderid int,
price decimal(10,3),
cid int ,
CONSTRAINT EMP_FOREIGN_KEY FOREIGN KEY(cid) REFERENCES Customer(customerid)
);


insert into Customer values(101,'Rahul');
insert into Customer values(102,'Romy');

insert into Order_Table values(1,20,101);
insert into Order_Table values(2,40,101);
insert into Order_Table values(10,100,102);
insert into Order_Table values(20,200,102);

select COUNT(Order_Table.orderid),cid
from Order_Table
group by cid;

select AVG(Order_Table.price)
from Order_Table;

select Customer.customerid,Customer.customername
from Customer
where Customer.customerid in(

select Order_Table.cid
from Order_Table
);



select Customer.customerid,Customer.customername,Order_Table.orderid,Order_Table.price
from Order_Table
full Outer join Customer
on customerid=Order_Table.cid;