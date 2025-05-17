namespace LeetCode.Easy
{
    internal class RomanToInt
    {
        public int RomanToIntFunc(string s)
        {
            int I = 1;
            int V = 5;
            int X = 10;
            int L = 50;
            int C = 100;
            int D = 500;
            int M = 1000;

            int result = 0;

            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];

                if (c == 'M')
                {
                    result += M;
                }
                else if (c == 'D')
                {
                    result += D;
                }
                else if (c == 'C')
                {
                    if ((i < s.Length - 1) && (s[i + 1] == 'M' || s[i + 1] == 'D'))
                    {
                        result -= C;
                    }
                    else { result += C; }
                }
                else if (c == 'L')
                {
                    result += L;
                }
                else if (c == 'X')
                {
                    if ((i < s.Length - 1) && (s[i + 1] == 'C' || s[i + 1] == 'L'))
                    {
                        result -= X;
                    }
                    else { result += X; }
                }
                else if (c == 'V')
                {
                    result += V;
                }
                else if (c == 'I')
                {
                    if ((i < s.Length - 1) && (s[i + 1] == 'X' || s[i + 1] == 'V'))
                    {
                        result -= I;
                    }
                    else { result += I; }
                }
            }
            return result;
        }

        public void TestRomanToInt()
        {
            string s = "III";
            int result = RomanToIntFunc(s);
            Console.WriteLine("Roman number: " + s);
            Console.WriteLine("Result number: " + result);
            Console.WriteLine("Expected number:  3");
            Console.WriteLine(" ");

            string s1 = "LVIII";
            int result1 = RomanToIntFunc(s1);
            Console.WriteLine("Roman number: " + s1);
            Console.WriteLine("Result number: " + result1);
            Console.WriteLine("Expected number:  58");
            Console.WriteLine(" ");

            string s2 = "MCMXCIV";
            int result2 = RomanToIntFunc(s2);
            Console.WriteLine("Roman number: " + s2);
            Console.WriteLine("Result number: " + result2);
            Console.WriteLine("Expected number:  1994");
            Console.WriteLine(" ");

            string s3 = "MCMIX";
            int result3 = RomanToIntFunc(s3);
            Console.WriteLine("Roman number: " + s3);
            Console.WriteLine("Result number: " + result3);
            Console.WriteLine("Expected number:  1909");
            Console.WriteLine(" ");
        }
    }
}
