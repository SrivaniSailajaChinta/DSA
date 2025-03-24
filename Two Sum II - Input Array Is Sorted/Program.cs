namespace Two_Sum_II___Input_Array_Is_Sorted
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int[] nums = { 2, 3,4 };
            int[] k = TwoSum(nums, 6);
        }

        //time complexisity - O(n)
        private static int[] TwoSum(int[] nums, int target)
        {
            int leftP = 0;
            int rightP = nums.Length - 1;
            while(leftP< rightP)
            {
                if (nums[leftP] +nums[rightP] > target)
                {
                    rightP--;
                }
                else if (nums[leftP] + nums[rightP] < target)
                {
                    leftP++;
                }
                else
                {
                    return new int[]{ leftP + 1, rightP + 1 };
                }
            }
            return new int[2];

        }

        //time complexisity - O(n2)
        //public static int[] TwoSum(int[] numbers, int target)
        //{

        //    int[] indexArray = new int[2];
        //    int k = 0;
        //    for (int i=0; i<numbers.Length-1; i++)
        //    {               
        //        for(int j = i+1; j < numbers.Length; j++)
        //        {
        //            int sum = 0;
        //            sum = numbers[i] + numbers[j];
        //            if(sum == target)
        //            {
        //                indexArray[0] = i + 1;
        //                indexArray[1] = j + 1;
        //                k = 1;
        //                break;
        //            }
        //        }
        //        if (k == 1)
        //        {
        //            break;
        //        }

        //    }
        //    return indexArray;
        //}
    }
}