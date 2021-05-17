--Crear base de datos Videoteca.
create database Videolibrary;

--Usar base de datos Videoteca.
use Videolibrary;

--Crear tabla
create table Movies(
id int not null identity(1,1),
title varchar(50),
director varchar(50),
genre varchar(50),
release_date int,
rating varchar(10),
constraint pk_im primary key (id)
);

select * from Movies;

insert into Movies values ('Interstellar','Christopher Nolan','Science Fiction',2014,'PG-13');
insert into Movies values ('Tenet','Christopher Nolan','Science Fiction',2020,'PG-13');
insert into Movies values ('Ready Player One','Steven Spielberg','Science Fiction',2018,'PG-13');
insert into Movies values ('Back to the Future','Robert Zemeckis','Science Fiction',1985,'PG');
insert into Movies values ('Back to the Future','Robert Zemeckis','Science Fiction',1985,'PG');
insert into Movies values ('Cindy la Regia','Catalina Aguilar Mastretta','Comedy',2020,'B15');
insert into Movies values ('Parasite','Bong Joon-ho','Drama',2019,'16+');
insert into Movies values ('Joker','Todd Phillips','Drama',2019,'B15');
insert into Movies values ('Gremlins','Joe Dante','Horror',1984,'B');
insert into Movies values ('Ratatouille','Brad Bird','Animation',2007,'A');
insert into Movies values ('Venom','Ruben Fleischer','Action',2018,'PG-13');
insert into Movies values ('Avatar','James Cameron','Science Fiction',2009,'B');
