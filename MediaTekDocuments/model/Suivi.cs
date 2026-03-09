using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTekDocuments.model
{
    /// <summary>
    /// Classe métier représentant une étape de suivi d'une commande de document (livre ou dvd).
    /// </summary>
    public class Suivi
    {
        public string idsuivi { get; set; }

        public string libelle { get; set; }

        public Suivi(string idsuivi, string libelle)
        {
            this.idsuivi = idsuivi;
            this.libelle = libelle;
        }
        /// <summary>
        /// Récupération du libellé pour l'affichage dans les comboss
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return libelle;

        }
    }
}
