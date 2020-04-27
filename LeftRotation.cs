using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank
{
    class LeftRotation
    {
        public static int[]  leftRotation(int[] a,int d)
        {
            int[] newarr = new int[a.Length];
            int newpos;
            for (int i = 0; i < a.Length; i++)
            {
                if (i - d < 0)
                {
                    newpos = a.Length + (i - d);
                }
                else
                {
                    newpos = i - d;
                }
                newarr[newpos] = a[i];
            }
            return newarr;
        }
    }
}
