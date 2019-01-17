using System.Linq;

namespace TDDCursusLibrary
{
    public class Woord
    {
        public Woord(string woord)
        {
            this.woord = woord;
        }

        private readonly string woord;

        public bool IsPalindroom()
        {
            var omgekeerd = new string (woord.ToArray().Reverse().ToArray());
            return woord == omgekeerd;
        }
    }
}
