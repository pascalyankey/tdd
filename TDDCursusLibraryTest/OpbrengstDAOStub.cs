using TDDCursusLibrary;

namespace TDDCursusLibraryTest
{
    public class OpbrengstDAOStub : IOpbrengstDAO
    {
        public decimal TotaleOpbrengst()
        {
            return 60;
        }
    }
}
