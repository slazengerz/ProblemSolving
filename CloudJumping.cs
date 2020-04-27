using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank
{
    class CloudJumping
    {
        public static int minCloudToJump(int[] arr)
        {
            //{0,1,0,1,0,0};
            int result = 0;
            int startingpos = Array.FindIndex(arr, s => s == 0);
            while (startingpos < arr.Length-1){
                result++;
                if ((startingpos + 2)<arr.Length && arr[startingpos + 2] == 0){
                    startingpos += 2;
                    continue;
                }
                startingpos += 1;
            }
            return result;
        }
    }
}
