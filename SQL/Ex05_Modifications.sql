.mode columns
.headers on
.echo on

-- 5.1: Insert

-- Add records to the Substrates table for the following types of breads:
-- Sourdough
-- Focaccia
-- Water Crackers
-- Rye Bread
-- Multigrain Seeded Crackers
-- Naan
-- Chapati
insert into Substrates (BreadType) values 
    ('Sourdough'), ('Focaccia'), ('Water Crackers'), 
    ('Rye Bread'), ('Multigrain Seeded Crackers'), 
    ('Naan'), ('Chipati');

-- Add records to the Toppings table for the following types of spreads:
-- Marmalade
-- Almond Butter
-- Hummus
-- Cream Cheese
-- Lemon Curd
-- Basil Pesto
-- Apple Butter
insert into Toppings (ToppingType) values 
    ('Marmalade'), ('Almond Butter'), ('Hummus'),
    ('Cream Cheese'), ('Lemon Curd'), ('Basil Pesto'), ('Apple Butter');

-- List all of the records in both tables.
select * from Substrates;
select * from Toppings;



-- 2. Update
-- To the Substrates table add a column Country which is text, not null and default is an empty string.  
-- Remember from earlier:
-- alter table table_name add column new_column_name column_definition;
alter table Substrates add column Country text not null default '';

-- Update the records of Substrates to change the new Country value to the country of origin for each bread type:
-- Slice of Whole Wheat Bread: Mesopotamia
-- Slice of Italian Bread: Italy
-- Tortilla: Mexico
-- Sourdough: Egypt
-- Focaccia: Italy
-- Water Crackers: England
-- Rye Bread: Germany
-- Multigrain Seeded Crackers: United States
-- Naan: India
-- Chapati: India
update Substrates set Country = 'Mesopotamia' where BreadType = 'Slice of Whole Wheat Bread';
update Substrates set Country = 'Italy' where BreadType = 'Slice of Italian Bread';
update Substrates set Country = 'Mexico' where BreadType = 'Tortilla';
update Substrates set Country = 'Egypt' where BreadType = 'Sourdough';
update Substrates set Country = 'Italy' where BreadType = 'Focaccia';
update Substrates set Country = 'England' where BreadType = 'Water Crackers';
update Substrates set Country = 'Germany' where BreadType = 'Rye Bread';
update Substrates set Country = 'United States' where BreadType = 'Multigrain Seeded Crackers';
update Substrates set Country = 'India' where BreadType = 'Naan';
update Substrates set Country = 'India' where BreadType = 'Chipati';


-- List the new records of the Substrates table.
select * from Substrates;


-- 3. Update
-- To the Toppings table add a column Country which is text, not null and the default is an empty string.
alter table Toppings add column Country text not null default '';

-- Update the records of Toppings to change the new Country value to the country of origin for each topping type:
-- Strawberry Jam: France
-- Peanut Butter: Canada
-- Marmite: England
-- Honey: Egypt
-- Marmalade: Portugal
-- Almond Butter: Middle East
-- Hummus: Middle East
-- Cream Cheese: United States
-- Lemon Curd: England
-- Basil Pesto: Italy
-- Apple Butter: Belgium
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

-- List the new records of the Toppings table.
select * from Toppings;


-- 4. Delete
-- Delete the last 7 records from the Substrates table (the ones just added above).
delete from Substrates where id > 3;

-- Delete the last 7 records from the Toppings table (the ones just added above).
delete from Toppings where id > 4;

-- From both tables, remove the Country column.  The syntax is
-- alter table table_name drop column column_name;
alter table Substrates drop column Country;
alter table Toppings drop column Country;

-- List the records of both tables.
select * from Substrates;
select * from Toppings;
