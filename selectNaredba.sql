
select *, naziv, 1 as iznos, GETDATE() as datum from smjerovi;

select naziv as predmet, GETDATE() as datumpocetka from smjerovi;

select sifra, naziv from smjerovi;

select ime, prezime from polaznici;

select  * from smjerovi
where sifra=1 or sifra=4;




