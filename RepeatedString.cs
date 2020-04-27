using System;
using System.Linq;

namespace HackerRank
{
    class RepeatedString
    {
        public static long repeatedString(String s,long n)
        {
            int initial = s.Count(s => s.Equals('a'));
            int postadding=s.Substring(0, Convert.ToInt16(n % s.Length)).Count(s => s.Equals('a'));
            long result = initial * (n / s.Length) + postadding;
            return result;
        }

    }
}
