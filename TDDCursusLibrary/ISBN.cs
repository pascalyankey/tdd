using System;

namespace TDDCursusLibrary
{
    public class ISBN
    {
        private const long GrootsteGetalMet13_Cijfers = 9999999999999L;
        private const long KleinsteGetalMet13_Cijfers = 1000000000000L;
        private long nummer;
        public ISBN(long nummer)
        {
            if (nummer < KleinsteGetalMet13_Cijfers || nummer > GrootsteGetalMet13_Cijfers)
            {
                throw new ArgumentException();
            }

            var somEvenCijfers = 0L;
            var somOnEvenCijfers = 0L;
            var teVerwerkenCijfers = nummer / 10;

            for (int teller = 0; teller != 6; teller++)
            {
                somEvenCijfers += teVerwerkenCijfers % 10;
                teVerwerkenCijfers /= 10;
                somOnEvenCijfers += teVerwerkenCijfers % 10;
                teVerwerkenCijfers /= 10;
            }

            var controleGetal = somEvenCijfers * 3 + somOnEvenCijfers;
            var naastGelegenHoger10Tal = controleGetal - controleGetal % 10 + 10;
            var verschil = naastGelegenHoger10Tal - controleGetal;
            var laatsteCijfer = nummer % 10;

            if (verschil == 10)
            {
                if (laatsteCijfer != 0)
                {
                    throw new ArgumentException();
                }
            }
            else
            {
                if (laatsteCijfer != verschil)
                {
                    throw new ArgumentException();
                }
            }

            this.nummer = nummer;
        }

        public override string ToString()
        {
            return nummer.ToString();
        }
    }
}
