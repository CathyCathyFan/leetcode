using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Globalization;

namespace Solutions
{

    public class Easy
    {
        public static void Main()
        {
            //string s = "cbbd";
            //string s = "ac";
            string s = "bb";
            LongestPalindrome(s);


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

        static public int LengthOfLongestSubstring()
        {
            string s = "abcbcadefg";
            if (s == null || s.Length == 0) return 0;

            int count = 0;


            #region Solution 1 Loop
            //for (int i = 0; i < s.Length; i++)
            //{
            //    for (int j = i; j < s.Length; j++)
            //    {
            //        if (!HasDupChar(s.Substring(i, j - i+1)))
            //        {
            //            count = Math.Max(count, j - i+1);
            //        }
            //        else
            //        {
            //            break;
            //        }
            //    }
            //}
            #endregion

            #region Solution 2 Window
            int j = 1;
            for (int i = 0; i < s.Length;)
            {

                while (j < s.Length && !HasDupChar(s.Substring(i, j - i + 1)))
                {
                    Console.WriteLine(string.Format("j={0}", j));
                    Console.WriteLine(s.Substring(i, j - i + 1));

                    count = Math.Max(count, j - i + 1);
                    j++;
                }

                if (j < s.Length)
                {
                    i = i + s.Substring(i, j - i).IndexOf(s[j]) + 1;
                    Console.WriteLine(string.Format("i= {0}", i));
                    continue;
                }

                break;
            }
            #endregion

            return count;
        }


        static public string LongestPalindrome(string s)
        {
            #region solution 1 loop
            //if (s == null) return null;
            //if (s.Length <= 1 || isP(s)) return s;
            //int length = 1;
            //string rel = s.Substring(0, 1);


            //for (int i = 0; i < s.Length; i++)
            //{
            //    int move = 1;

            //    while ((i - move) >= 0 && (i + move) < s.Length && isP(s.Substring(i - move, move * 2 + 1)))
            //    {
            //        if (length < move * 2 + 1)
            //        {
            //            length = move * 2 + 1;
            //            rel = s.Substring(i - move, move * 2 + 1);
            //        }

            //        move++;
            //    }

            //    move = 1;

            //    while ((i - move) >= 0 && (i + move - 1) < s.Length && isP(s.Substring(i - move, move * 2)))
            //    {
            //        if (length < move * 2)
            //        {
            //            length = move * 2;
            //            rel = s.Substring(i - move, move * 2);
            //        }

            //        move++;
            //    }
            //}

            return rel;
            #endregion

            #region Solution 2 simpler than 1
            //if (s == null || s.Length == 0)
            //    return null;
            //if (s.Length == 1)
            //    return s;

            //string res = s.Substring(0, 1);

            //for (int i = 0; i < s.Length; i++)
            //{
            //    // get longest palindrome with center of i
            //    string tmp = helper(s, i, i);
            //    if (tmp.Length > res.Length)
            //    {
            //        res = tmp;
            //    }

            //    // get longest palindrome with center of i, i+1
            //    tmp = helper(s, i, i + 1);
            //    if (tmp.Length > res.Length)
            //    {
            //        res = tmp;
            //    }
            //}

            //return res;
            #endregion
        }

        static private bool HasDupChar(string str)
        {
            HashSet<char> hs = new HashSet<char>();

            foreach (char c in str)
            {
                if (hs.Contains(c))
                {
                    return true;
                }

                hs.Add(c);
            }

            return false;
        }

        static private bool isP(string str)
        {
            if (str == null || str.Length == 0)
                return false;
            int i = 0;
            while (i < str.Length / 2)
            {
                if (!(str[i] == str[str.Length - i - 1]))
                {
                    break;
                }

                i++;
            }

            if (i < str.Length / 2)
                return false;
            else
                return true;
        }

        static public string helper(string s, int begin, int end)
        {
            while (begin >= 0 && end <= s.Length - 1 && s[begin] == s[end])
            {
                begin--;
                end++;
            }
            return s.Substring(begin + 1, end - begin - 1);
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }
}
