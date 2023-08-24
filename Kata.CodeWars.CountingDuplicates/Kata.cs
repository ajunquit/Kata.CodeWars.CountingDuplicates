using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.CodeWars.CountingDuplicates
{
    public class Kata
    {
        public static int DuplicateCount(string str)
        {
            var characters = str.ToLower().ToArray();
            var pivots = str.ToLower().ToArray().Distinct();
            int i = 0;
            foreach (char pivot in pivots)
            {
                var exist = characters.Where(characer => characer == pivot).Count() >= 2;
                if (exist)
                    i++;
            }
            return i;
        }
    }
}
