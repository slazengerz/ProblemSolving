using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank
{
    class SockMerchant
    {
        public static void sockMerchant_input()
        {
            int records = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the number array");
            String inputStr = Console.ReadLine();
            int[] input = Array.ConvertAll<String, int>(inputStr.Split(" "),
                            arrtemp => Convert.ToInt32(arrtemp));
            foreach (int i in input)
            {
                Console.WriteLine(i);
            }
            int result = sockMerchant(records, input);
            Console.WriteLine("Result is ->" + result);
        }

        private static int sockMerchant(int records, int[] input)
        {
            int result = 0;
            Array.Sort(input);
            for (int i = 0; i < input.Length - 1; i++)
            {
                if (input[i] == input[i + 1])
                {
                    result += 1;
                    i += 1;
                }
            }
            return result;

        }
    }
}
