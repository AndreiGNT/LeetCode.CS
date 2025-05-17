namespace LeetCode.Easy
{
    internal class LongestCommonPrefix
    {
        public string LongestCommonPrefixFunc(string[] strs)
        {
            string prefix = "";

            for (int i = 0; i < strs.Length; i++)
            {
                if (string.IsNullOrEmpty(prefix) && i == 0)
                {
                    prefix = strs[i];
                    continue;
                }
                string curentStr = strs[i];

                if (prefix.Length > curentStr.Length)
                {
                    prefix = prefix.Remove(curentStr.Length);
                }

                for (int j = 0; j < curentStr.Length; j++)
                {
                    if (prefix.Length > j && curentStr[j] != prefix[j])
                    {
                        prefix = prefix.Remove(j);
                        break;
                    }
                }
            }
            return prefix;
        }

        public void LongestCommonPrefixTest()
        {
            string[] strs = ["flower", "flow", "flight"];
            string resultPrefix = LongestCommonPrefixFunc(strs);
            Console.WriteLine("The longest common prefix: " + resultPrefix);
            Console.WriteLine("The correct answer: 'fl'");
            Console.WriteLine(" ");

            string[] strs1 = ["dog", "racecar", "car"];
            string resultPrefix1 = LongestCommonPrefixFunc(strs1);
            Console.WriteLine("The longest common prefix: " + resultPrefix1);
            Console.WriteLine("The correct answer: ''");
            Console.WriteLine(" ");

            string[] strs2 = ["flower", "flow"];
            string resultPrefix2 = LongestCommonPrefixFunc(strs2);
            Console.WriteLine("The longest common prefix: " + resultPrefix2);
            Console.WriteLine("The correct answer: 'flow'");
            Console.WriteLine(" ");
        }
    }
}
