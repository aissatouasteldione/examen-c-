    namespace WebApplication1.Models;
    public class Versement
    {
        public int Id { get; set; }
        public DateTime DateVersement { get; set; }
        public decimal Montant { get; set; }
        public string TypePaiement { get; set; }
        public string Reference { get; set; }
    }
