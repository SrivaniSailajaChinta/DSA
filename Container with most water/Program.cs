namespace Container_with_most_water
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int k = MaxArea(new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 });
        }
        public static int MaxArea(int[] height)
        {
            int maxArea = 0;
            int leftP = 0;
            int rightP = height.Length - 1;
            while(leftP < rightP)
            {
                int area = (rightP - leftP) * Math.Min(height[leftP], height[rightP]);
                maxArea = Math.Max(maxArea, area);
                if (height[leftP] < height[rightP])
                {
                    leftP++;
                }
                else
                {
                    rightP--;
                }

            }
            return maxArea;
        }
    }
}