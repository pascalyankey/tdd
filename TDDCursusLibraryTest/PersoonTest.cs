using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDCursusLibrary;

namespace TDDCursusLibraryTest
{
    [TestClass]
    public class PersoonTest
    {
        [TestMethod]
        public void EenPersoonMet1VoornaamUitMinstens1NonWhiteSpaceIsOk()
        {
            new Persoon(new List<string> { "P" });
        }

        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void EenPersoonMet1VoornaamUitNietMinstens1NonWhiteSpaceIsNietOk()
        {
            new Persoon(new List<string> { " " });
        }

        [TestMethod]
        public void EenPersoonMet1VoornaamUitAlfabetIsOk()
        {
            new Persoon(new List<string> { "Pascal" });
        }

        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void EenPersoonMet1VoornaamUitNumeriekIsNietOk()
        {
            new Persoon(new List<string> { "123" });
        }

        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void EenPersoonMet1VoornaamUitAlfanumeriekIsNietOk()
        {
            new Persoon(new List<string> { "P4scal" });
        }

        [TestMethod]
        public void EenPersoonMet2VerschillendeVoornamenMetBeideUitMinstens1NonWhiteSpaceIsOk()
        {
            new Persoon(new List<string> { "P", "Y" });
        }

        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void EenPersoonMet2DezelfdeVoornamenMetBeideUitMinstens1NonWhiteSpaceIsNietOk()
        {
            new Persoon(new List<string> { "P", "P" });
        }

        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void EenPersoonMet2VerschillendeVoornamenMetEnkel1VoornaamUitMinstens1NonWhiteSpaceIsNietOk()
        {
            new Persoon(new List<string> { "P", " " });
        }

        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void EenPersoonMet2VoornamenMetBeideNietUitMinstens1NonWhiteSpaceIsNietOk()
        {
            new Persoon(new List<string> { " ", " " });
        }

        [TestMethod]
        public void EenPersoonMet2VerschillendeVoornamenMetBeideUitAlfabetIsOk()
        {
            new Persoon(new List<string> { "Pascal", "Jude" });
        }

        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void EenPersoonMet2VerschillendeVoornamenMet1VoornaamUitNumeriekIsNietOk()
        {
            new Persoon(new List<string> { "Pascal", "123" });
        }

        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void EenPersoonMet2VerschillendeVoornamenMet1VoornaamUitAlfanumeriekIsNietOk()
        {
            new Persoon(new List<string> { "Pascal", "Jud3" });
        }

        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void EenPersoonMet2VerschillendeVoornamenMetBeideUitNumeriekIsNietOk()
        {
            new Persoon(new List<string> { "123", "321" });
        }

        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void EenPersoonMet2VerschillendeVoornamenMetBeideUitAlfanumeriekIsNietOk()
        {
            new Persoon(new List<string> { "P4scal", "Jud3" });
        }

        [TestMethod]
        public void EenPersoonMetMeerDan2VerschillendeVoornamenMetAllemaalUitMinstens1NonWhiteSpaceIsOk()
        {
            new Persoon(new List<string> { "P", "J", "G", "S" });
        }

        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void EenPersoonMetMeerDan2VoornamenMet2DezelfdeVoornaamUitMinstens1NonWhiteSpaceIsOk()
        {
            new Persoon(new List<string> { "P", "J", "G", "P" });
        }

        [TestMethod]
        public void ToStringMethodKomtOvereenMetVoornamen()
        {
            Assert.AreEqual("Pascal Jude", new Persoon(new List<string> { "Pascal", "Jude" }).ToString());
        }

        [TestMethod]
        public void ToStringMethodKomtNietOvereenMetVoornamen()
        {
            Assert.AreNotEqual("Pascal Jude Grace", new Persoon(new List<string> { "Pascal", "Jude" }).ToString());
        }
    }
}
