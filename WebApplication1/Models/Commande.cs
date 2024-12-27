namespace WebApplication1.Models;
  public class Commande
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public decimal Montant { get; set; }
        public Client Client { get; set; }
        public List<Produit> Produits { get; set; } = new List<Produit>();
        public string Statut { get; set; }
    }