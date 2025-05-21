using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    internal class StrStr
    {
        public int StrStrFunc(string haystack, string needle)
        {
            int l1 = haystack.Length;
            int l2 = needle.Length;

            for (int i = 0; i <= l1 - l2; i++)
            {
                if (haystack[i] == needle[0])
                {
                    bool check = true;
                    for (int j = 1; j < l2; j++)
                    {
                        if (haystack[i + j] != needle[j])
                        {
                            check = false;
                            break;
                        }
                    }
                    if (check) return i;
                }
            }
            return -1;
        }

        public void StrStrTest()
        {
            string haystack = "mississippi";
            string needle = "issip";
            int result = StrStrFunc(haystack, needle);
            Console.WriteLine("haystack =" + haystack + "\nneedle = " + needle);
            Console.WriteLine("The starting position is: " + result);
            Console.WriteLine("The correct answer is: 4");
            Console.WriteLine("");

            string haystack1 = "leetcode";
            string needle1 = "leeto";
            int result1 = StrStrFunc(haystack1, needle1);
            Console.WriteLine("haystack =" + haystack1 + "\nneedle = " + needle1);
            Console.WriteLine("The starting position is: " + result1);
            Console.WriteLine("The correct answer is: -1");
            Console.WriteLine("");

            string haystack2 = "qwertasdyuio";
            string needle2 = "asd";
            int result2 = StrStrFunc(haystack2, needle2);
            Console.WriteLine("haystack =" + haystack2 + "\nneedle = " + needle2);
            Console.WriteLine("The starting position is: " + result2);
            Console.WriteLine("The correct answer is: 5");
            Console.WriteLine("");

            string haystack3 = "sadbutsad";
            string needle3 = "sadbutsadsad";
            int result3 = StrStrFunc(haystack3, needle3);
            Console.WriteLine("haystack =" + haystack3 + "\nneedle = " + needle3);
            Console.WriteLine("The starting position is: " + result3);
            Console.WriteLine("The correct answer is: -1");
            Console.WriteLine("");

            string haystack4 = "sasasasasasadsad";
            string needle4 = "sad";
            int result4 = StrStrFunc(haystack4, needle4);
            Console.WriteLine("haystack =" + haystack4 + "\nneedle = " + needle4);
            Console.WriteLine("The starting position is: " + result4);
            Console.WriteLine("The correct answer is: 10");
            Console.WriteLine("");
        }
    }
}
