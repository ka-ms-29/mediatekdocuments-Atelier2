using MediaTekDocuments.dal;
using MediaTekDocuments.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTekDocuments.controller
{
    class FrmCommandeLivreController
    {
        /// <summary>
        /// Objet d'accès aux données
        /// </summary>
        private readonly Access access;

        /// <summary>
        /// Récupération de l'instance unique d'accès aux données
        /// </summary>
        public FrmCommandeLivreController()
        {
            access = Access.GetInstance();
        }

        public List<Suivi> GetAllSuivi()
        {
            return access.GetAllSuivi();
        }

        public List<Livre> GetAllLivres()
        {
            return access.GetAllLivres();
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
