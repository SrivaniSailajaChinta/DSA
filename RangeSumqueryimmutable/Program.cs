using System.Globalization;

namespace RangeSumqueryimmutable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public class NumArray
    {
        int[] nums;
        public NumArray(int[] nums)
        {
            this.nums = nums;
        }

        public int SumRange(int left, int right)
        {
            int sum = 0;
            while (left <= right)
            {
                sum = nums[left];
                left = left + 1;
            }
            return sum;
        }
    }

}