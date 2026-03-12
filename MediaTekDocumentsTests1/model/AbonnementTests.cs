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
    public class AbonnementTests
    {
        private DateTime dateFinAbonnement = new DateTime(2026, 05, 05);
        private const string idRevue = "10005";
        private const string id = "57";
        private DateTime dateCommande = new DateTime(2026, 02, 6);
        private const double montant = 90;

        private Abonnement abonnement;
        public AbonnementTests()
        {
            abonnement = new Abonnement(dateFinAbonnement, idRevue, id, dateCommande, montant);
        }

        //Abonnement(DateTime dateFinAbonnement, string idRevue, string id, DateTime dateCommande, double montant)
        [TestMethod()]
        public void AbonnementTest()
        {
            Assert.AreEqual(dateFinAbonnement, abonnement.dateFinAbonnement, "devrait réussir : dateFinAbonnement valorisé");
            Assert.AreEqual(idRevue, abonnement.idRevue, "devrait réussir : idRevue valorisé");
            Assert.AreEqual(id, abonnement.id, "devrait réussir : id valorisé");
            Assert.AreEqual(dateCommande, abonnement.dateCommande, "devrait réussir : dateCommande valorisé");
            Assert.AreEqual(montant, abonnement.montant, "devrait réussir : montant valorisé");

        }
    }
}