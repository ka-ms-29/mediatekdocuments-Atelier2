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
    public class EtatTests
    {
        private const string id = "1";
        private const string libelle = "neuf";

        private Etat etat = new Etat(id, libelle);
        [TestMethod()]
        public void EtatTest()
        {
            Assert.AreEqual(id, etat.Id, "devrait réussir : Id valorisé");
            Assert.AreEqual(libelle, etat.Libelle, "devrait réussir : Libelle valorisé");
        }
    }
}