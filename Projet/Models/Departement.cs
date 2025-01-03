namespace Projet.Models
{
    public class Departement
    {
        private int id;
        private string nom;
        private string responsable;
        private decimal budget;
        private List<Enseignant> enseignants;
        private List<Ressource> ressources;


        //public List<DemandeRessource> DemandesRessources { get; set; } = new List<DemandeRessource>();

        public Departement(int id)
        {
            Id = id;
            Nom = "";
            Responsable = "";
            Budget = 0;
            Enseignants = new List<Enseignant>();
            Ressources = new List<Ressource>();
        }
        public int Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Responsable { get => responsable; set => responsable = value; }
        public decimal Budget { get => budget; set => budget = value; }
        public List<Enseignant> Enseignants { get => enseignants; set => enseignants = value; }
        public List<Ressource> Ressources { get => ressources; set => ressources = value; }
        


    }
}
