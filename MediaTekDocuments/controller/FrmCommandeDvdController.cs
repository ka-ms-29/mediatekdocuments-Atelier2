using MediaTekDocuments.dal;
using MediaTekDocuments.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTekDocuments.controller
{
    internal class FrmCommandeDvdController
    {
        /// <summary>
        /// Objet d'accès aux données
        /// </summary>
        private readonly Access access;
        /// <summary>
        /// Récupération de l'instance unique d'accès aux données
        /// </summary>
        public FrmCommandeDvdController()
        {
            access = Access.GetInstance();
        }

        /// <summary>
        /// getter sur la liste des Dvd
        /// </summary>
        /// <returns>Liste d'objets dvd</returns>
        public List<Dvd> GetAllDvd()
        {
            return access.GetAllDvd();
        }
       
        public List<Suivi> GetAllSuivi()
        {
            return access.GetAllSuivi();
        }
        public List<CommandeDocument> GetCommandesLivre(string idLivre)
        {
            return access.GetCommandesLivre(idLivre);
        }

        public bool AjoutCommandeDocument(CommandeDocument commandeDocument)
        {
            return access.AjoutCommandeDocument(commandeDocument);
        }

        public bool ModifierSuiviCommande(string idCommande, string idSuivi)
        {
            return access.ModifierSuiviCommande(idCommande, idSuivi);
        }

        public bool SupprimerCommandeDocument(string idDocument)
        {
            return access.SupprimerCommandeDocument(idDocument);
        }
    }
}
