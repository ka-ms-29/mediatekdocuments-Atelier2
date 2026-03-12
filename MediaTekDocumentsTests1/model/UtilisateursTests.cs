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
    public class UtilisateursTests
    {
        private string iduser = "teste_id";
        private string nom = "test_nom";
        private string prenom = "test_prenom";
        private string mail = "test_mail";
        private string pwd = "test_pwd";
        private string idservice = "test_idservice";

        private Utilisateurs utilisateur;

        [TestInitialize()]
        public void init()
        {
            utilisateur = new Utilisateurs(iduser, nom, prenom, mail, pwd, idservice);
        }
        

        //Utilisateurs(string iduser, string nom, string prenom, string mail, string pwd, string idservice)

        [TestMethod()]
        public void UtilisateursTest()
        {
            Assert.AreEqual(iduser, utilisateur.iduser, "devrait réussir : Iduser valorisé");
            Assert.AreEqual(nom, utilisateur.nom, "devrait réussir : nom valorisé");
            Assert.AreEqual(prenom, utilisateur.prenom, "devrait réussir : prenom valorisé");
            Assert.AreEqual(mail, utilisateur.mail, "devrait réussir : mail valorisé");
            Assert.AreEqual(pwd, utilisateur.pwd, "devrait réussir : pwd valorisé");
            Assert.AreEqual(idservice, utilisateur.idservice, "devrait réussir : idservice valorisé");

        }
    }
}