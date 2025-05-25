using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    internal class DeleteDuplicates
    { 
           
          // Definition for singly-linked list.
          public class ListNode {
              public int val;
              public ListNode next;
              public ListNode(int val=0, ListNode next=null) {
                  this.val = val;
                  this.next = next;
              }
          }
          
        public ListNode DeleteDuplicatesFunc(ListNode head)
        {
            ListNode curentItem = head;

            while (curentItem != null && curentItem.next != null)
            { 
                if (curentItem.val == curentItem.next.val)
                    curentItem.next = curentItem.next.next;
                else 
                    curentItem = curentItem.next;
            }
            return head;
        }

        public void DeleteDuplicatesTest()
        {
            ListNode head = new ListNode(1);
            head.next = new ListNode(1);
            head.next.next = new ListNode(1);
            head.next.next.next = new ListNode(2);
            ListNode headTest = head;
            while (head != null)
            {
                Console.WriteLine(head.val);
                head = head.next;
            }
            Console.WriteLine();

            ListNode listNode = DeleteDuplicatesFunc(headTest);
            while (listNode != null)
            {
                Console.WriteLine(listNode.val);
                listNode = listNode.next;
            }
            
        }
    }
}
