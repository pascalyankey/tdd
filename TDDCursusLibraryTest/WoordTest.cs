using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDCursusLibrary;

namespace TDDCursusLibraryTest
{
    [TestClass]
    public class WoordTest
    {
        [TestMethod]
        public void EenWoordDatHetzelfdeLeestVanBeideRichtingenIsPalindroom()
        {
            Assert.IsTrue(new Woord("lepel").IsPalindroom());
        }

        [TestMethod]
        public void EenWoordDatNietHetzelfdeLeestVanBeideRichtingenIsGeenPalindroom()
        {
            Assert.IsFalse(new Woord("mes").IsPalindroom());
        }
    }
}
