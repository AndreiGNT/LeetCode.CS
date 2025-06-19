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
