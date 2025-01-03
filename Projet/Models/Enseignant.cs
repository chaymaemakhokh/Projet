namespace Projet.Models
{
    public class Enseignant
    {
        public int Id;
        public string Nom;
        public string Prenom;
        public string Email;
        public string Telephone;
        public int DepartementId;
        public Departement Departement;
        public List<Ressource> Ressources { get; set; } = new List<Ressource>();
        public List<Panne> PannesSignalees { get; set; } = new List<Panne>();
    }
}
