using System;

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

        /// <summary>
        /// constructeur de la classe, valorisant les propriété de la classe.
        /// </summary>
        /// <param name="nbExemplaire"></param>
        /// <param name="idLivreDvd"></param>
        /// <param name="IdSuivi"></param>
        /// <param name="EtapeSuivi"></param>
        /// <param name="id"></param>
        /// <param name="dateCommande"></param>
        /// <param name="montant"></param>
        public CommandeDocument(int nbExemplaire, string idLivreDvd, string IdSuivi, string EtapeSuivi,
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
