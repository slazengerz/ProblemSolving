using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank
{
    class CountingValleys
    {
        public static int CountValleys(string input)
        {
            int result = 0;
            int lvl = 0;
            char[] charArr = input.ToCharArray();
            foreach(char c in charArr) {
                if (c.ToString()=="D")
                {
                    if (lvl == 0)
                    {
                        result += 1;
                    }
                    lvl += -1;
                }
                else
                {
                    lvl += 1;
                }
            }
            return result;
        }
    }
}
