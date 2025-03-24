namespace Subarray_Sum_Equals_K
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int[] nums = { 1, 2, 3 };
           int k= SubarraySum(nums,3);
        }
        public static int SubarraySum(int[] nums, int k)
        {
            int subarraycount = 0;            
            for(int i=0; i<nums.Length; i++)
            {
                int sum = 0;
                int j = i;
                while(j< nums.Length)
                {
                    sum = sum + nums[j];
                    if (sum == k)
                    {
                        subarraycount++;
                    }
                    j++;
                }
            }
            return subarraycount;
        }
    }
}
