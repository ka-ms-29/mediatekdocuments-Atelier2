using MediaTekDocuments.dal;
using MediaTekDocuments.model;
using System.Collections.Generic;

namespace MediaTekDocuments.controller
{
    /// <summary>
    /// controller
    /// </summary>
    internal class NamespaceDoc
    {
    }
    /// <summary>
    /// Contrôleur lié à FrmCommandeRevue
    /// </summary>
    public class FrmCommandeRevueController
    {
        /// <summary>
        /// Objet d'accès aux données
        /// </summary>
        private readonly Access access;

        /// <summary>
        /// Récupération de l'instance unique d'accès aux données
        /// </summary>
        public FrmCommandeRevueController()
        {
            access = Access.GetInstance();
        }

        /// <summary>
        /// getter sur la liste des revues
        /// </summary>
        /// <returns>Liste d'objets Revue</returns>
        public List<Revue> GetAllRevues()
        {
            return access.GetAllRevues();
        }
        /// <summary>
        /// Récupère toutes les abonnement (commande de revue) d'un revue à partir Access. 
        /// </summary>
        /// <param name="idDocument"></param>
        /// <returns></returns>
        public List<Abonnement> GetAbonnementRevue(string idDocument)
        {
            return access.GetAbonnementRevue(idDocument);
        }
        /// <summary>
        /// Envoi Abonnement a la classe Access pour la enregistrer dans BDD
        /// </summary>
        /// <param name="abonnement"></param>
        /// <returns></returns>
        public bool AjouteAbonnementRevue(Abonnement abonnement)
        {
            return access.AjoutAbonnementRevue(abonnement);
        }
        /// <summary>
        /// Récupère la liste des exemplaire d'un revue
        /// </summary>
        /// <param name="idDocuement"></param>
        /// <returns></returns>
        public List<Exemplaire> GetExemplairesRevue(string idDocuement)
        {
            return access.GetExemplairesRevue(idDocuement);
        }
        /// <summary>
        /// Supprime un abonnement de revue qui corespond à idAbonnement.
        /// </summary>
        /// <param name="idAbonnement"></param>
        /// <returns></returns>
        public bool SupprimerAbonnementRevue(string idAbonnement)
        {
            return access.SupprimerAbonnementRevue(idAbonnement);
        }
    }
}
