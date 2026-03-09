using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTekDocuments.model
{
    public class Utilisateurs
    {
        public string iduser { get; set; }
        public string nom {  get; set; }
        public string prenom { get; set; }
        public string mail { get; set; }
        public string pwd { get; set; }
        public string idservice { get; set; }


        public Utilisateurs(string iduser, string nom, string prenom, string mail, string pwd, string idservice)
        {
            this.iduser = iduser;
            this.nom = nom;
            this.prenom = prenom;
            this.mail = mail;
            this.pwd = pwd;
            this.idservice = idservice;

        }



    }
}
