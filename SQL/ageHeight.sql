-- create table ageHeight (
--     id integer primary key autoincrement,
--     name text not null,
--     height real not null,   -- centimeters
--     birthYear integer not null, -- 4 digits
--     birthMonth integer not null -- 1-12
--     );

-- insert into ageHeight (name, height, birthYear, birthMonth) values 
--     ('Micah', 1.5, 2010, 1),
--     ('Jordan', 1.3, 2010, 2),
--     ('Dylan', 1.4, 2011, 3),
--     ('Lynn',1.6, 2010, 4);
-- insert into ageHeight (name, height, birthYear, birthMonth) values 
--     ('H', 1.5, 1960, 4);
-- insert into ageHeight (name, height, birthYear, birthMonth) values 
--     ('P', 1.5, 1958, 6);
-- insert into ageHeight (name, height, birthYear, birthMonth) values 
--     ('S', 1.5, 1992, 5),
--     ('C', 1.5, 1994, 2);


-- SELECT strftime('%Y', 'now') AS CurrentYear;
-- SELECT strftime('%m', 'now') AS CurrentMonth;

select name, sub.age
from
(select name, (
    (SELECT strftime('%m', 'now') AS CurrentMonth) 
    + ((SELECT strftime('%Y', 'now') AS CurrentYear) - birthYear)*12 
    - birthMonth)  
    as age, height from ageHeight) as sub order by sub.age;

-- select name, A.age, A.speed
-- from
-- (select name, sub.age, (sub.age / sub.height) as speed
-- from 
--     (select name, (10 + (2026 - birthYear)*12 - birthMonth)  as age, height from ageHeight) as sub) as A
--     order by A.speed;

