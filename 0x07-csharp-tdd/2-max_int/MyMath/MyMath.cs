using System;
using System.Collections.Generic;

namespace MyMath
{
    /// <summary>
    /// Class containing a few different algebraic operations.
    /// </summary>
    public class Operations
    {
        /// <summary>
        /// Returns the max integer in a list of integers
        /// </summary>
        public static int Max(List<int> nums){
            int max = 0;
            if (nums.Count > 0){
                nums.Sort();
                max = nums[nums.Count - 1];
            }
            return max;
        }
    }
}
