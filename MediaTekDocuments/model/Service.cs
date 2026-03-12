namespace MediaTekDocuments.model
{
    /// <summary>
    /// classe métier représentant la table service (service de l'utilisateur).
    /// </summary>
    public class Service
    {
        public string idservice { get; set; }
        public string libelle { get; set; }

        /// <summary>
        /// constructeur de la classe, valorisant les propriété de la classe.
        /// </summary>
        /// <param name="idservice"></param>
        /// <param name="libelle"></param>
        public Service(string idservice, string libelle)
        {
            this.idservice = idservice;
            this.libelle = libelle;
        }
    }
}