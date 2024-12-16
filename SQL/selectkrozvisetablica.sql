
select b.naziv as grupa, a.naziv as smjer, b.predavac
from smjerovi a inner join grupe b
on a.sifra = b.smjer;

select a.naziv, b.naziv as grupa, b.predavac
from smjerovi a left join grupe b
on a.sifra = b.smjer;


select b.naziv as grupa,
a.naziv as smjer,
d.ime, d.prezime
from smjerovi a
inner join grupe b on a.sifra=b.smjer
inner join clanovi c on b.sifra=c.grupa
inner join polaznici d on d.sifra=c.polaznik;

update grupe set predavac='Pero Perić' where sifra=3;



use knjiznica;

select concat(a.ime,'', a.prezime) as autor,
b.naslov, c.naziv as izdavac,
d.naziv as mjesto
from autor a
inner join katalog b on a.sifra=b.autor
inner join izdavac c on c.sifra=b.izdavac
inner join mjesto d on d.sifra=b.mjesto
where a.ime like 'I%'
order by a.prezime;


