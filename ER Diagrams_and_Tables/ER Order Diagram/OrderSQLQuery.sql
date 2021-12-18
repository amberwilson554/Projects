create database OrderDatabase;
use OrderDatabase;

create table Customer
(
Customer# int IDENTITY(1,1) PRIMARY KEY, 
Number int not null,
Street varchar(20) not null,
City varchar(20) not null,
CreditLimit int,
Discount int,
Balance int not null
);

create table CustomerOrder
(
Order# int IDENTITY(1,1) PRIMARY KEY, 
OrderDate varchar(10) not null,
Number int not null,
Street varchar(20) not null,
City varchar(20) not null,
Quantity int,
Item# int FOREIGN KEY REFERENCES Item(Item#),  --need to specify from table and field
Customer# int
);


create table Item
(
Item# int IDENTITY(1,1) PRIMARY KEY, 
ItemName varchar(20) not null,
Factory# int FOREIGN KEY REFERENCES Factory(Factory#)
);

create table Factory
(
Factory# int IDENTITY(1,1) PRIMARY KEY,
FactoryName varchar(30) not null,
ContactInfo varchar(14) not null,
Stock int 
);

alter table CustomerOrder
ADD FOREIGN KEY (Customer#)
REFERENCES Customer(Customer#);

