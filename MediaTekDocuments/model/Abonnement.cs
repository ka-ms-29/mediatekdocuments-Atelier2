using System;

namespace MediaTekDocuments.model
{
    /// <summary>
    /// classe métier représentant une commande d'abonnement à une revue, héritant de la classe Commande
    /// </summary>
    public class Abonnement : Commande
    {
        public DateTime dateFinAbonnement { get; set; }
        public string idRevue { get; set; }

        /// <summary>
        /// constructeur de la classe
        /// </summary>
        /// <param name="dateFinAbonnement"></param>
        /// <param name="idRevue"></param>
        /// <param name="id"></param>
        /// <param name="dateCommande"></param>
        /// <param name="montant"></param>
        public Abonnement(DateTime dateFinAbonnement, string idRevue, string id, DateTime dateCommande, double montant)
            : base(id, dateCommande, montant)
        {
            this.dateFinAbonnement = dateFinAbonnement;
            this.idRevue = idRevue;
        }


    }
}
