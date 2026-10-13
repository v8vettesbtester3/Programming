-- These are answers to SQL Exercise set 03a

-----------------------------------------------------------------------------------------------
-- Creating a database, counting records
select * from CountySeats;          -- 1d: Use the select command to view all the records of the table.

select count(*) from CountySeats;   -- 1e: Use the count(*) aggregator to get the total number of counties in Michigan.

-----------------------------------------------------------------------------------------------
-- Filtering
select * from CountySeats order by Latitude limit 1;                                -- 2a: Get the record for the southernmost county seat.

select * from CountySeats where Peninsula = 'U' order by Latitude limit 1;          -- 2b: Get the record for the southernmost county seat in the other peninsula.

select * from CountySeats order by Latitude desc limit 1;                           -- 2c: Get the record for the northernmost county seat.

select * from CountySeats where Peninsula = 'L' order by Latitude desc limit 1;     -- 2d: Get the record for the northernmost county seat in the other peninsula.

select * from CountySeats order by Longitude limit 1;                               -- 2e: Get the record for the westernmost county seat.

select * from CountySeats where Peninsula = 'L' order by Longitude limit 1;         -- 2f: Get the record for the westernmost county seat in the other peninsula.

select * from CountySeats order by Longitude desc limit 1;                          -- 2g: Get the record for the easternmost county seat.

select * from CountySeats where Peninsula = 'U' order by Longitude desc limit 1;    -- 2h: Get the record for the easternmost county seat in the other peninsula.

-----------------------------------------------------------------------------------------------
-- Pipelining
select * from CountySeats where County = 'Van Buren';        -- 3a: Get the row for Van Buren county.  What is the Latitude, Longitude and Altitude of the county seat?

select Altitude from CountySeats where County = 'Van Buren'; -- 3b: Get a result of just the Altitude of the Van Buren county seat.

select * from CountySeats           -- 3c: Get all the records for counties having county seats lower than that of Van Buren county.
    where Altitude < (select Altitude from CountySeats where County = 'Van Buren' limit 1);

select * from CountySeats           -- 3d: Get all the records for counties in the lower peninsula having county seats lower than that of Van Buren county.
    where Altitude < (select Altitude from CountySeats where County = 'Van Buren' limit 1) and Peninsula = 'L';

select count(*) from CountySeats    -- 3e: Get the count of the number of counties in the lower peninsula having county seats lower than that of Van Buren county.
   where Altitude < (select Altitude from CountySeats where County = 'Van Buren' limit 1) 
   and Peninsula = 'L';

select count(*) from CountySeats    -- 3f: Get the count of the number of counties in the upper peninsula having county seats lower than that of Van Buren county.
   where Altitude < (select Altitude from CountySeats where County = 'Van Buren' limit 1)
   and Peninsula = 'U';

-----------------------------------------------------------------------------------------------
-- Ordering
select * from CountySeats where Peninsula = 'U' order by Altitude;    -- 4a: Get all the records of upper peninsula county seats, ordered by ascending altitude.

select * from CountySeats order by Peninsula desc, Altitude;    -- 4b: Get all the records of all county seats, listing upper peninsula counties first, 
                                                                -- ordered by ascending altitude and then lower peninsula counties, also ordered by ascending altitude.

select * from CountySeats order by Latitude desc;               -- 4c: Get all records of county seats ordered from north to south.

select * from CountySeats order by Longitude;                   -- 4d: Get all records of county seats ordered from west to east.

-----------------------------------------------------------------------------------------------
-- Limiting
select * from CountySeats order by Longitude limit 1;                   -- 5a: Get the record for the westernmost county seat.
select * from CountySeats order by Latitude desc limit 1;               -- 5b: Get the record for the northernmost county seat.
select * from CountySeats order by Longitude desc limit 1;              -- 5c: Get the record for the easternmost county seat.
select * from CountySeats order by Latitude limit 1;                    -- 5d: Get the record for the southernmost county seat.
select * from CountySeats order by Longitude limit 1 offset 1;          -- 5e: Get the record for the next to the westernmost county seat.
select * from CountySeats order by Longitude limit 3;                   -- 5f: Get the records for the three westernmost county seats.
select * from (select * from CountySeats order by Longitude limit 3)    -- 5g: Get the records for the three westernmost county seats, listing them in ascending order of altitude.
    order by Altitude;