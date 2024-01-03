// 238. Product of Array Except Self
// Medium
// 21K
// 1.2K
// Companies
// Given an integer array nums, return an array answer such that answer[i] is equal to the product of all the elements of nums except nums[i].

// The product of any prefix or suffix of nums is guaranteed to fit in a 32-bit integer.

// You must write an algorithm that runs in O(n) time and without using the division operation.

 

// Example 1:

// Input: nums = [1,2,3,4]
// Output: [24,12,8,6]
// Example 2:

// Input: nums = [-1,1,0,-3,3]
// Output: [0,0,9,0,0]
 

// Constraints:

// 2 <= nums.length <= 105
// -30 <= nums[i] <= 30
// The product of any prefix or suffix of nums is guaranteed to fit in a 32-bit integer.
 

// Follow up: Can you solve the problem in O(1) extra space complexity? (The output array does not count as extra space for space complexity analysis.)

namespace p238;
public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        var left = new int[nums.Length];
        var right = new int[nums.Length];
        var res = new int[nums.Length];
        left[0] = 1;
        right[nums.Length -1] = 1;
        for(var i = 1;i<nums.Length;i++){
            left[i] = nums[i-1] * left[i-1];
        }
        for(var i = nums.Length - 2; i>=0 ;i--){
            right[i] = nums[i+1] * right[i+1];
        }
        res[0] = right[0];
        res[nums.Length-1] = left[nums.Length- 1];
        for(var i =1;i<nums.Length-1;i++){
            res[i] = left[i] * right[i];
        }
        return res;
    }
}