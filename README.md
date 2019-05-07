Portfolio hardverskih rešenja, Arduino, Raspberry Pi, Internet Of Things u formi bloga.

ASP.NET Web Application (.NET Framework)
MVC templejt sa uključenom autentifikacijom "Individual User Accounts"

Projekat - Portfolio hardverskih rešenja, Arduino, Raspberry Pi, Internet Of Things...

Index (home) strana - slideshow - bootstrap slideshow
About (about) strana -about us - BootStrap cards ili sl.
Projects (portfolio) strana - Gallery Portfolio - lista artikala iz baze
Contakt (contact) strana - Get In Touch -Kontakt forma za slanje poruke na naš mail
Upload (Add) strana za upis novih artikala u bazu 

Login/Regiser linkovi
-custom register field - dodatno polje "puno ime", "adresa" ili "broj telefona"
-Kontakt strana vidljiva samo ulogovanim korisnicima
-Upload strana vidljiva samo administratoru

Users - lokalna code-first baza sa mogućnošću dalje migracije
Portfolio - dodatna baza za galeriju
-bootstrap + custom css i javascript



prvo ukljucimo migracije pm-> enable migrations
pravimo model, uz pomoć get-set metode definisemo izgled tabele, dodajemo stavke u tabelu, id, title, story, url,
pravimo dodatni model za odeljenje projekta
i pravimo izdvojeni kontekst model za komunikaciju sa bazom (projectDBcontext)

pravimo kontroler koji će da spaja model i view (projects_controller)
iz kontolora kreiramo view koji će nam prikazati stavke iz baze
dodaćemo u kontroleru details za detaljni prikaz svakog projekta iz portfolia,
create za stranu gde se dodaje novi projekat, edit za naknadno uređivanje i delete za brisanje stavke tj projekta i za svaki od njih prvimo i view stranu.

-u projects kontroleru dodajemo [authorize] ispred stavki koje želimo da omogućimo samo ulogovanim korisnicima (edit, delete)

da bi ubacili slike, potrebno je da definišemo u tabeli stavku url koja će sadržti putanju do slike u folderu naseg projekta (content), a sliku aploudujemo pomocu input type="file" dok u kontroleru dodajemo if petlju kako bi snimili odabrani fajl u folder.

pravimo model emailform za kontakt stranu, dodamo u HomeController klasu kojom ćemo povezati contact view za prikaz forme za slanje emila.
 
pokrenemo projekat i registrujemo se kako bi sistem automatski napravio lokalnu login-bazu
uradimo migraciju za svaku bazu posebno (enable-migrtions -ConfigurationTypeName Configuration two - gde smo definisali ime migracije configuration() migracija moze da se pozove i preko kontekst klase -ContextTypeName v2.models.ProjectDBContext )
kad radimo migracije tj menjamo bazu preko code-first metode treba da upišemo ime ili kontekst baze na koju se odnosi migracija. (enable-migrations -context , add-migrtion -context)

sve stavke koje smo dodali u bazu neće biti vidljive tj izgubićemo vertikalni prikaz tabele ukoliko pokrenemo projekat na drugoj lokaciji. kako bi ubacili stavke u bazu koje će biti vidljive moramo da mapravimo seed za stavke koje želimo da prikažemo u inicijalnoj bazi.
seed se pravi tako što editujemo configuration.cs fajl u folderu migrations određene baze
dodjemo sql komande za upis u bazu unutar klase -- protected override void Seed(v2.Models.ProjectDBContext context) {}

pravimo custom navigaciju uz pomoć java skripta (nalazi se u main.js)
pravimo slideshow preko bootstrap carousel klase i preko foreach dodajemo u prikaz slike koje se trenutno nalaze u bazi
preko foreach petlje dodajemo i tabelarni prikaz stavki iz baze (opciono)

dodaćemo još bootstrap i custom css klase za ulepšavanje, animacije











