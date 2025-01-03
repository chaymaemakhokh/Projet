namespace Projet.Models
{
    public class Ressource
    {
        public int Id;
        public string NumeroInventaire;
        public string Marque;
        public string Statut;
        public DateTime DateLivraison;
        public DateTime GarantieExpiration;

        public Ressource(int id, string numeroInventaire)
        {
            Id = id;
            NumeroInventaire = numeroInventaire;
            Marque = "";
            Statut = "";
            DateLivraison = ;
            GarantieExpiration = garantieExpiration;
        }
    }
}
