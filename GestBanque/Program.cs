using Models;

Console.OutputEncoding = System.Text.Encoding.Unicode;

Personne p1 = new Personne();
p1.Nom = "Legrain";
p1.Prenom = "Samuel";
p1.DateNaiss = new DateTime(1987, 9, 27);

Personne p2 = new Personne() { 
    Nom = "Morre",
    Prenom = "Thierry",
    DateNaiss = new DateTime(1970,1,1)
};

Console.WriteLine($"Identité : {p1.Nom} {p1.Prenom}, né le {p1.DateNaiss}");
Console.WriteLine($"Identité : {p2.Nom} {p2.Prenom}, né le {p2.DateNaiss}");

Courant c1 = new Courant() { 
    Numero = "BE01",
    LigneDeCredit = 200,
    Titulaire = new Personne()
    {
        Nom = "Person",
        Prenom = "Michael",
        DateNaiss = new DateTime(1980,1,1)
    }
};

c1.Depot(20_000);
Console.WriteLine($"Le compte courant : {c1.Numero}\n" +
    $"du titulaire : {c1.Titulaire.Nom} {c1.Titulaire.Prenom}\n" +
    $"né le {c1.Titulaire.DateNaiss}\n" + 
    $"a comme solde {c1.Solde} € avec une ligne de credit de {c1.LigneDeCredit} €.");
c1.Retrait(21_000);
