using System;
using System.Collections.Generic;

namespace MyMath
{
    /// <summary>Operations Class</summary>
    public class Operations
    {
        /// <summary>Find the max number in a list</summary>
        /// <param name="nums">numbers list.</param>
        /// <returns>Max integer in List.</returns>
        public static int Max(List<int> nums)
        {
            if(nums.Count == 0)
            {
                return(0);
            }
            else
            {
             nums.Sort();
             {
                return nums[nums.Count - 1];
             }   
            }
        }
    }
}
