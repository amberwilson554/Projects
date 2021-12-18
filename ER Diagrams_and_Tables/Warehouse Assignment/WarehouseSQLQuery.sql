--step 1
create database WarehouseDB
use WarehouseDB;

--step 2
create table Warehouses
(
warehouseId int IDENTITY(1,1) PRIMARY KEY, 
place Varchar(100) not null,
capicty int
);

create table Boxes
(
refNumber Char(5) PRIMARY KEY,
content Varchar(100),
value int,
warehouseID int FOREIGN KEY REFERENCES Warehouses(warehouseID)
);

--step 3
alter table Warehouses
add city varchar(80);

--step 4
drop table Boxes

--step 5

create table Boxes
(
refNumber Char(5) PRIMARY KEY,
content Varchar(100),
value int,
warehouseID int FOREIGN KEY REFERENCES Warehouses(warehouseID)
);

--step 6
insert into Warehouses 
(place, capicty, city) values ('Pennsylvania', 100, 'Uniontown');

select * from Warehouses;

insert into Warehouses 
(place, capicty, city) values ('Ohio', 150, 'Cleveland');

select * from Warehouses;

insert into Warehouses 
(place, capicty, city) values ('New York', 20, 'New York');

select * from Warehouses;

insert into Warehouses 
(place, capicty, city) values ('Texas', 200, 'Austin');

select * from Warehouses;

insert into Warehouses 
(place, capicty, city) values ('Georgia', 300, 'Atlanta');

select * from Warehouses;

insert into Warehouses 
(place, capicty, city) values ('Maryland', 20, 'Frederick');

select * from Warehouses;

--step 7

insert into Boxes 
(refNumber, warehouseID) values (00001, 1);
insert into Boxes 
(refNumber, warehouseID) values (00002, 2);
insert into Boxes 
(refNumber, warehouseID) values (00003, 3);
insert into Boxes 
(refNumber, warehouseID) values (00004, 4);
insert into Boxes 
(refNumber, warehouseID) values (00005, 5);
insert into Boxes 
(refNumber, warehouseID) values (00006, 6);
insert into Boxes 
(refNumber, warehouseID) values (00007, 1);
insert into Boxes 
(refNumber, warehouseID) values (00008, 2);
insert into Boxes 
(refNumber, warehouseID) values (00009, 3);
insert into Boxes 
(refNumber, warehouseID) values (000010, 4);

update Boxes
set refNumber = 00010
Where  refNumber = 000010;

select * from Boxes;

--step 8
EXEC sp_rename 'warehouses', 'warehouse';

--step 9
select * from Warehouse;

--step 10
select refNumber, content, value from Boxes

--step 11
update Boxes
set value = 200;

--step 12

select * from Boxes;

--step 13
select content from Boxes;

insert into Warehouse 
(place, capicty, city) values ('Spain', 5, 'Barcelona');

--step 14
insert into Boxes 
(refNumber, content, value, warehouseID) values ('BCHS1', 'Paper', 3500, 3);

select * from Boxes;