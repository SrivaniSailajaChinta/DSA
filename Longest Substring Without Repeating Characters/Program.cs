using System.Text;

namespace Longest_Substring_Without_Repeating_Characters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int lengthOfSubstring = LengthOfLongestSubstring("abcabcbb");
        }

        public static int LengthOfLongestSubstring(string s)
        {
            int maxLength = 0;
           // char[] chars = s.ToCharArray();
            HashSet<char> subarray = new HashSet<char>();
            int leftP=0, rightP=0;
            int length = 0;
            while (rightP< s.Length )
            {
                if (!subarray.Contains(s[rightP]))
                {
                    subarray.Add(s[rightP]);
                    rightP++;                    
                    length = subarray.Count;
                    maxLength = Math.Max(maxLength, length);
                }
                else
                {
                    subarray.Remove(s[leftP]);
                    leftP++;
                    
                }
            } 
            return maxLength;

        }
    }
}