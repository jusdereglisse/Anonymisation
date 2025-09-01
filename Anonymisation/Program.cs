
using Anonymisation.Domaine;
using Anonymisation.Donnees;
using Anonymisation.Transformation;
using AppDbContext db = new();

db.Database.EnsureCreated();

const int id = 123456789;
const string prenomQuelconque = "Thierry";
const string nomQuelconque = "Turcotte";
const string emailQuelconque = "thierryturcotte@hotmail.com";

if (db.Personnes != null)
{
    db.Personnes.Add(new Personne(id,
                                   prenomQuelconque,
                                   nomQuelconque,
                                   emailQuelconque));
    db.SaveChanges();

    // Données de prod
    Console.WriteLine($"Voici les données de prod: ");

    foreach (Personne p in db.Personnes)
    {
        Console.WriteLine($"{nameof(p.Id)}: {p.Id}, {nameof(p.Prenom)}: {p.Prenom}, {nameof(p.Nom)}: {p.Nom}, {nameof(p.Email)}: {p.Email}");
    }

    // Anonymisation
    var anonymisateur = new PersonneAnonymisation();
    List<Personne> personnesAnonymisees = db.Personnes.Select(p => anonymisateur.Anonymiser(p)).ToList();

    // Données anonymisées
    Console.WriteLine($"Voici les données anonymisées prêtes pour le développement: ");

    foreach (Personne p in personnesAnonymisees)
    {
        Console.WriteLine($"{nameof(p.Id)}: {p.Id}, {nameof(p.Prenom)}: {p.Prenom}, {nameof(p.Nom)}: {p.Nom}, {nameof(p.Email)}: {p.Email}");
    }

    Console.WriteLine($"GG");
}