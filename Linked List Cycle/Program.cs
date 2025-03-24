using static System.Net.WebRequestMethods;

namespace Linked_List_Cycle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            ListNode listNode = new ListNode(1);
            Console.WriteLine(HasCycle(listNode));
        }

        public static bool HasCycle(ListNode head)
        {
            var fastP = head;
            var slowP = head;
            while (fastP != null && slowP != null && fastP.next != null)
            {
                fastP = fastP.next.next;
                slowP = slowP.next;
                if (fastP == slowP)
                {
                    return true;
                }
            }
            return false;
        }
    }

    /* Definition for singly-linked list. */
  public class ListNode {
      public int val;
      public ListNode next;
      public ListNode(int x) {
          val = x;
          next = null;
      }
  }

}