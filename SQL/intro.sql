create table users (
    id integer primary key,
    name text not null,
    username text not null unique,
    email text,
    age integer,
    created_at datetime default current_timestamp
);
insert into users (name, username) values ('Mickey Mouse', 'mm123');
insert into users (name, username) values
('John Smith', 'js'), ('Sal Smith', 'ss'), ('Cabbage Smith', 'cs');
select * from users;