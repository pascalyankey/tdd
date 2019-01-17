using System;

namespace TDDCursusLibrary
{
    public class Veiling
    {
        private decimal hoogsteBodValue;
        public decimal HoogsteBod
        {
            get
            {
                return hoogsteBodValue;
            }
        }

        public void DoeBod(decimal bedrag)
        {
            if (bedrag > HoogsteBod)
                hoogsteBodValue = bedrag;
        }
    }
}
