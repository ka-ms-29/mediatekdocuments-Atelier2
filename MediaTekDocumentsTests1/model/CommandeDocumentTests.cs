using Microsoft.VisualStudio.TestTools.UnitTesting;
using MediaTekDocuments.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTekDocuments.model.Tests
{
    [TestClass()]
    public class CommandeDocumentTests
    {
        private int nbExemplaire = 5;
        private string idLivreDvd = "10005";
        private string IdSuivi = "1";
        private string EtapeSuivi = "en cours";
        private const string id = "5";
        private DateTime dateCommande = new DateTime(2026, 01, 11);
        private const double montant = 90;

        private CommandeDocument commandeDocument = new CommandeDocument(5, "10005", "1", "en cours", "5", new DateTime(2026, 01, 11), 90);

        /// <summary>
        /// teste de la classe métier commandeDocument.
        /// </summary>
        [TestMethod()]
        public void CommandeDocumentTest()
        {
            Assert.AreEqual(nbExemplaire, commandeDocument.nbExemplaire, "devrait réussir : nbExemplaire valorisé");
            Assert.AreEqual(idLivreDvd, commandeDocument.idLivreDvd, "devrait réussir : idLivreDvd valorisé");
            Assert.AreEqual(IdSuivi, commandeDocument.idsuivi, "devrait réussir : idsuivi valorisé");
            Assert.AreEqual(EtapeSuivi, commandeDocument.EtapeSuivi, "devrait réussir : idRevue valorisé");
            Assert.AreEqual(id, commandeDocument.id, "devrait réussir : id valorisé");
            Assert.AreEqual(dateCommande, commandeDocument.dateCommande, "devrait réussir : dateCommande valorisé");
            Assert.AreEqual(montant, commandeDocument.montant, "devrait réussir : montant valorisé");
        }
    }
}