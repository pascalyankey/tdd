namespace TDDCursusLibrary
{
    public class WinstService
    {
        private readonly IOpbrengstDAO opbrengstDAO;
        private readonly IKostDAO kostDAO;
        public WinstService(IOpbrengstDAO opbrengstDAO, IKostDAO kostDAO)
        {
            this.opbrengstDAO = opbrengstDAO;
            this.kostDAO = kostDAO;
        }
        public decimal Winst
        {
            get
            {
                return opbrengstDAO.TotaleOpbrengst() - kostDAO.TotaleKost();
            }
        }
    }
}
