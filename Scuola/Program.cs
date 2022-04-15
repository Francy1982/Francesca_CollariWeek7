// See https://aka.ms/new-console-template for more information
using Scuola;
using System.Data.SqlClient;

Console.WriteLine("\n\nRicerca utenti in un DB\n\n");


//1) C
//2) B
//3) A, D

RepositoryAdo repo = new RepositoryAdo();


//Utente utenteRecuperato = repo.GetUtente("Mario", "Rossi", 30);
Utente utenteRecuperato = repo.GetUtente("Francesca", "Collari", 39);

Console.WriteLine($"\n\nL'utente {utenteRecuperato.Nome} {utenteRecuperato.Cognome} è stato recuperato dal DB\n\n");   
