using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalcoliCombinatori.Test
{
    [TestClass]
    public class UnitTest1
    {
        [DataTestMethod]
        [DataRow(0, 1)]
        [DataRow(1, 1)]
        [DataRow(5, 120)]
        [DataRow(10, 3628800)]
        public void TestMethod1(double numero, double fattoriale_atteso)
        {
            double fattoriale_ricevuto = EquazioniLibrary.CalcoloCombinatori.Fattoriale(numero);

            Assert.AreEqual(fattoriale_ricevuto, fattoriale_atteso);
        }
    }
}
