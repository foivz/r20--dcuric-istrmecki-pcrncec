# Inicijalne upute za prijavu projekta iz Programskog inženjerstva

Poštovane kolegice i kolege, 

čestitamo vam jer ste uspješno prijavili svoj projektni tim na kolegiju Programsko inženjerstvo, te je za vas automatski kreiran repozitorij koji ćete koristiti za verzioniranje vašega koda, ali i za pisanje dokumentacije.

Ovaj dokument (README.md) predstavlja **osobnu iskaznicu vašeg projekta**. Vaš prvi zadatak, ukoliko niste odabrali da želite raditi na projektu sa gospodarstvom je **prijaviti vlastiti projektni prijedlog** na način da ćete prijavu vašeg projekta, sukladno uputama danim u ovom tekstu, napisati upravo u ovaj dokument, umjesto ovoga teksta.

Za upute o sintaksi koju možete koristiti u ovom dokumentu i kod pisanje vaše projektne dokumentacije pogledajte [ovaj link](https://guides.github.com/features/mastering-markdown/).

Nakon vaše prijave bit će vam dodijeljen mentor s kojim ćete tijekom semestra raditi na ovom projektu. A sada, vrijeme je da prijavite vaš projekt. Za prijavu vašeg projektnog prijedloga molimo vas koristite **predložak** koji je naveden u nastavku, a započnite tako da kliknete na *olovku* u desnom gornjem kutu ovoga dokumenta :) 

# Sustav za upravljanje događajima noćnih klubova - CLUBBING


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
Umjesto ovih uputa opišite zahtjeve za funkcionalnošću programskog proizvoda. Pobrojite osnovne funkcionalnosti i za svaku naznačite ime odgovornog člana tima. Opišite buduću arhitekturu programskog proizvoda. Obratite pozornost da bi arhitektura trebala biti višeslojna s odvojenom (dislociranom) bazom podatka. Također uzmite u obzir da bi svaki član tima treba biti odgovorana za otprilike 3 funkcionalnosti, te da bi opterećenje članova tima trebalo biti ujednačeno. Priložite odgovarajuće dijagrame i skice gdje je to prikladno. Funkcionalnosti sustava bobrojite u tablici ispod koristeći predložak koji slijedi:

Oznaka | Naziv | Kratki opis | Odgovorni član tima
------ | ----- | ----------- | -------------------
F01 | Registracija korisnika i prijava  | Za pristup dnevniku potrebnba je autentikacija korisnika pomoću login funkcionalnosti. Korisnik se logira s podacima koji su mu dodijeljeni prilikom ... | Zlatko Stapić
F02 | Pregled klubova, događaja i ponuda pića | Za pristup dnevniku potrebnba je autentikacija korisnika pomoću login funkcionalnosti. Korisnik se logira s podacima koji su mu dodijeljeni prilikom ... | Zlatko Stapić
F03 | Pregled lokacije i navigacija do određenog kluba | Za pristup dnevniku potrebnba je autentikacija korisnika pomoću login funkcionalnosti. Korisnik se logira s podacima koji su mu dodijeljeni prilikom ... | Zlatko Stapić
F04 | Pregled i rezervacija slobodnih mjesta | Za pristup dnevniku potrebnba je autentikacija korisnika pomoću login funkcionalnosti. Korisnik se logira s podacima koji su mu dodijeljeni prilikom ... | Zlatko Stapić
F05 | Unos podataka administratora kluba | Za pristup dnevniku potrebnba je autentikacija korisnika pomoću login funkcionalnosti. Korisnik se logira s podacima koji su mu dodijeljeni prilikom ... | Zlatko Stapić
F06 | Potvrđivanje rezervacije | Za pristup dnevniku potrebnba je autentikacija korisnika pomoću login funkcionalnosti. Korisnik se logira s podacima koji su mu dodijeljeni prilikom ... | Zlatko Stapić

## Tehnologije i oprema
Umjesto ovih uputa jasno popišite sve tehnologije, alate i opremu koju ćete koristiti pri implementaciji vašeg rješenja. Ne zaboravite planirati korištenje tehnologija u aktivnostima kao što su projektni menadžment ili priprema dokumentacije. Tehnologije koje ćete koristiti bi trebale biti javno dostupne, a ako ih ne budemo obrađivali na vježbama u vašoj dokumentaciji ćete morati navesti način preuzimanja, instaliranja i korištenja onih tehnologija koje su neopbodne kako bi se vaš programski proizvod preveo i pokrenuo. Pazite da svi alati koje ćete koristiti moraju imati odgovarajuću licencu.
