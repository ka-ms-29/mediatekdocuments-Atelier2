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
    public class PublicTests
    {

        private const string id = "100";
        private const string libelle = "Roman";

        private Public lePublic = new Public(id, libelle);

        [TestMethod()]
        public void PublicTest()
        {
            Assert.AreEqual(id, lePublic.Id, "devrait réussir : Id valorisé");
            Assert.AreEqual(libelle, lePublic.Libelle, "devrait réussir : Libelle valorisé");
        }
    }
}