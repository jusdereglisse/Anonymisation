
using Anonymisation.Domaine;
using Anonymisation.Donnees;
using AppDbContext db = new();

db.Database.EnsureCreated();

const int id = 123456789;
const string prenomQuelconque = "Thierry";
const string nomQuelconque = "Turcotte";
const string emailQuelconque = "thierryturcotte@hotmail.com";

db.Personnes.Add(new Personne(id,
                              prenomQuelconque,
                              nomQuelconque,
                              emailQuelconque));
db.SaveChanges();

foreach (var p in db.Personnes)
{
    Console.WriteLine($"{p.Id}: {p.}");
}