using System.Linq;

namespace TwoSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int[] k = TwoSum(new int[] { 1, 1, 1, 1, 1, 4, 1, 1, 1, 1, 1, 7, 1, 1, 1, 1, 1 }, 11);
            Console.WriteLine("[" + k[0] + "][" + k[1]+"]");
            Console.ReadLine();
        }
        public static int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int,int> hashtabl = new Dictionary<int,int>();
            for(int i=0;i<nums.Length; i++)
            {
               int comp = target - nums[i];
                if (hashtabl.ContainsValue(comp))
                {
                    return new int[] { hashtabl.Keys.FirstOrDefault(x => hashtabl[x]==comp),i };
                }
                else
                {
                    hashtabl.Add(i, nums[i]);
                }
            }
            return new int[2] ;
        }
    }
}