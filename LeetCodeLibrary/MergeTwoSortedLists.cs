using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class MergeTwoSortedLists
    {
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            return MergeTwoListsHelper(list1, list2);
        }

        private ListNode MergeTwoListsHelper(ListNode list1, ListNode list2)
        {
            // Base cases
            // If list1 is null, we return list2, which means we have reached the end of list1,
            // and we attach the remaining nodes of list2 to the merged list.
            if (list1 == null)
            {
                return list2;
            }
            if(list2 == null)
            {
                return list1;
            }

            // If neither list1 nor list2 is null:

            // If the value of the first node of list1 (list1.val) is less
            // than value of the first node of list2 (list2.val), we choose list1
            // to be the current node in the merged list.
            // We then recursively call MergeTwoListsHelper with the next node of list1 and the same list2.
            if (list1.val <= list2.val)
            {
                list1.next = MergeTwoListsHelper(list1.next, list2);
                return list1;
            }
            // If the value of the first node of list1 (list1.val) is greater than the value
            // of the first node of list2 (list2.val),
            // we choose list2 to be the current node in the merged list.
            else
            {
                list1.next = MergeTwoListsHelper(list1, list2.next);
                return list2;
            }

        }
    }
}
