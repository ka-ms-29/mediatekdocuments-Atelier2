using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTekDocuments.model
{
    public class Abonnement : Commande
    {
        public DateTime dateFinAbonnement {  get; set; }
        public string idRevue { get; set; }

        public Abonnement( DateTime dateFinAbonnement, string idRevue, string id, DateTime dateCommande, double montant) 
            : base (id, dateCommande, montant)
        { 
            this.dateFinAbonnement = dateFinAbonnement;
            this.idRevue = idRevue;
        }
    }
}
