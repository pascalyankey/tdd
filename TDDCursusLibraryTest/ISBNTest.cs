using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDCursusLibrary;

namespace TDDCursusLibraryTest
{
    [TestClass]
    public class ISBNTest
    {
        /*private ISBN isbn;
        [TestInitialize] public void Initialize()
        {
            //isbn = new ISBN(9789027439642);
        }*/

        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void HetNummer0IsVerkeerd()
        {
            new ISBN(0);
        }
        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void EenNegatiefNummerIsVerkeerd()
        {
            new ISBN(-9789027439642L);
        }
        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void EenNummerMet12CijfersIsVerkeerd()
        {
            new ISBN(978902743964L);
        }
        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void EenNummerMet14CijfersIsVerkeerd()
        {
            new ISBN(97890274396421L);
        }
        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void EenNummerMet13CijfersMetVerkeerdControleGetal2()
        {
            new ISBN(8789027439642L);
        }
        [TestMethod]
        public void EenNummerMet13CijfersMetCorrectControleGetal2()
        {
            new ISBN(9789027439642L);
        }
        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void EenNummerMet13CijfersMetVerkeerdControleGetal0()
        {
            new ISBN(7789227439640L);
        }
        [TestMethod]
        public void EenNummerMet13CijfersMetCorrectControleGetal0()
        {
            new ISBN(9789227439640L);
        }
    }
}
