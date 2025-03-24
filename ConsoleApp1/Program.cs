namespace RemoveDuplicates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 1, 2};
            Console.WriteLine("Hello, World!");
            int k = RemoveDuplicates(nums);
        }

        public static int RemoveDuplicates(int[] nums)
        {
            //string[] expectedArray = new string[nums.Length];
            //int duplicateCount = 0;
            //int k = 0;
            if (nums.Length == 0)
                return 0;
            int uniqueNums = 1;
            for (int i=1; i < nums.Length; i++)
            {
                if (nums[i] != nums[i - 1])
                {
                    nums[uniqueNums] = nums[i];
                    uniqueNums++;
                }   
            }
            
            return uniqueNums;
        }
    }
}