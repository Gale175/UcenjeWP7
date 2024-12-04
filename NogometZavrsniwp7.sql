﻿﻿use master;
go
drop database if exists nogomet_zavr;
go
create database nogomet_zavr;
go
use nogomet_zavr;
go

create table natjecanja(
sifra int not null primary key identity(1,1),
naziv varchar(80) not null,
vrsta varchar(50) not null,
sezona datetime not null,
mjesto_odigravanja varchar(80),
pobjednik int not null primary key identity(1,1),
najbolji_igrac int,
);

create table timovi(
sifra int not null primary key identity(1,1),
naziv varchar(80) not null,
klub_repka bit not null,
najtecanje int not null references natjecanja(sifra),
trener varchar(80),
stadion varchar(80)
);

create table igraci(
sifra int not null primary key identity(1,1),
ime varchar(50) not null,
prezime varchar(80) not null,
dob int,
golovi int not null,
asistencije int not null
);

create table sezone(
tim int not null references natjecanja(pobjednik),
igrac int not null references igrac(sifra)
);