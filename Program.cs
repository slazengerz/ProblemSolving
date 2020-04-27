using System;
using System.Linq;

namespace HackerRank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter no of records");
            //sock merchant problem
            //SockMerchant.sockMerchant_input();
            //Counting valleys problem
            // int countValleysResult=CountingValleys.CountValleys("UDDDUDUUDDUU");
            //Console.WriteLine(countValleysResult);
            //int[] input = new int[] {0,1,0,0,1,0};
            //int cloudJumpResult=CloudJumping.minCloudToJump(input);
            //Console.WriteLine(cloudJumpResult);'
            //getInputFor2DArray();
            //leftRotation();
            //long result = RepeatedString.repeatedString("a", 100000000000);
            //Console.WriteLine("result->" + result);
            NewYearChaos.minimumBribes(new int[] { 1,2,5,3,7,8,6,4 });
            //{ 1,2,3,4,5,6,7,8 }
            //--{1,2,5,3,4,6,7,8}--2
            //--{1,2,5,3,7,4,6,8}--2
            //--{1,2,5,3,7,8,4,6}--2
            //{ 1,2,5,3,7,8,6,4 }   5326q5 xs
        }

        private static void leftRotation()
        {
            int[] input = new int[] { 1, 2, 3, 4, 5 };
            int[] result = LeftRotation.leftRotation(input,4);
            foreach(int i in result)
            {
                Console.WriteLine(i);
            }
        }

        private static void getInputFor2DArray()
        {
            int[][] input = new int[4][];
            for(int i = 0; i < input.Length; i++)
            {
                input[i] = Array.ConvertAll(Console.ReadLine().Split(" "), 
                            arrEl => Convert.ToInt32(arrEl));
            }
            int result = _2DArrayDS.getHourGlassSUm(input);

            //foreach (int[] i in input)
            //{
            //    Console.WriteLine(String.Join(",",i));
            //}
        }
    }
}
