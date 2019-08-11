using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Solutions
{
    [TestClass]
    public class Easy
    {
        [TestMethod]
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

            #region //Solution 3 Hash Table
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
    }
}
