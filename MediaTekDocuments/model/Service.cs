using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTekDocuments.model
{
    /// <summary>
    /// classe métier 
    /// </summary>
    public class Service
    {
        public string idservice { get; set; }
        public string libelle { get; set; }

        public Service(string idservice, string libelle)
        {
            this.idservice = idservice;
            this.libelle = libelle;
        }
    }
}