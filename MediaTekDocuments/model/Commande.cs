using System;

namespace MediaTekDocuments.model
{
    /// <summary>
    /// classe métier représentant une commande.
    /// </summary>
    public class Commande
    {
        public string id { get; set; }
        public DateTime dateCommande { get; set; }
        public double montant { get; set; }

        public Commande(string id, DateTime dateCommande, double montant)
        {
            this.id = id;
            this.dateCommande = dateCommande;
            this.montant = montant;
        }
    }
}
