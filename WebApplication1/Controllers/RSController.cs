namespace WebApplication1.Controllers
{
     using WebApplication1.Models;
public class RSController
    {
        public void AjouterProduit(Produit produit)
        {
            Console.WriteLine($"Produit {produit.Libelle} ajoute au stock.");
        }

        public void MettreAJourStock(Produit produit, int quantiteAjoutee)
        {
            produit.QuantiteStock += quantiteAjoutee;
            Console.WriteLine($"Stock mis a jour: {produit.QuantiteStock} en stock.");
        }
    }
}    