use master;
go
drop database if exists ispiti;
go
create database ispiti;
go
use ispiti;

create table IspitniRok(
sifra int not null primary key identity(1,1),
predmet varchar(30),
vrstaIspita char(50),
datum datetime,
pristupio bit
);

create table Pristupnici(
ispitniRok int not null references IspitniRok(sifra),
student char(80),
brojBodova int,
ocjena int
);