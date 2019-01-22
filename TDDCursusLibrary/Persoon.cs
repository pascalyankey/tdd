using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace TDDCursusLibrary
{
    public class Persoon
    {
        private static readonly Regex regex = new Regex("^[a-zA-Z]+$");
        private List<string> voornamen;

        public Persoon(List<string> voornamen)
        {
            if (voornamen.Count > 1)
            {
                var teller = 1;

                for (var i = 0; i < voornamen.Count; i++)
                {
                    if (!regex.IsMatch(voornamen[i]))
                        throw new ArgumentException();

                    for (var j = 0; j < voornamen.Count - teller; j++)
                    {
                        if (voornamen[i].ToLower() == voornamen[j + teller].ToLower())
                            throw new ArgumentException();
                    }

                    teller++;
                }
            } else
            {
                foreach (var voornaam in voornamen)
                {
                    if (!regex.IsMatch(voornaam))
                        throw new ArgumentException();
                }
            }

            this.voornamen = voornamen;
        }

        public override string ToString()
        {
            var teller = 0;
            var voornaamBuilder = new StringBuilder();

            foreach (var voornaam in voornamen)
            {
                teller++;
                if (teller == voornamen.Count)
                    voornaamBuilder.Append(voornaam);
                else
                    voornaamBuilder.Append(voornaam + " ");
            }

            return voornaamBuilder.ToString();
        }
    }
}
