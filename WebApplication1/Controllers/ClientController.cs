
// CONTROLEURS
namespace WebApplication1.Controllers;

    using WebApplication1.Models;

    public class ClientController
    {
        public void PasserCommande(Client client, List<Produit> produits)
        {
            var commande = new Commande
            {
                Date = DateTime.Now,
                Client = client,
                Produits = produits,
                Montant = CalculerMontant(produits),
                Statut = "En attente"
            };
            client.Commandes.Add(commande);
            Console.WriteLine("Commande enregistree avec succes.");
        }

        private decimal CalculerMontant(List<Produit> produits)
        {
            decimal montant = 0;
            foreach (var produit in produits)
            {
                montant += produit.PrixUnitaire;
            }
            return montant;
        }
    }