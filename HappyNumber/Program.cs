namespace HappyNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(IsHappy(62));
            Console.WriteLine(IsHappy(19));
            Console.ReadLine();

        }

        public static bool IsHappy(int n)
        {
            Stack<int> nums = new Stack<int>();
           
            while (true)
            {
                int sum = 0;
                while (n != 0)
                {
                    sum = (int)(sum + Math.Pow((int)n%10,2));
                    n = n / 10;
                }

                if (sum == 1)
                {
                    return true;
                }
                n = sum;
                if(nums.Contains(n))
                {
                    return false;
                    
                }
                nums.Push(n);

            }
        }
    }
}