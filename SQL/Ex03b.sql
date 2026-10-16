-- These are answers to SQL Exercise set 03b

.mode columns
.headers on 
.echo on 

-----------------------------------------------------------------------------------------------
-- Calculations
-- Our present altitude is 709 feet above sea level.
-- Our latitude is 42.21545 degrees
-- Our longitude is -86.05048 degrees
select (709 - (select Altitude from CountySeats where County = 'Van Buren' limit 1));    -- 1a: Use the select command to calculate the difference between our altitude and the altitude of the Van Buren county seat.

select ((select Altitude from CountySeats order by Altitude desc limit 1)    -- 1b: Use the select command to calculate the maximum difference in altitudes between the county seats in Michigan.
    - (select Altitude from CountySeats order by Altitude limit 1));

select avg(Altitude) from CountySeats;    -- 1c: Use the avg() aggregator to calculate the average altitude of all Michigan county seats.

select (709 - (select avg(Altitude) from CountySeats where Peninsula = 'L'));    -- 1d: Calculate the difference between our altitude and the average of lower peninsula county seats.

-----------------------------------------------------------------------------------------------
-- Filtering and Calculating

select * from CountySeats where Latitude >= (42.21545 - 0.25) and Latitude <= (42.21545 + 0.25) order by Longitude;    -- 2a: Get the records of all counties whose county seats have a latitude within +/- 0.25 degree of our latitude.  List the results from west to east.

select * from CountySeats where Longitude >= (-86.05048 - 0.25) and Longitude <= (-86.05048 + 0.25) order by Latitude;    -- 2b: Get the records of all counties whose county seats have a longitude within +/- 0.25 degree of our longitude.  List the results from south to north.

select * from CountySeats where Altitude >= (709 - 20) and Altitude <= (709 + 20);    -- 2c: Get the records of all counties whose county seats have an altitude within +/- 20 feet of our altitude.

-----------------------------------------------------------------------------------------------
-- Calculating, Ordering and Limiting

select * from CountySeats order by (abs(Altitude - 709)) limit 1;   -- 3a: Use the abs() function to get the record for the county having its county seat closest to our altitude.

select * from CountySeats order by (abs(Altitude - 709)) desc limit 1;    -- 3b: Use the abs() function to get the record for the county having its county seat farthest from our altitude.


-----------------------------------------------------------------------------------------------
-- Calculating, Filtering, Ordering and Limiting

select ((select Longitude from CountySeats where Peninsula = 'U' order by Longitude desc limit 1) -     -- 4a: Calculate the angular range in longitude subtended by the county seats in the upper peninsula.
    (select Longitude from CountySeats where Peninsula = 'U' order by Longitude limit 1));

select avg(Latitude) from CountySeats where Peninsula = 'U';    -- 4b: Calculate the mean latitude of the county seats in the upper peninsula.

select avg(Longitude) from CountySeats where Peninsula = 'L';    -- 4c: Calculate the angular range in longitude subtended by the county seats in the lower peninsula.

select avg(Latitude) from CountySeats where Peninsula = 'L';    -- 4d: Calculate the mean latitude of the county seats in the lower peninsula.

select ((select Longitude from CountySeats where Peninsula = 'U' order by Longitude desc limit 1)    -- 4e: Estimate the west to east width of the upper peninsula as determined by the span of the county seats.
    - (select Longitude from CountySeats where Peninsula = 'U' order by Longitude limit 1));

select ((select Longitude from CountySeats where Peninsula = 'L' order by Longitude desc limit 1)    -- 4f: Estimate the west to east width of the lower peninsula as determined by the span of the county seats.
    - (select Longitude from CountySeats where Peninsula = 'L' order by Longitude limit 1));
