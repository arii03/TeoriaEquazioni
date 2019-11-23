using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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
    }
}
