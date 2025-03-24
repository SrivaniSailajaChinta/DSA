namespace BinarySearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine(BinarySearchNum(new int[] {1,2,3,4,5,6,7,8,9},10));
            Console.ReadLine();
        }

        public static bool BinarySearchNum(int[] nums,int target)
        {
            int left = 0;
            int right = nums.Length - 1;
            while(left <= right) 
            { 
                int mid = (left + right) / 2;
                if (nums[mid] == target) {
                    return true;                
                }
                if (nums[mid] < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }

            }
            return false;
        }
    }
}