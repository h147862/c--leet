// 704. Binary Search
// Easy
// 11.3K
// 233
// Companies
// Given an array of integers nums which is sorted in ascending order, and an integer target, write a function to search target in nums. If target exists, then return its index. Otherwise, return -1.

// You must write an algorithm with O(log n) runtime complexity.

 

// Example 1:

// Input: nums = [-1,0,3,5,9,12], target = 9
// Output: 4
// Explanation: 9 exists in nums and its index is 4
// Example 2:

// Input: nums = [-1,0,3,5,9,12], target = 2
// Output: -1
// Explanation: 2 does not exist in nums so return -1
 

// Constraints:

// 1 <= nums.length <= 104
// -104 < nums[i], target < 104
// All the integers in nums are unique.
// nums is sorted in ascending order.

namespace p704;

public class Solution {
    public int Search(int[] nums, int target) {
       return bsearch(nums, target);
    }

    private int bsearch(int[] arr, int target){
        var mid = (int) arr.Length / 2;
        if(arr[mid] == target) return mid;
        else if (arr.Length == 1) return -1;
        else if (arr[mid] > target){
            var sub = new int[mid+1];
            Array.Copy(arr, 0,sub , 0, mid+1);
            bsearch(sub, target);
        } 
        else{
            var sub = new int[arr.Length - mid];
            Array.Copy(arr, mid,sub , 0, arr.Length - mid);
            bsearch(sub, target);
        }
        return -1;
    }
}