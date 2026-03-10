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