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
    public class RevueTests
    {
        private string periodicite = "test";
        private int delaiMiseADispo = 2;
        private string Id = "001";
        private string Titre = "Mon revue";
        private string image = "image.jpg";        
        private string IdGenre = "01";
        private string Genre = "Action";
        private string IdPublic = "test";
        private string Public = "test";
        private string IdRayon = "test";
        private string Rayon = "test";

        public Revue revue;
        [TestInitialize()]
        public void init()
        {
            revue = new Revue(Id, Titre, image, IdGenre, Genre, IdPublic, Public, IdRayon, Rayon, periodicite, delaiMiseADispo);
        }
        
        // public Revue(string id, string titre, string image, string idGenre, string genre,
        //string idPublic, string lePublic, string idRayon, string rayon,
        //   string periodicite, int delaiMiseADispo)


        [TestMethod()]
        public void RevueTest()
        {
            Assert.AreEqual(periodicite, revue.Periodicite, "Durée incorrecte");
            Assert.AreEqual(delaiMiseADispo, revue.DelaiMiseADispo, "Réalisateur incorrect");

            Assert.AreEqual(Id, revue.Id, "Id incorrect");
            Assert.AreEqual(Titre, revue.Titre, "Titre incorrect");
            Assert.AreEqual(image, revue.Image, "Image incorrecte");
            
            Assert.AreEqual(IdGenre, revue.IdGenre, "IdGenre incorrect");
            Assert.AreEqual(Genre, revue.Genre, "Genre incorrect");
            Assert.AreEqual(IdPublic, revue.IdPublic, "IdPublic incorrect");
            Assert.AreEqual(Public, revue.Public, "Public incorrect");
            Assert.AreEqual(IdRayon, revue.IdRayon, "IdRayon incorrect");
            Assert.AreEqual(Rayon, revue.Rayon, "Rayon incorrect");
        }
    }
}