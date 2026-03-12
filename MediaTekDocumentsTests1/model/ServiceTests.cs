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
    public class ServiceTests
    {
        private const string idservice = "teste_id";
        private const string libelle = "test_libelle";

        private Service service = new Service(idservice, libelle);
        [TestMethod()]
        public void ServiceTest()
        {
            Assert.AreEqual(idservice, service.idservice, "devrait réussir : Id valorisé");
            Assert.AreEqual(libelle, service.libelle, "devrait réussir : Libelle valorisé");
        }
    }
}