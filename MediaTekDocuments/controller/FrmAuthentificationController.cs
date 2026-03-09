using MediaTekDocuments.dal;
using MediaTekDocuments.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTekDocuments.controller
{
    public class FrmAuthentificationController
    {
        /// <summary>
        /// Objet d'accès aux données
        /// </summary>
        private readonly Access access;

        /// <summary>
        /// Récupération de l'instance unique d'accès aux données
        /// </summary>
        public FrmAuthentificationController()
        {
            access = Access.GetInstance();
        }
        /// <summary>
        /// Récupération de la liste des utilisateurs correspondant au nom et mot de passe saisis, à partir de la méthode GetUtilisateur de la classe Access.
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="pwd"></param>
        /// <returns></returns>
        public List<Utilisateurs> GetUtilisateurs(string nom, string pwd)
        {
            return access.GetUtilisateur(nom, pwd);
        }

       
    }
}
