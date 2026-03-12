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
    public class CommandeTests
    {
        private const string id = "5";
        private DateTime dateCommande = new DateTime(2026, 01, 11);
        private const double montant = 90;

        private Commande commande;

        public CommandeTests()
        {
            commande = new Commande(id, dateCommande, montant);
        }
        [TestMethod()]
        public void CommandeTest()
        {
            Assert.AreEqual(id, commande.id, "devrait réussir : id valorisé");
            Assert.AreEqual(dateCommande, commande.dateCommande, "devrait réussir : dateCommande valorisé");
            Assert.AreEqual(montant, commande.montant, "devrait réussir : montant valorisé");

        }
    }
}