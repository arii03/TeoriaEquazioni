using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EquazioniLibrary;

namespace EquazioniLibrary.Test
{
    [TestClass]
    public class Equazioni_Test
    {

        [TestMethod]
        public void TestMethod1()
        {

            double a = 3;
            double b = 4;
            bool risposta_aspettata = true;
            bool risposta = Equazioni.IsDetermined(a, b);
            Assert.AreEqual(risposta_aspettata, risposta);
        }
            
            [TestMethod]
        public void TestMethod2()
        {
            double a = 3;
                double b = 4;
                bool risposta2_aspettata = true;
                bool risposta2 = Equazioni.IsInconsisted(a, b);
                Assert.AreEqual(risposta2_aspettata, risposta2);
            
        }
    }
}
