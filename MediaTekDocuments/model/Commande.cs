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

        /// <summary>
        /// constructeur de la classe, valorisant les propriétés de la classe Commande
        /// </summary>
        /// <param name="id"></param>
        /// <param name="dateCommande"></param>
        /// <param name="montant"></param>
        public Commande(string id, DateTime dateCommande, double montant)
        {
            this.id = id;
            this.dateCommande = dateCommande;
            this.montant = montant;
        }
    }
}
