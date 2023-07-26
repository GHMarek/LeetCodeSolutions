using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    // https://www.geeksforgeeks.org/recursively-reversing-a-linked-list-a-simple-implementation/
    public class ReverseLinkedList
    {

        // iterative
        public ListNode ReverseList(ListNode head)
        {
            ListNode prev = null, curr = head, next = null;

            while (curr != null)
            {
                next = curr.next;
                curr.next = prev;
                prev = curr;

                curr = next;

            }

            head = prev;

            return prev;
            
        }

        public ListNode RecursiveReverse(ListNode head)
        {
            if (head == null)
            {
                return head;
            }

            if(head.next == null)
            {
                return head;
            }

            ListNode newHead = RecursiveReverse(head.next);

            head.next.next = head;

            head.next = newHead;

            return newHead;

        }

        public ListNode TailRecursiveReverse(ListNode head)
        {
            return ReverseListHelper(head, null);
        }

        private ListNode ReverseListHelper(ListNode current, ListNode newHead)
        {
            if (current == null)
            {
                return newHead;
            }
            // Get next node to pass it as current
            ListNode nextNode = current.next;
            // Next node becomes new head
            current.next = newHead;

            return ReverseListHelper(nextNode, current);
        }

    }
}
