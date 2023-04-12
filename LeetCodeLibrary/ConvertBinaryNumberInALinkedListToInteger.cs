using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class ConvertBinaryNumberInALinkedListToInteger
    {
        public int GetDecimalValue(ListNode head)
        {
            string res = "";

            while (head != null)
            {
                res += (head.val);
                head = head.next;
            }

            return Convert.ToInt32(res, 2);
        }
    }
}
