using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class ListNode
    {
        // https://www.c-sharpcorner.com/article/linked-list-implementation-in-c-sharp/
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }


        /*
        
        To traverse it:

        while (true)
        {
            head = head.next;
        }

        */
    }
}
