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
    public class LivreTests
    {
        private string id = "1";
        private string titre = "titre test";
        private string image = "chemin d'image";
        private string isbn = "123";
        private string auteur = "auteur teste";
        private string collection = "collection test";
        private string IdGenre = "01";
        private string Genre = "Action";
        private string IdPublic = "test";
        private string Public = "test";
        private string IdRayon = "test";
        private string Rayon = "test";

        private Livre livre;

        [TestInitialize]
        public void init()
        {
            livre = new Livre(id, titre, image, isbn, auteur, collection, IdGenre, Genre, IdPublic, Public, IdRayon, Rayon);
        }

        [TestMethod()]
        public void LivreTest()
        {
            Assert.AreEqual(id, livre.Id, "Id incorrect");
            Assert.AreEqual(titre, livre.Titre, "Titre incorrect");
            Assert.AreEqual(image, livre.Image, "Image incorrecte");
            Assert.AreEqual(isbn, livre.Isbn, "isbn incorrecte");
            Assert.AreEqual(auteur, livre.Auteur, "auteur incorrect");
            Assert.AreEqual(collection, livre.Collection, "collection incorrect");
            Assert.AreEqual(IdGenre, livre.IdGenre, "IdGenre incorrect");
            Assert.AreEqual(Genre, livre.Genre, "Genre incorrect");
            Assert.AreEqual(IdPublic, livre.IdPublic, "IdPublic incorrect");
            Assert.AreEqual(Public, livre.Public, "Public incorrect");
            Assert.AreEqual(IdRayon, livre.IdRayon, "IdRayon incorrect");
            Assert.AreEqual(Rayon, livre.Rayon, "Rayon incorrect");
        }
    }
}