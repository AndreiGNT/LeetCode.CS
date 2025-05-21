using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    internal class PlusOne
    {
        public int[] PlusOneFunc(int[] digits)
        {
            if (digits[digits.Length - 1] != 9)
            {
                digits[digits.Length - 1]++;
                return digits;
            }

            for (int i = digits.Length - 1; i >= 0; i--)
            {

                if (digits[i] != 9)
                {
                    digits[i]++;
                    return digits;
                }
                else
                {
                    digits[i] = 0;
                }
            }
      
            int[] digitsPlusOne = new int[digits.Length + 1];
            digitsPlusOne[0] = 1;

            return digitsPlusOne;
        }

        public void PlusOneTest()
        {
            int[] digits = [9,9,9,9,9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9,9,9,9,9, 9, 9, 9, 9, 9];
            int[] result = PlusOneFunc(digits);
            Console.WriteLine();
            Console.Write("Result: ");
            for (int i = 0; i < result.Length; i++)
            {
                Console.Write(result[i] + " ");
            }

            int[] digits1 = [9,9,9,8,9];
            int[] result1 = PlusOneFunc(digits1);
            Console.WriteLine();
            Console.Write("Result: ");
            for (int i = 0; i < result1.Length; i++)
            {
                Console.Write(result1[i] + " ");
            }

            int[] digits2 = [1,2,3,4];
            int[] result2 = PlusOneFunc(digits2);
            Console.WriteLine();
            Console.Write("Result: ");
            for (int i = 0; i < result2.Length; i++)
            {
                Console.Write(result2[i] + " ");
            }
        }
    }
}
