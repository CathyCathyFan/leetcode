using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace Solutions
{
    
    public class Easy
    {
        public static void Main()
        {
            Console.Read();
        }
       
        public int[] TwoSum()
        {
            //Case 1
            //int[] nums = {-1,-2,-3,-4,-5};            
            //int target = -8;

            //Case 2
            int[] nums = { 3, 3 };
            int target = 6;

            #region  //Solution 1  For loops

            //if (nums == null || nums.Length == 0)
            //{
            //    return null;
            //}
            //int[] rel = new int[2];
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    for (int j = i + 1; j < nums.Length; j++)
            //    {
            //        if (nums[i] + nums[j] == target)
            //        {
            //            rel[0] = i;
            //            rel[1] = j;
            //            return rel;
            //        }
            //    }
            //}
            //return null;
            #endregion

            #region //Solution 2 C# method
            //int index = -1;
            //int[] rel = new int[2];
            //for(int i = 0; i<nums.Length; i++)
            //{
            //    index = Array.IndexOf(nums, target-nums[i], i+1);
            //    if(index>0 && index != i)
            //    {
            //        rel[0] = index>i?i:index;
            //        rel[1] = index>i?index:i;                
            //    }
            //}
            #endregion

            #region //Solution 3 Dictionary
            //Dictionary<int, int> ht = new Dictionary<int, int>();

            //for (int i = 0; i < nums.Length; i++)
            //{
            //    int left = target - nums[i];

            //    if (ht.ContainsKey(left))
            //    {
            //        return new int[] { ht[left], i };
            //    }
            //    else
            //    {
            //        if (!ht.ContainsKey(nums[i]))
            //        {
            //            ht.Add(nums[i], i);
            //        }
            //    }
            //}           
            #endregion

            return null;
        }

        
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            if (l1 == null || l2 == null)
            {
                return l1 == null ? l2 : l1;
            }

            ListNode l3 = new ListNode(0);

            ListNode l = l3;
            int over = 0;

            while (l1 != null || l2 != null)
            {
                int val1 = l1 == null ? 0 : l1.val;
                int val2 = l2 == null ? 0 : l2.val;

                l3.val = (val1 + val2 + over) % 10;
                over = (val1 + val2 + over) / 10;

                l1 = l1 != null && l1.next != null ? l1.next : null;
                l2 = l2 != null && l2.next != null ? l2.next : null;

                if (l1 != null || l2 != null || over > 0)
                {
                    l3.next = new ListNode(over);
                    l3 = l3.next;
                }
            }

            return l;
        }

        
        public int LengthOfLongestSubstring()
        {
           string s = "pwwkew";
            if (s == null || s.Length == 0)  return 0;

            return count;
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }
}
