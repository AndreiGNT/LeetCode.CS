using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    //Definition for singly-linked list.
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
    internal class MergeTwoLists
    {
        public ListNode MergeTwoListsFunc(ListNode list1, ListNode list2)
        {
            var dummyNode = new ListNode();
            var tail = dummyNode;

            while (list1 != null && list2 != null)
            {
                if (list1.val < list2.val)
                {
                    tail.next = list1;
                    list1 = list1.next;
                }
                else
                {
                    tail.next = list2;
                    list2 = list2.next;
                }

                tail = tail.next;
            }

            tail.next = list1 ?? list2;

            return dummyNode.next;
        }

        public void MergeTwoListsTest()
        {
            ListNode list1 = new ListNode(1);
            list1.next = new ListNode(2);
            list1.next.next = new ListNode(5);
            list1.next.next.next = new ListNode(10);
            ListNode list1Test = list1;
            while (list1Test != null)
            {
                Console.Write(list1Test.val + " ");
                list1Test = list1Test.next;
            }
            Console.WriteLine();

            ListNode list2 = new ListNode(5);
            list2.next = new ListNode(5);
            list2.next.next = new ListNode(6);
            list2.next.next.next = new ListNode(11);
            ListNode list2Test = list2;
            while (list2Test != null)
            {
                Console.Write(list2Test.val + " ");
                list2Test = list2Test.next;
            }
            Console.WriteLine();
            Console.WriteLine("Merged Lists: ");

            ListNode listNode = MergeTwoListsFunc(list1, list2);
            while (listNode != null)
            {
                Console.Write(listNode.val + " ");
                listNode = listNode.next;
            }
        }
    }
}
