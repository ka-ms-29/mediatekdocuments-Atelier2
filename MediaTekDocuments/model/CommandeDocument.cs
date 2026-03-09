using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace MediaTekDocuments.model
{
    /// <summary>
    /// 
    /// Classe métier représentant une commande de document (livre ou dvd), héritant de la classe Commande.
    /// </summary>
    public class CommandeDocument : Commande
    {
        public int nbExemplaire { get; set; }          
        public string idLivreDvd { get; set; }
        public string idsuivi { get; set; }
        public string EtapeSuivi { get; set; }


        public CommandeDocument(  int nbExemplaire, string idLivreDvd, string IdSuivi, string EtapeSuivi,
                            string id, DateTime dateCommande, double montant)
        : base(id, dateCommande, montant) // constructeur de la classe parent
        {
            this.nbExemplaire = nbExemplaire;
            this.idLivreDvd = idLivreDvd;
            this.idsuivi = IdSuivi;
            this.EtapeSuivi = EtapeSuivi;
        }
    }
}
