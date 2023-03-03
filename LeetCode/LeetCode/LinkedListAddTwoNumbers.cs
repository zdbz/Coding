using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
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
    //class LinkedList
    //{
    //    public ListNode head;
    //    //constructor to create an empty LinkedList
    //    public LinkedList()
    //    {
    //        head = null;
    //    }
    //}
    //public class LinkedListAddTwoNumbers
    //{
    //    //https://leetcode.com/problems/add-two-numbers/
    //    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    //    {
    //        int sum = 0, carry = 0;
    //        ListNode temp = new ListNode(0);
    //        while (l1 != null && l2!=null)
    //        {
    //            temp.next = new ListNode(0);
    //            if (sum > 9)
    //                carry = 1;
    //            else
    //                carry = 0;
    //            sum = 0;
                

    //            if(l1 == null)
    //            {

    //            }
    //            if (l2 == null)
    //            {

    //            }

    //            sum = l1.val + l2.val;
    //            temp.val = sum % 10;
    //            l1 = l1.next;
    //            l2 = l2.next;

                
    //        }
    //        while(temp != null)
    //        {
    //            Console.WriteLine(temp.val);
    //        }
    //        return temp;
    //    }
    //}
      
}
