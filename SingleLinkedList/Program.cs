namespace SingleLinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        
        public bool IsPalindrome(ListNode head)
        {
            List<int> arr = new List<int>();
            while (head != null)
            {
                arr.Add(head.val);
                head = head.next;
            }
            int[] ints = arr.ToArray();
            int leftP =0;
            int rightP = ints.Length-1;
            while(leftP <= rightP)
            {
                if (ints[leftP] != ints[rightP])
                {
                    return false;
                }
                leftP++;
                rightP--;
            }
            return true;
        }
    }

   
 // Definition for singly-linked list.//
  public class ListNode {
      public int val;
     public ListNode next;
      public ListNode(int val=0, ListNode next=null) {
          this.val = val;
          this.next = next;
      }
  }
 
}