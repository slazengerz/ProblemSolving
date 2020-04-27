using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank
{
    class NewYearChaos
    {
        public static void minimumBribes(int[] q)
        {
            int minBribes = 0;
            string chaos = "";
            int temp = 0;
            int initialpos = 0;
            int currpos = 0;
            for(int i = 0; i < q.Length; i++)
            {
                if(q[i]-(i+1) > 2)
                {
                    chaos = "Too chaotic";
                    break;
                }
                temp = q[i];
                initialpos = q[i] - 2;
                currpos = i;
                for(int j=Math.Max(0, initialpos); j < i; j++)
                {
                    if (temp < q[j])
                    {
                        minBribes++;
                    }
                }
            }
            
            if (String.IsNullOrEmpty(chaos))
            {
                Console.WriteLine(minBribes);
                return;
            }
            Console.WriteLine(chaos);
        }
    }
}
