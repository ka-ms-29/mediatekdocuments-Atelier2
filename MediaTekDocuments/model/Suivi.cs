using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTekDocuments.model
{
    public class Suivi
    {
        public string idsuivi { get; set; }

        public string libelle { get; set; }

        public Suivi(string idsuivi, string libelle)
        {
            this.idsuivi = idsuivi;
            this.libelle = libelle;
        }

        public override string ToString()
        {
            return libelle;

        }
    }
}
