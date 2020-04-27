using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace HackerRank
{
    class _2DArrayDS
    {
        public static int getHourGlassSUm(int[][] arr)
        {
            int result=0;
            var sumList = new List<int>();
            for (int i = 0; i < arr.Length - 2; i++)
            {
                for(int j = 1; j < arr[i].Length - 1; j++)
                {
                    result = arr[i][j] + arr[i][j - 1] + arr[i][j + 1] + arr[i + 1][j] + arr[i + 2][j - 1] + arr[i + 2][j] + arr[i + 2][j + 1];
                    sumList.Add(result);
                }
            }
            foreach(int sum in sumList){
                Console.WriteLine("Sum is->" + sum);
            }

            return sumList.Max();
        }
    }
}
