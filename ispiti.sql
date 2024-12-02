use master;
go
drop database if exists ispiti;
go
create database ispiti;
go
use ispiti;

create table IspitniRok(
sifra int not null primary key identity(1,1),
predmet varchar(30) not null,
vrstaIspita char(50) not null,
datum datetime,
pristupio bit not null
);

create table Pristupnici(
ispitniRok int not null references IspitniRok(sifra),
student char(80) not null,
brojBodova int not null,
ocjena int not null
);