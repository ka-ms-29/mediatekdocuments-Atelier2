using MediaTekDocuments.dal;
using MediaTekDocuments.model;
using System.Collections.Generic;

namespace MediaTekDocuments.controller
{

    /// <summary>
    /// Controller lié au Form de Commande un documment (livre/Dvd)
    /// FrmCommandeLivre
    /// FrmCommandeDvd
    /// </summary>
    class FrmCommandeDocumentController
    {
        /// <summary>
        /// Objet d'accès aux données
        /// </summary>
        private readonly Access access;

        /// <summary>
        /// Récupération de l'instance unique d'accès aux données
        /// </summary>
        public FrmCommandeDocumentController()
        {
            access = Access.GetInstance();
        }
        /// <summary>
        /// Récupère la liste des suivis de comande à partir Access.
        /// </summary>
        /// <returns></returns>
        public List<Suivi> GetAllSuivi()
        {
            return access.GetAllSuivi();
        }
        /// <summary>
        /// Récupère la liste des livres de comande à partir Access.
        /// </summary>
        /// <returns></returns>
        public List<Livre> GetAllLivres()
        {
            return access.GetAllLivres();
        }
        /// <summary>
        /// Récupère la liste des Dvds de comande à partir Access.
        /// </summary>
        /// <returns></returns>
        public List<Dvd> GetAllDvd()
        {
            return access.GetAllDvd();
        }
        /// <summary>
        /// Récupère la liste des commandes d'un document à partir Access.
        /// </summary>
        /// <param name="idDocument"></param>
        /// <returns></returns>
        public List<CommandeDocument> GetCommandeDocument(string idDocument)
        {
            return access.GetCommandesDocument(idDocument);
        }
        /// <summary>
        /// Envoi la demmande d'ajout nouvelle commande pour un document.
        /// </summary>
        /// <param name="commandeDocument"></param>
        /// <returns></returns>
        public bool AjoutCommandeDocument(CommandeDocument commandeDocument)
        {
            return access.AjoutCommandeDocument(commandeDocument);
        }
        /// <summary>
        /// Envoi la demmande de modification de l'étape de suivi d'un commande existant.
        /// </summary>
        /// <param name="idCommande"></param>
        /// <param name="idSuivi"></param>
        /// <returns></returns>
        public bool ModifierSuiviCommande(string idCommande, string idSuivi)
        {
            return access.ModifierSuiviCommande(idCommande, idSuivi);
        }
        /// <summary>
        /// Envoie la demande de supprime d'un commande document à Access
        /// </summary>
        /// <param name="idDocument"></param>
        /// <returns></returns>
        public bool SupprimerCommandeDocument(string idDocument)
        {
            return access.SupprimerCommandeDocument(idDocument);
        }
    }
}
