using System.Collections;

namespace LonelyInteger
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();
            Console.WriteLine(lonelyinteger(a));
        }

        //public static int lonelyinteger(List<int> a)
        //{
        //   Hashtable hashtable = new Hashtable();
        //    for(int i = 0; i < a.Count; i++)
        //    {
        //        if (hashtable.ContainsKey(a[i]))
        //        {
        //            hashtable[a[i]] = 2;
        //        }
        //        else
        //        {
        //            hashtable.Add(a[i], 1);
        //        }
                
        //    }

        //    foreach (var key in hashtable.Keys)
        //    {
        //        if ((int)hashtable[key] == 1)
        //        {
        //            return (int)key;
        //        }
        //    }
        //    return 1;
        //}

        public static int lonelyinteger(List<int> a)
        {
            HashSet<int> set = new HashSet<int>();    
            for(int i=0; i<a.Count; i++)
            {
                if (set.Contains(a[i]))
                {
                    set.Remove(a[i]);
                }
                else
                {
                    set.Add(a[i]);
                }
            }
            return set.FirstOrDefault();
        }
    }
}