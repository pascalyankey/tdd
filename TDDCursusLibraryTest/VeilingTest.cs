using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDCursusLibrary;

namespace TDDCursusLibraryTest
{
    [TestClass]
    public class VeilingTest
    {
        private Veiling veiling;
        [TestInitialize] public void Initialize()
        {
            veiling = new Veiling();
        }

        [TestMethod]
        public void IndienNogGeenBodIsHetHoogsteBodNul()
        {
            Assert.AreEqual(decimal.Zero, veiling.HoogsteBod);
        }

        [TestMethod]
        public void HetHoogsteBodIsGelijkAanHetEersteBod()
        {
            var bedrag = 1000;
            veiling.DoeBod(bedrag);
            Assert.AreEqual(bedrag, veiling.HoogsteBod);
        }

        [TestMethod]
        public void HetHoogsteBodIsGelijkAanHetBedragVanHetHoogsteBod()
        {
            veiling.DoeBod(1000);
            var hoogsteBod = veiling.HoogsteBod;
            veiling.DoeBod(2000);
            hoogsteBod = veiling.HoogsteBod;
            Assert.AreEqual(hoogsteBod, veiling.HoogsteBod);
        }
    }
}
