create table Substrates (id integer primary key, BreadType text not null);
create table Toppings (id integer primary key, ToppingType next not null);
insert into Substrates (BreadType) values ('Slice of Whole Wheat Bread');
insert into Substrates (BreadType) values ('Slice of Italian Bread');
insert into Substrates (BreadType) values ('Tortilla');
insert into Toppings (ToppingType) values ('Strawberry Jam');
insert into Toppings (ToppingType) values ('Peanut Butter');
insert into Toppings (ToppingType) values ('Marmite');
insert into Toppings (ToppingType) values ('Honey');