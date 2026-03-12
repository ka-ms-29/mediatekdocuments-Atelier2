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
    public class ExemplaireTests
    {
        private int numero = 1;
        private DateTime dateAchat = new DateTime(2024, 01, 01);
        private string photo = "photo.jpg";
        private string idEtat = "01";
        private string id = "001";

        private Exemplaire exemplaire;
        [TestInitialize]
        public void init()
        {
            exemplaire = new Exemplaire(numero, dateAchat, photo, idEtat, id);

        }
        //Exemplaire(int numero, DateTime dateAchat, string photo, string idEtat, string idDocument)

        [TestMethod()]
        public void ExemplaireTest()
        {
            Assert.AreEqual(numero, exemplaire.Numero, "devrait réussir : numero valorisé");
            Assert.AreEqual(dateAchat, exemplaire.DateAchat, "devrait réussir : dateAchat valorisé");
            Assert.AreEqual(photo, exemplaire.Photo, "devrait réussir : photo valorisé");
            Assert.AreEqual(idEtat, exemplaire.IdEtat, "devrait réussir : idEtat valorisé");
            Assert.AreEqual(id, exemplaire.Id, "devrait réussir : idDocument valorisé");
        }
    }
}