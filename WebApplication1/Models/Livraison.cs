  namespace WebApplication1.Models;
  public class Livraison
    {
        public int Id { get; set; }
        public DateTime DateLivraison { get; set; }
        public string AdresseLivraison { get; set; }
        public Livreur Livreur { get; set; }
    }