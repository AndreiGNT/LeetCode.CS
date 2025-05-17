using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    internal class ValidParentheses
    {
        public bool IsValid(string s)
        {
            Dictionary<char, char> values = new Dictionary<char, char>()
            {
                {')', '(' },
                {'}', '{' },
                {']', '[' }
            };

            Stack<char> chars = new Stack<char>();

            for (int i = 0; i < s.Length; i++)
            {
                char chr = s[i];
                if (values.ContainsValue(chr))
                    chars.Push(chr);
                else if (chars.Count() > 0 && values[chr] == chars.Peek())
                    chars.Pop();
                else
                      return false;              

            }
            return chars.Count() == 0;
        }

        public void IsValidTest()
        {
            string s = "()[]{}";
            bool result = IsValid(s);
            Console.WriteLine("The parentheses to be cheked: " + s);
            Console.WriteLine("The function answer: " + result);
            Console.WriteLine("The correct answer: true");
            Console.WriteLine(" ");

            string s1 = "()";
            bool result1 = IsValid(s1);
            Console.WriteLine("The parentheses to be cheked: " + s1);
            Console.WriteLine("The function answer: " + result1);
            Console.WriteLine("The correct answer: true");
            Console.WriteLine(" ");

            string s2 = "([])";
            bool result2 = IsValid(s2);
            Console.WriteLine("The parentheses to be cheked: " + s2);
            Console.WriteLine("The function answer: " + result2);
            Console.WriteLine("The correct answer: true");
            Console.WriteLine(" ");

            string s3 = "[([]])";
            bool result3 = IsValid(s3);
            Console.WriteLine("The parentheses to be cheked: " + s3);
            Console.WriteLine("The function answer: " + result3);
            Console.WriteLine("The correct answer: false");
            Console.WriteLine(" ");

            string s4 = "})])])";
            bool result4 = IsValid(s4);
            Console.WriteLine("The parentheses to be cheked: " + s4);
            Console.WriteLine("The function answer: " + result4);
            Console.WriteLine("The correct answer: false");
            Console.WriteLine(" ");

            string s5 = "[";
            bool result5 = IsValid(s5);
            Console.WriteLine("The parentheses to be cheked: " + s5);
            Console.WriteLine("The function answer: " + result5);
            Console.WriteLine("The correct answer: false");
            Console.WriteLine(" ");

            string s6 = "((";
            bool result6 = IsValid(s6);
            Console.WriteLine("The parentheses to be cheked: " + s6);
            Console.WriteLine("The function answer: " + result6);
            Console.WriteLine("The correct answer: false");
            Console.WriteLine(" ");
        }
    }
}
