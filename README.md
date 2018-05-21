# Comuni italiani e stradario - Controlli DotNet
## Libreri di controlli Suggest DotNet
Comuni italiani e stradario. Soluzione C# per l'utilizzo del della libreria di controlli autocomplete del servizio SUGGEST.

### Ambiente di sviluppo
  - C#
  - Framework 4.6.1
  - Visual Studio Professional 2017 
  
### Librerie NuGet
  - Modernhttpclient 2.4.2
  - Newtonsoft.Json 11.0.2

### Condizioni
Per l'utilizzo registrarsi sul sito http://streetmaster.it e richiedere la chiave per il servizio SUGGEST.
Il servizio permette di effettuare in maniera gratuita 1800 chiamate mensili. 
Per volumi di utilizzo maggiori consultare nel sito i piani di utilizzo.
Se non viene utilizzata una chiave valida il servizio restituisce nel menu a tendina un avviso.

Il servizio ha una copertura a livello di strada su tutto il territorio nazionale.
La base dati di riferimento è costantemente aggiornata con le variazioni amministrative e postali ufficiali.

### User control
  - SuggestTown : controllo textbox con funzione di autocompletamente del comune
  - SuggestStreet: controllo textbox con funzione di autocompletamente dell'indirizzo

### Ouput
L'autocompletamento del comune si attiva in automatico appena l'utente comincia a scrivere nel textbox
L'autocompletamento dell'indirizzo richiede che sia stato selezionato prima un comune e che il controllo SuggestStreet 
sia collegato ad un controllo SuggestTown tramite la proprietà SuggestTownLinked

Output di base:
  - comune\indirizzo verificato e corretto in tutti i suoi compomenti
  
Informazioni aggiuntive SUGGEST  
 - codice istat del comune
 - codice istat della regione
 - geocodifica xy
 - scomposizione dell'indirizzo in Denominazione urbanistica e Toponimo 
 
### Aggiornamenti base dati comunale
  - 01/01/2016 Istituzione
  - 05/12/2016 Inserimento nuovi comuni di Alpago e Val di Zoldo
  - 05/12/2016 Soppressione comuni di Zoldo Alto,Forno di Zoldo,Prestine, Ivano-Francena,Farra d'Alpago,Pieve d'Alpago,Puos d'Alpago
  - 08/05/2017 Inserimento nuovi comuni di Abetone Cutigliano,San Marcello Piteglio,Valfornace,Colli al Metauro,Terre Roveresche,Alta Valle Intelvi,Terre del Reno
  - 08/05/2017 Soppressione comuni di Selve Marcone,Cavallasca,Acquacanina,Abetone,Cutigliano,San Marcello Pistoiese,Piteglio,San Giovanni D'Asso,Fiordimonte,Pievebovigliana,Piagge,Barchi,Orciano Di Pesaro,San Giorgio Di Pesaro,Montemaggiore Al Metauro,Saltara,Serrungarina,Mirabello,Sant'Agostino,Lanzo D'Intelvi,Pellio Intelvi,Ramponio Verna
  - 06/12/2017 Adeguamento struttura amministrativa della Sardegna. Soppressione delle provincie di Medio Campidano,Carbonia-Iglesias, Olbia-Tempio, Ogliastra e creazione della provincia Sud Sardegna
      
### Support
Per ogni domanda o chiarimento manda una mail a supporto@streetmaster.it

