using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDCursusLibrary;

namespace TDDCursusLibraryTest
{
    [TestClass]
    public class StatistiekTest
    {
        [TestMethod]
        public void HetGemiddeldeVan10en15is12punt5()
        {
            Assert.AreEqual(12.5m, Statistiek.Gemiddelde(new decimal[] { 10m, 15m }));
        }

        [TestMethod]
        public void HetGemiddeldeVanEenGetalIsDatGetal()
        {
            var enigGetal = 1.23m;
            Assert.AreEqual(enigGetal, Statistiek.Gemiddelde(new decimal[] { enigGetal }));
        }

        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void HetGemiddeldeVanEenLegeVerzamelingKanJeNietBerekenen()
        {
            Statistiek.Gemiddelde(new decimal[] { });
        }

        [TestMethod, ExpectedException(typeof(ArgumentNullException))]
        public void HetGemiddeldeVanNullKanJeNietBerekenen()
        {
            Statistiek.Gemiddelde(null);
        }
    }
}
