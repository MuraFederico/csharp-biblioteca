// See https://aka.ms/new-console-template for more information

//una serie di istanze per "popolare" il nostro "fake db"
// 2 o 3 utenti -> registrati
// 2 o 3 libri --> tutti disponibili
// Gli utenti si possono registrare specificando i dati ...


// Biblioteca online
// 1. registrati
// 2. login

//login 
// email: ..
// passowrd: ..

// Biblioteca online
// 1. Cerca libri
// 2. Cerca dvd

// Registrazione
// Scrivmi il nome: 
// scrivimi il cognome.. etc
// scrivi la passowrd: 

// Menu libro (titolo)
// 1. visualizza dettagli libro
// 2. richiedi prestito
// 3. restitutisci


// tutti i menu hanno esci o torna indietro


using csharp_biblioteca;

UsersList users = new UsersList();
ItemsList items = new ItemsList();
LoansList loans = new LoansList();

users.RegisterUser("Mura", "Federico", "federico@mail.it", "asdfasdf", "123456789");
users.RegisterUser("Alessio", "Vitiello", "alessio@mail.it", "asdfasdf", "123456789");
users.RegisterUser("Margherita", "Laura", "laura@mail.it", "asdfasdf", "123456789");

items.AddItem(0, 120, "Interstellar", "Christopher Nolan", new DateTime(2014), "fantascienza", true, 3);
items.AddItem("978-3-16-148410-0", 900, "Dune", "Frank Herbert", new DateTime(1973), "fantascienza", true, 3);
items.AddItem(1, 155, "Dune", "Denis Villeneuve", new DateTime(2021), "fantascienza", true, 3);


items.FindItem(1).PrintItem();