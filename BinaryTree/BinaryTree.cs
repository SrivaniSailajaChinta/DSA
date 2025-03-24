using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public class Node
    {
        Node left, right;
        int data;

      public Node(int value)
        {
            this.data = value;            
        }

        public void insert(int value)
        {
            if(value < data)
            {
                if(left == null)
                {
                    left = new Node(value);
                }
                else
                {
                    left.data = value;
                }
            }
            else
            {
                if(right == null)
                {
                    right = new Node(value);
                }
                else
                {
                    right.data = value;
                }

            }
        }

        public bool Contains(int value)
        {
            if(value == data)
            {
                return true;
            }
            else if(value<data)
            {
                if(left == null)
                {
                    return false;
                }
                else 
                { 
                    return left.Contains(value); 
                }
            }
            else
            {
                if (right == null)
                {
                    return false;
                }
                else 
                {
                    return right.Contains(value);
                }
            }
            
        }

        public void InOrderPrint()
        {
            if (left != null)
            {
                left.InOrderPrint();
            }
            Console.WriteLine(data);
            if(right != null)
            {
                right.InOrderPrint();
            }
        }

        public void PreOrderPrint()
        {
            Console.WriteLine(data);
            if (left != null)
            {
                left.InOrderPrint();
            }
            if (right != null)
            {
                right.InOrderPrint();
            }
        }

        public void PostOrderPrint()
        {
            if (left != null)
            {
                left.InOrderPrint();
            }
            if (right != null)
            {
                right.InOrderPrint();
            }
            Console.WriteLine(data);
           
        }
    }
}
