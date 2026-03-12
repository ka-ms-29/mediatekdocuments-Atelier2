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
    public class DocumentTests
    {
        private string Id = "001";
        private string Titre = "Mon document";
        private string Image = "image.jpg";
        private string IdGenre = "01";
        private string Genre = "Roman";
        private string IdPublic = "01";
        private string Public = "Adultes";
        private string IdRayon = "01";
        private string Rayon = "Littérature";

        private Document document;

        [TestInitialize]
        public void init()
        {
            document = new Document(Id, Titre, Image, IdGenre, Genre, IdPublic, Public, IdRayon, Rayon);

        }
        //public Document(string id, string titre, string image, string idGenre, string genre, string idPublic, string lePublic, string idRayon, string rayon)


        /// <summary>
        /// tester le constructeur de la classe métier Document.
        /// </summary>
        [TestMethod()]
        public void DocumentTest()
        {
            Assert.AreEqual(Id, document.Id, "Id incorrect");
            Assert.AreEqual(Titre, document.Titre, "Titre incorrect");
            Assert.AreEqual(Image, document.Image, "Image incorrecte");
            Assert.AreEqual(IdGenre, document.IdGenre, "IdGenre incorrect");
            Assert.AreEqual(Genre, document.Genre, "Genre incorrect");
            Assert.AreEqual(IdPublic, document.IdPublic, "IdPublic incorrect");
            Assert.AreEqual(Public, document.Public, "Public incorrect");
            Assert.AreEqual(IdRayon, document.IdRayon, "IdRayon incorrect");
            Assert.AreEqual(Rayon, document.Rayon, "Rayon incorrect");

        }
    }
}