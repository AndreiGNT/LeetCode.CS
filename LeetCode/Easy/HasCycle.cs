using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    //public class ListNode
    //{
    //    public int val;
    //    public ListNode next;
    //    public ListNode(int x)
    //    {
    //        this.val = x;
    //        this.next = null;
    //    }
    //}
    internal class HasCycle
    {
        public bool HasCycleFunc(ListNode head)
        {
            ListNode pointerFast = head;
            while (pointerFast != null && pointerFast.next != null) 
            {
                head = head.next;
                pointerFast = pointerFast.next.next;

                if (head == pointerFast)
                    return true;
            }
            return false;
        }

        public void HasCycleTest()
        {
            ListNode list1 = new ListNode(1);
            list1.next = new ListNode(2);
            list1.next.next = new ListNode(5);
            list1.next.next.next = new ListNode(10);
            list1.next.next.next.next = new ListNode(10);

            Console.WriteLine();
            bool result = HasCycleFunc(list1);
            Console.WriteLine("Result: " + result);
        }
    }
}
