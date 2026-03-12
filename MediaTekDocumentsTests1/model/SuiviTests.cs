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
    public class SuiviTests
    {
        private const string idsuivi = "teste_id";
        private const string libelle = "test_libelle";
        private Suivi suivi = new Suivi(idsuivi, libelle);

        [TestMethod()]
        public void SuiviTest()
        {
            Assert.AreEqual(idsuivi, suivi.idsuivi, "devrait réussir : Id valorisé");
            Assert.AreEqual(libelle, suivi.libelle, "devrait réussir : Libelle valorisé");
        }

        [TestMethod()]
        public void ToStringTest()
        {
            Assert.AreEqual(libelle, suivi.ToString(), "devrait réussir : libelle retourné");

        }
    }
}