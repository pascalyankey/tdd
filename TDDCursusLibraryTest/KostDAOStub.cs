using TDDCursusLibrary;

namespace TDDCursusLibraryTest
{
    public class KostDAOStub : IKostDAO
    {
        public decimal TotaleKost()
        {
            return 30;
        }
    }
}
