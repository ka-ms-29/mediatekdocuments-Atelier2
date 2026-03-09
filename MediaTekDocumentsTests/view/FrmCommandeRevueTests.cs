using Microsoft.VisualStudio.TestTools.UnitTesting;
using MediaTekDocuments.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MediaTekDocuments.view.Tests
{
    [TestClass()]
    public class FrmCommandeRevueTests
    {
        [TestMethod()]
        public void parutionDansAbonnementTest()
        {
            DateTime dateCommande = new DateTime(2026, 03, 01);
            DateTime dateFinAbonnement = new DateTime(2026, 03, 31);

            DateTime dateParution1 = new DateTime(2026, 03, 15);
            //Assert.IsTrue(parutionDansAbonnement(dateParution1, dateCommande, dateFinAbonnement));
        }
    }
}