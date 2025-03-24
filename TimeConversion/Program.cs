namespace TimeConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
          //  TextWriter textWriter = new StreamWriter(Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string s = Console.ReadLine();

            string result = timeConversion(s);

            Console.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
        }

        public static string timeConversion(string s)
        {
            //s=07:05:45PM
            string am_pm = s.Substring(08, 2);
            if (am_pm == "AM")
            {
                string hh = s.Substring(0, 2);
                if ( hh == "12")
                {
                   s= s.Replace(s.Substring(0, 2), "00");
                  
                }
                s = s.Remove(s.Length - 2, 2);
            }
            else
            {
                int hh = Convert.ToInt32(s.Substring(0, 2));
                int mm = Convert.ToInt32(s.Substring(3, 2));
                int ss = Convert.ToInt32(s.Substring(6, 2));
                if ((mm > 0 || ss > 0) && hh ==12)
                {
                    s = s.Replace(s.Substring(0, 2), "12");
                }
                else
                {
                    hh = hh + 12;
                    s = s.Replace(s.Substring(0, 2), hh.ToString());                    
                }
                s = s.Remove(s.Length - 2, 2);
            }
            return s;
        }

    }
}