namespace MinMaxSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            List<long> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt64(arrTemp)).ToList();
            miniMaxSum(arr);
        }

        public static void miniMaxSum(List<long> arr)
        {
            long minsum, maxsum = 0;
            arr.Sort();
            minsum = arr[0]+ arr[1]+ arr[2]+ arr[3];
            maxsum = arr[1] + arr[2] + arr[3]+ arr[4];
            Console.WriteLine(minsum + " " + maxsum);
        }
    }
}