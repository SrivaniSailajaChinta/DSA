namespace Reversed_Linked_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public static ListNode ReversedList(ListNode head)
        {
            Stack<int> stack = new Stack<int>();
            while(head != null)
            {
                stack.Push(head.val);
                head = head.next;
            }
            ListNode reveseList = new ListNode(int.MinValue);
            ListNode ptr = reveseList;
            while (stack.Count > 0)
            {
                ptr.next = new ListNode(stack.Pop());
                ptr = ptr.next;
            }

            return reveseList.next;
        }
    }
    /* Definition for singly-linked list. */
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x)
        {
            val = x;
            next = null;
        }
    }

}