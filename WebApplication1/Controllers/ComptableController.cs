 namespace WebApplication1.Controllers;
 using WebApplication1.Models;
 public class ComptableController
    {
        public void GenererFacture(Commande commande)
        {
            Console.WriteLine($"Facture generee pour la commande {commande.Id}, montant: {commande.Montant}.");
        }

        public void EnregistrerPaiement(Client client, Versement versement)
        {
            client.Solde += versement.Montant;
            Console.WriteLine($"Paiement de {versement.Montant} enregistre.");
        }
    }