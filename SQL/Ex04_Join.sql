.echo on

-- 1. Joining simple tables
.open SmallTables.db
.mode columns
.headers on
select * from Substrates;
select * from Toppings;
select * from Substrates cross join Toppings;
select * from Substrates inner join Toppings on Substrates.id = Toppings.id;
select * from Substrates left outer join Toppings on Substrates.id = Toppings.id;
select * from Toppings left outer join Substrates on Substrates.id = Toppings.id;

-- 2. Inner joins
.open CountySeats.db
select * from CountySeats;
select * from Rivers;
select * from Highways;
select c.County, r.River from CountySeats as c inner join Rivers as r on c.CountySeat = r.CountySeat;
select c.County, r.River, c.Altitude from CountySeats as c inner join Rivers as r on c.CountySeat = r.CountySeat;

-- 3. Inner joins
select r.River, count(*) from CountySeats as c inner join Rivers as r on c.CountySeat = r.CountySeat group by r.River order by count(*);
select c.CountySeat, r.River, c.Altitude from CountySeats as c inner join Rivers as r on c.CountySeat = r.CountySeat where River = 'Grand River' order by Altitude desc;
select c.CountySeat, c.Longitude, c.Latitude, c.Altitude from CountySeats as c inner join Rivers as r on c.CountySeat = r.CountySeat where River = 'Grand River' order by Altitude desc;

-- 4. Inner joins
select count(*), Highway from Highways group by Highway order by count(*);
select h.Highway, h.CountySeat, c.County from Highways as h inner join CountySeats as c on h.CountySeat = c.CountySeat where h.Highway = 'I-94' order by c.Longitude;
select h.Highway, h.CountySeat, c.County from Highways as h inner join CountySeats as c on h.CountySeat = c.CountySeat where h.Highway = 'I-75' order by c.Latitude;
select h.Highway, h.CountySeat, c.County from Highways as h inner join CountySeats as c on h.CountySeat = c.CountySeat where h.Highway = 'I-69' order by c.Longitude;

-- 5(1). Insert
.open SmallTables.db
insert into Substrates (BreadType) values ('Sourdough');
insert into Substrates (BreadType) values ('Focaccia');
insert into Substrates (BreadType) values ('Water Crackers');
insert into Substrates (BreadType) values ('Rye Bread');
insert into Substrates (BreadType) values ('Multigrain Seeded Crackers');
insert into Substrates (BreadType) values ('Naan');
insert into Substrates (BreadType) values ('Chapati');
insert into Toppings (ToppingType) values ('Marmalade');
insert into Toppings (ToppingType) values ('Almond Butter');
insert into Toppings (ToppingType) values ('Hummus');
insert into Toppings (ToppingType) values ('Cream Cheese');
insert into Toppings (ToppingType) values ('Lemon Curd');
insert into Toppings (ToppingType) values ('Basil Pesto');
insert into Toppings (ToppingType) values ('Apple Butter');
select * from Substrates;
select * from Toppings;

-- 6 (2). Update
alter table Substrates add column Country text not null default '';
update Substrates set Country = 'Mesopotamia' where BreadType = 'Slice of Whole Wheat Bread';
update Substrates set Country = 'Italy' where BreadType = 'Slice of Italian Bread';
update Substrates set Country = 'Mexico' where BreadType = 'Tortilla';
update Substrates set Country = 'Egypt' where BreadType = 'Sourdough';
update Substrates set Country = 'Italy' where BreadType = 'Focaccia';
update Substrates set Country = 'England' where BreadType = 'Water Crackers';
update Substrates set Country = 'Germany' where BreadType = 'Rye Bread';
update Substrates set Country = 'United States' where BreadType = 'Multigrain Seeded Crackers';
update Substrates set Country = 'India' where BreadType = 'Naan';
update Substrates set Country = 'India' where BreadType = 'Chapati';
select * from Substrates;

-- 7(3). Update : resume here in AM, and PM on Thursday
alter table Toppings add column Country text not null default '';
update Toppings set Country = 'France' where ToppingType = 'Strawberry Jam';
update Toppings set Country = 'Canada' where ToppingType = 'Peanut Butter';
update Toppings set Country = 'England' where ToppingType = 'Marmite';
update Toppings set Country = 'Egypt' where ToppingType = 'Honey';
update Toppings set Country = 'Portugal' where ToppingType = 'Marmalade';
update Toppings set Country = 'Middle East' where ToppingType = 'Almond Butter';
update Toppings set Country = 'Middle East' where ToppingType = 'Hummus';
update Toppings set Country = 'United States' where ToppingType = 'Cream Cheese';
update Toppings set Country = 'England' where ToppingType = 'Lemon Curd';
update Toppings set Country = 'Italy' where ToppingType = 'Basil Pesto';
update Toppings set Country = 'Belgium' where ToppingType = 'Apple Butter';
select * from Toppings;

-- 8(4). Delete
delete from Substrates where id > 3;
delete from Toppings where id > 4;
alter table Substrates drop column Country;
alter table Toppings drop column Country;
select * from Substrates;
select * from Toppings;