namespace Anonymisation.Domaine;

public class Personne(int id,
                      string prenom,
                      string nom,
                      string email)
{
    public int Id { get; set; } = id;
    public string Prenom { get; set; } = prenom;
    public string Nom { get; set; } = nom;
    public string Email { get; set; } = email;
}