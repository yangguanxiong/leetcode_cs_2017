using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode_cs_2017
{
    class Program
    {

        public static bool IsPalindrome(ListNode head)
        {
            if (head == null || head.next == null)
            {
                return true;
            }

            var r = head;
            int k = 0;
            while (r != null)
            {
                r = r.next;
                k++;
            }

            int steps = (k + 1) / 2;
            var i = head;
            var j = head;
            while (steps > 0)
            {
                j = j.next;
                steps--;
            }
            while (j != null)
            {
                if (j.val != i.val)
                {
                    return false;
                }
                j = j.next;
            }
            return true;
        }




        /* Driver program to test above functions */
        public static void Main(String[] args)
        {

            
        }

    }
}
