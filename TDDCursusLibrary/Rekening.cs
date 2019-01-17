using System;

namespace TDDCursusLibrary
{
    public class Rekening
    {
        private decimal saldo;

        public void Storten(decimal bedrag)
        {
            if (bedrag <= decimal.Zero)
            {
                throw new ArgumentException();
            }

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
