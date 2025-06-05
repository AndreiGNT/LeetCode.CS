namespace LeetCode.Easy
{
    internal class IsPalindromeFrase
    {
        public bool IsPalindrome(string s)
        {
            int leftIdx = 0;
            int rightIdx = s.Length - 1;

            while (leftIdx < rightIdx)
            { 
                if (!char.IsLetterOrDigit(s[leftIdx]))
                    leftIdx++;
                else if (!char.IsLetterOrDigit(s[rightIdx]))
                    rightIdx--;
                else
                {
                    if (char.ToLower(s[leftIdx]) != char.ToLower(s[rightIdx]))
                        return false;

                    leftIdx++;
                    rightIdx--;
                }
            }
            return true;
        }

        public void IsPalindromeTest()
        {
            string s = "A man, a plan, a canal: Panama";
            bool result = IsPalindrome(s);
            Console.WriteLine("Tested string: " + s);
            Console.WriteLine("Is palindrome: " + result);
            Console.WriteLine();

            string s1 = " ";
            bool result1 = IsPalindrome(s1);
            Console.WriteLine("Tested string: " + s1);
            Console.WriteLine("Is palindrome: " + result1);
            Console.WriteLine();

            string s2 = "race a car";
            bool result2 = IsPalindrome(s2);
            Console.WriteLine("Tested string: " + s2);
            Console.WriteLine("Is palindrome: " + result2);
            Console.WriteLine();

            string s3 = "0P";
            bool result3 = IsPalindrome(s3);
            Console.WriteLine("Tested string: " + s3);
            Console.WriteLine("Is palindrome: " + result3);
            Console.WriteLine();
        }
    }
}
