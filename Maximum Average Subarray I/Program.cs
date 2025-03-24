namespace Maximum_Average_Subarray_I
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
           double k = FindMaxAverage(new int[] { 0, 4, 0, 3, 2 }, 1);
            Console.WriteLine(k);
            Console.ReadLine();
        }
        public static double FindMaxAverage(int[] nums, int k)
        {
            double maxarea = 0;
            int curr_sum = 0;
            for(int i=0; i<k;i++)
            {
                curr_sum = curr_sum + nums[i];
            }
            maxarea = (double)curr_sum / k;
            for(int i=k; i < nums.Length; i++)
            {
                curr_sum = curr_sum + nums[i];
                curr_sum = curr_sum - nums[i - k];
                double area = (double)curr_sum / k;
                maxarea = Math.Max(maxarea, area);

            }
         
            return (double)maxarea;
        }
    }
}