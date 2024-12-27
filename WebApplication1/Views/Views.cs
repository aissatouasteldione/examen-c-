namespace WebApplication1.Views
{
    using WebApplication1.Models;

    public class Views
    {
        public void AfficherCommande(Client client)
        {
            Console.WriteLine("--- Commandes du Client ---");
            foreach (var commande in client.Commandes)
            {
                Console.WriteLine($"Commande ID: {commande.Id}, Date: {commande.Date}, Statut: {commande.Statut}, Montant: {commande.Montant}");
            }
        }

        public void AfficherProduits(List<Produit> produits)
        {
            Console.WriteLine("--- Produits Disponibles ---");
            foreach (var produit in produits)
            {
                Console.WriteLine($"Produit: {produit.Libelle}, Prix: {produit.PrixUnitaire}, Stock: {produit.QuantiteStock}");
            }
        }
    }
}
