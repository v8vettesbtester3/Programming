-- Ex 02 SQL

-- -- Create a table for recipe ingredients, including a primary key.
-- create table recipeIngredients (
--     index1 integer primary key,
--     amount real not null default 0,
--     unit text not null,
--     ingredient text not null
-- );

-- -- Insert records to make the recipe for oatmeal.
-- insert into recipeIngredients (amount, unit, ingredient) values
-- (1,'Cup','Rolled Oats'), (2,'Cup','Water'), (0.25,'Cup','Raisins'),(0.05,'Tsp','Salt');

-- -- Change the name of the table.
-- alter table recipeIngredients rename to breakfastIngredients;

-- -- Add a column named ‘dish’ with the constraint that it be not null 
-- -- and by default be an empty string.
-- alter table breakfastIngredients add column dish text not null default '';
-- update breakfastIngredients set dish = 'Oatmeal' where dish = '';

-- -- Add more records to make the recipe for chocolate milk.
-- insert into breakfastIngredients (amount, unit, ingredient, dish) values
-- (1,'Cup','Milk','Chocolate Milk'),(2,'Tbsp','Chocolate Syrup','Chocolate Milk');

-- Query the table for the oatmeal recipe recordset.
select * from breakfastIngredients where dish = 'Oatmeal';

-- Query the table for the chocolate milk recordset.
select * from breakfastIngredients where dish = 'Chocolate Milk';
