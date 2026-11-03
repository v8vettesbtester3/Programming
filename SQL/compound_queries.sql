-- -- select the westernmost county seat and the easternmost countyseat
-- select c.* from CountySeats as c inner join
-- (select * from CountySeats order by Longitude limit 1) as w on c.County = w.County
-- union
-- select c.* from CountySeats as c inner join
-- (select * from CountySeats order by Longitude desc limit 1) as e on c.County = e.County
-- order by Longitude;

-- -- west, east, south, north limits of I-94
-- select k.* from CountySeats as k inner join 
-- (select c.* from CountySeats as c inner join Highways as h on c.CountySeat = h.CountySeat where h.Highway = 'I-94' order by Latitude limit 1) as L
-- on k.County = L.County
-- union all
-- select k.* from CountySeats as k inner join 
-- (select c.* from CountySeats as c inner join Highways as h on c.CountySeat = h.CountySeat where h.Highway = 'I-94' order by Latitude desc limit 1) as L
-- on k.County = L.County
-- union all
-- select k.* from CountySeats as k inner join 
-- (select c.* from CountySeats as c inner join Highways as h on c.CountySeat = h.CountySeat where h.Highway = 'I-94' order by Longitude limit 1) as L
-- on k.County = L.County
-- union all
-- select k.* from CountySeats as k inner join 
-- (select c.* from CountySeats as c inner join Highways as h on c.CountySeat = h.CountySeat where h.Highway = 'I-94' order by Longitude desc limit 1) as L
-- on k.County = L.County;

-- -- All county seats that have either or both I-94 and I-75
-- select * from Highways where Highway = 'I-94'
-- union
-- select * from Highways where Highway = 'I-75';

-- -- All county seats that have I-94 but not I-75
-- select CountySeat from Highways where Highway = 'I-94'
-- except
-- select CountySeat from Highways where Highway = 'I-75';

-- -- All county seats that have I-94 but not I-75, listed from west to east
-- select k.CountySeat from (select CountySeat from Highways where Highway = 'I-94'
-- except
-- select CountySeat from Highways where Highway = 'I-75') as k
-- inner join CountySeats as c on k.CountySeat = c.CountySeat order by c.Longitude;
