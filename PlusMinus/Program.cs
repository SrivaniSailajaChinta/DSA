namespace PlusMinus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            plusMinus(arr);
        }

        public static void plusMinus(List<int> arr)
        {
            double neg = 0.000000;
            double pos = 0.000000;
            double zeros = 0.000000;
            for (int i = 0; i <= arr.Count - 1; i++)
            {
                if (arr[i] < 0)
                {
                    neg = neg + arr[i];
                }
                else if (arr[i] > 0)
                {
                    pos = pos + arr[i];
                }
                else
                {
                    zeros = zeros + arr[i];
                }
            }
            Console.WriteLine(((double)pos / arr.Count).ToString("0.000000"));           
            Console.WriteLine(((double)neg / arr.Count).ToString("0.000000"));
            Console.WriteLine(((double)zeros / arr.Count).ToString("0.000000"));


        }

    }
}