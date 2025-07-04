using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    internal class MiddleNode
    {
        public ListNode MiddleNodeFunc(ListNode head)
        {
            ListNode fast = head;
            while (fast != null && fast.next != null)
            {
                head = head.next;
                fast = fast.next.next;
            }

            return head;
        }
    }
}
