using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class MiddleOfTheLinkedList
    {
        // https://www.enjoyalgorithms.com/blog/find-middle-of-linked-list
        public ListNode MiddleNode(ListNode head)
        {
            ListNode headSlow = head;
            ListNode headFast = head;

            while (headFast != null && headFast.next != null) 
            { 
                headSlow = headSlow.next;
                headFast = headFast.next.next;
            }

            return headSlow;
        }
    }
}
