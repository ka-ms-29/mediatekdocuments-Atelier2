using MediaTekDocuments.dal;
using MediaTekDocuments.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTekDocuments.controller
{
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
        public List<Abonnement> GetAbonnementRevue(string idDocument)
        {
            return access.GetAbonnementRevue(idDocument);
        }
        public bool AjouteAbonnementRevue(Abonnement abonnement)
        {
            return access.AjoutAbonnementRevue(abonnement);
        }
        public List<Exemplaire> GetExemplairesRevue(string idDocuement)
        {
            return access.GetExemplairesRevue(idDocuement);
        }
        public bool SupprimerAbonnementRevue(string idAbonnement)
        {
            return access.SupprimerAbonnementRevue(idAbonnement);
        }
    }
}
