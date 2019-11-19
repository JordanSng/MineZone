namespace MiniBicks.Data.Models
{
    public class Utilisateur
    {

        public int Id
        {
            get => Id;
            set => Id = value;
        }

        public string Nom
        {
            get => Nom;
            set => Nom = value;
        }

        public string Prenom
        {
            get => Prenom;
            set => Prenom = value;
        }

        public string Role
        {
            get => Role;
            set => Role = value;
        }

        public int SuperieurId
        {
            get => SuperieurId;
            set => SuperieurId = value;
        }

        public Utilisateur(int id, string nom, string prenom, string role, int superieurId)
        {
            Id = id;
            Nom = nom;
            Prenom = prenom;
            Role = role;
            SuperieurId = superieurId;
        }
    }
}