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
    public class DvdTests
    {
        private string Id = "001";
        private string Titre = "Mon Dvd";
        private string image = "";
        private int duree = 120;
        private string realisateur = "Jean Dupont";
        private string synopsis = "Un film passionnant";
        private string IdGenre = "01";
        private string Genre = "Action";
        private string IdPublic = "test";
        private string Public = "test";
        private string IdRayon = "test";
        private string Rayon = "test";

        private Dvd dvd;

        [TestInitialize]
        public void init()
        {
            dvd = new Dvd(Id, Titre, image, duree, realisateur, synopsis, IdGenre, Genre, IdPublic, Public, IdRayon, Rayon);
        }

        //ublic Dvd(string id, string titre, string image, int duree, string realisateur, string synopsis,
        // string idGenre, string genre, string idPublic, string lePublic, string idRayon, string rayon)
        [TestMethod()]
        public void DvdTest()
        {
            Assert.AreEqual(Id, dvd.Id, "Id incorrect");
            Assert.AreEqual(Titre, dvd.Titre, "Titre incorrect");
            Assert.AreEqual(image, dvd.Image, "Image incorrecte");
            Assert.AreEqual(duree, dvd.Duree, "Durée incorrecte");
            Assert.AreEqual(realisateur, dvd.Realisateur, "Réalisateur incorrect");
            Assert.AreEqual(synopsis, dvd.Synopsis, "Synopsis incorrect");
            Assert.AreEqual(IdGenre, dvd.IdGenre, "IdGenre incorrect");
            Assert.AreEqual(Genre, dvd.Genre, "Genre incorrect");
            Assert.AreEqual(IdPublic, dvd.IdPublic, "IdPublic incorrect");
            Assert.AreEqual(Public, dvd.Public, "Public incorrect");
            Assert.AreEqual(IdRayon, dvd.IdRayon, "IdRayon incorrect");
            Assert.AreEqual(Rayon, dvd.Rayon, "Rayon incorrect");

        }
    }
}