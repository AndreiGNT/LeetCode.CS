using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    internal class CountBits
    {
        public int[] CountBitsFunc(int n)
        {
            int[] onesNumber = new int[n + 1];
            int offset = 1;

            for (int i = 1; i <= n; i++)
            {
                if (offset * 2 == i)
                    offset = i;

                onesNumber[i] = 1 + onesNumber[i - offset];
            }

            return onesNumber;
        }

        public void CountBitsTest()
        {
            int n = 10;
            int[] result = CountBitsFunc(n);
            Console.WriteLine("Result: ");
            foreach (int num in result)
            {
                Console.Write(num + " ");
            }

            Console.WriteLine();
            int n1 = 4;
            int[] result1 = CountBitsFunc(n1);
            Console.WriteLine("Result: ");
            foreach (int num in result1)
            {
                Console.Write(num + " ");
            }
        }

        public int[] CountBitsFunc1(int n)
        {
            int[] onesNumber = new int[n + 1];

            for (int i = 0; i <= n; i++)
            {
                string binary = Convert.ToString(i, 2);
                int totalOnes = 0;

                foreach (char value in binary)
                    if (value == '1')
                        totalOnes++;

                onesNumber[i] = totalOnes;
            }

            return onesNumber;
        }
    }
}
