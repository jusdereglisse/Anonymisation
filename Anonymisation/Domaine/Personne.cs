namespace Anonymisation.Domaine;

public class Personne(int id,
                      string prenom,
                      string nom,
                      string email)
{
    public int Id { get; } = id;
    public string Prenom { get; } = prenom;
    public string Nom { get; } = nom;
    public string Email { get; } = email;
}