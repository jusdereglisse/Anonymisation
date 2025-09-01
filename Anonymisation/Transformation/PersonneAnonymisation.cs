using Anonymisation.Domaine;

namespace Anonymisation.Transformation
{
    public class PersonneAnonymisation : IAnonymisation<Personne>
    {
        static readonly string[] PrenomsQuelconques = { "Alice", "Bob", "Charlie", "Diane", "Eve", "Frank" };
        static readonly string[] NomsQuelconques = { "Dupont", "Martin", "Durand", "Lefebvre", "Moreau" };
        static readonly Random _random = new();

        public Personne Anonymiser(Personne entitee)
        {
            var nouveauPrenom = PrenomsQuelconques[_random.Next(PrenomsQuelconques.Length)];
            var nouveauNom = NomsQuelconques[_random.Next(NomsQuelconques.Length)];
            var nouvelEmail = $"{nouveauPrenom.ToLower()}.{nouveauNom.ToLower()}@example.com";

            return new Personne(entitee.Id,
                                nouveauPrenom,
                                nouveauNom,
                                nouvelEmail);
        }
    }
}