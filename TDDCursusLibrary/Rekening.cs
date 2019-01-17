using System;

namespace TDDCursusLibrary
{
    public class Rekening
    {
        private decimal saldo;

        public void Storten(decimal bedrag)
        {
            saldo += bedrag;
        }

        public decimal Saldo
        {
            get
            {
                return saldo;
            }
        }
    }
}
