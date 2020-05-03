# PI20-066 Sustav za upravljanje događajima noćnih klubova - CLUBBING
mentor: Boris Tomaš

## Projektni tim

Ime i prezime | E-mail adresa (FOI) | JMBAG | Github korisničko ime
------------  | ------------------- | ----- | ---------------------
Domagoj Curić | dcuric@foi.hr | 0016124847 | dcuric
Ivica Strmečki | istrmecki@foi.hr | 0016123439 | ivicastrmecki
Patrik Črnčec | pcrncec@foi.hr | 0016129677 | pcrncec

## Opis domene
Aplikacija „Clubbing“ služi prije svega za pregled različitih događanja u noćnim klubovima na području Grada Zagreba. Prije samog korištenja aplikacije potrebno je izraditi korisnički račun u aplikaciji. Prilikom izrade korisničkog računa potrebno je unijeti broj mobilnog telefona kako bi svaki korisnik imao jedan korisnički račun da bismo izbjegli zlouporabu rezervacija slobodnih mjesta.
Kako se naša aplikacija bazira na pregledu različitih evenata u noćnim klubovima, možemo odabrati područje koje je u našoj domeni interesiranja te uključiti navođenje od trenutne lokacije do samog kluba. Uz sam pregled nadolazećih i događaja u tijeku, pruža mogućnost rezervacije mjesta u odabranom klubu. Za samu rezervaciju potrebno je prvo odabrati broj osoba koji planira prisustvovati događaju kako bi na temelju toga dobili pregled mogućih mjesta za rezervirati. 
Od dodatnih mogućnosti nudi nam se pregled cjenika općenito i akcijske cijene za vrijeme događaja, galerija slika koju mogu ažurirati registrirani korisnici.

## Specifikacija projekta

Oznaka | Naziv | Kratki opis | Odgovorni član tima
------ | ----- | ----------- | -------------------
F01 | Registracija korisnika i prijava  | Korisnik prilikom prvog pokretanja aplikacije mora izraditi korisnički račun. U našoj aplikaciji postoje dvije vrste korisnika. Korisnici aplikacije za pregled noćnih klubova i događaja u njima te administratori unutar samog kluba. Uz sam unos potrebnih korisničkih podataka, prilikom izrade korisničkog računa korisnik mora unijeti broj mobilnog telefona kako bi se izbjegla zlouporaba aplikacije. Nakon registracije, prijava u aplikaciju vrši se unosom korisničkog imena i odabrane lozinke.  | Ivica Strmečki
F02 | Pregled klubova, događaja i ponuda pića | U aplikaciji nam se nudi pregled klubova, na području Grada Zagreba, u kojima će biti održani događaj ili je događaj u tijeku. | Ivica Strmečki
F03 | Pregled lokacije i navigacija do određenog kluba | Korisnici aplikacije imaju mogućnost da za svaki klub koji se nalazi u aplikaciji vide njegovu lokaciju uz pomoć alata Google Maps te se uz pomoć toga u stvarnom vremenu može navigirati korisnika do željenog kluba. | Patrik Črnčec
F04 | Pregled i rezervacija slobodnih mjesta | Korisnici imaju mogućnost pregleda svih slobodnih mjesta u pojedinom klubu i rezervacije mjesta za jednu ili više osoba ukoliko određeni klub ima dovoljno mjesta. Aplikacija omogućuje i slanje obavijesti korisniku kad se oslobodi neko mjesto u njemu željenom klubu ili kad se kreira neki novi događaj u klubu. | Patrik Črnčec
F05 | Unos podataka administratora kluba | Sučelje kojim administrator unutar same aplikacije ima ovlasti CRUD operacija prilikom pregleda i rezervacija mjesta u klubu. | Domagoj Curić
F06 | Potvrđivanje rezervacije | Sučelje koje služi za potvrđivanje online rezervacije određenog mjesta u klubu. Administrator kluba može pregledati tko je rezervirao koje mjesto za koliko ljudi i samim time onda odobriti rezervaciju ili ne. | Domagoj Curić

## Tehnologije i oprema

- Microsoft Visual Studio 2019
- Microsoft SQL Server Management Studio 18
- Microsoft Office
- Visual Paradigm Community Edition
- Github
- Microsoft Project
