using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    internal class LengthOfLastWord
    {
        public int LengthOfLastWordFunc(string s)
        {
            int lengthOfLastWord = 0;

            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (s[i] != ' ')
                {
                    while (i >= 0 && s[i] != ' ')
                    {
                        lengthOfLastWord++;
                        i--;
                    }
                    return lengthOfLastWord;
                }
            }
            return lengthOfLastWord;
        }

        public void LengthOfLastWordTest()
        {
            string s = "Hello World";
            int result = LengthOfLastWordFunc(s);
            Console.WriteLine("The input string: " + s);
            Console.WriteLine("The length of the last word: " + result);
            Console.WriteLine("The correct answer: 5");
            Console.WriteLine();

            string s1 = "  j j n mn l    ";
            int result1 = LengthOfLastWordFunc(s1);
            Console.WriteLine("The input string: " + s1);
            Console.WriteLine("The length of the last word: " + result1);
            Console.WriteLine("The correct answer: 1");
            Console.WriteLine();

            string s2 = "        ";
            int result2 = LengthOfLastWordFunc(s2);
            Console.WriteLine("The input string: " + s2);
            Console.WriteLine("The length of the last word: " + result2);
            Console.WriteLine("The correct answer: 0");
            Console.WriteLine();
        }
    }
}
