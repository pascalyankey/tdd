using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDCursusLibrary;
using Moq;

namespace TDDCursusLibraryTest
{
    [TestClass]
    public class WinstServiceTest
    {
        private Mock<IOpbrengstDAO> mockOpbrengstDAO;
        private Mock<IKostDAO> mockKostDAO;
        private IOpbrengstDAO opbrengstDAO;
        private IKostDAO kostDAO;
        private WinstService winstService;

        [TestInitialize]
        public void Initialize()
        {
            mockOpbrengstDAO = new Mock<IOpbrengstDAO>();
            mockKostDAO = new Mock<IKostDAO>();
            opbrengstDAO = mockOpbrengstDAO.Object;
            kostDAO = mockKostDAO.Object;
            mockOpbrengstDAO.Setup(eenOpbrengstDAO => eenOpbrengstDAO.TotaleOpbrengst()).Returns(60);
            mockKostDAO.Setup(eenKostDAO => eenKostDAO.TotaleKost()).Returns(30);
            winstService = new WinstService(opbrengstDAO, kostDAO);
        }

        [TestMethod]
        public void WinstIsTotaleOpbrengstMinTotaleKost()
        {
            Assert.AreEqual(30, opbrengstDAO.TotaleOpbrengst() - kostDAO.TotaleKost());
            mockOpbrengstDAO.Verify(eenOpbrengstDAO => eenOpbrengstDAO.TotaleOpbrengst());
            mockKostDAO.Verify(eenKostDAO => eenKostDAO.TotaleKost());
        }
    }
}
