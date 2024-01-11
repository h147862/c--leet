// 78. Subsets
// Medium
// 16.3K
// 248
// Companies
// Given an integer array nums of unique elements, return all possible 
// subsets
//  (the power set).

// The solution set must not contain duplicate subsets. Return the solution in any order.

 

// Example 1:

// Input: nums = [1,2,3]
// Output: [[],[1],[2],[1,2],[3],[1,3],[2,3],[1,2,3]]
// Example 2:

// Input: nums = [0]
// Output: [[],[0]]
 

// Constraints:

// 1 <= nums.length <= 10
// -10 <= nums[i] <= 10
// All the numbers of nums are unique.

namespace p78;

public class Solution {
    public IList<IList<int>> Subsets(int[] nums) {
        IList<IList<int>> res = new List<IList<int>>();
        IList<int> tmp = new List<int>();
        GetSub(nums, 0, ref res, ref tmp);
        return res;
    }

    private void GetSub(int[] nums, int idx, ref IList<IList<int>> res, ref IList<int> tmp){
        res.Add(new List<int>(tmp));
        for(var i = idx ; i< nums.Length; i++){
            tmp.Add(nums[i]);
            GetSub(nums, i+1, ref res, ref tmp);
            tmp.RemoveAt(tmp.Count()-1);
        }
    }
}