namespace MediaTekDocuments.model
{
    /// <summary>
    /// classe métier représentant la table utilisateurs.
    /// </summary>
    public class Utilisateurs
    {
        public string iduser { get; set; }
        public string nom { get; set; }
        public string prenom { get; set; }
        public string mail { get; set; }
        public string pwd { get; set; }
        public string idservice { get; set; }

        /// <summary>
        /// constructeur de la classe, valorisant les propriété de la classe.
        /// </summary>
        /// <param name="iduser"></param>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="mail"></param>
        /// <param name="pwd"></param>
        /// <param name="idservice"></param>
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
