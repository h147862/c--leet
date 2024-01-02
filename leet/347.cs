// 347. Top K Frequent Elements
// Medium
// 16.5K
// 610
// Companies
// Given an integer array nums and an integer k, return the k most frequent elements. You may return the answer in any order.

 

// Example 1:

// Input: nums = [1,1,1,2,2,3], k = 2
// Output: [1,2]
// Example 2:

// Input: nums = [1], k = 1
// Output: [1]
 

// Constraints:

// 1 <= nums.length <= 105
// -104 <= nums[i] <= 104
// k is in the range [1, the number of unique elements in the array].
// It is guaranteed that the answer is unique.
 

// Follow up: Your algorithm's time complexity must be better than O(n log n), where n is the array's size.

namespace p347;
public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var d = new Dictionary<int, int>();
        var lookup = new Dictionary<int, IList<int>>();
        var res = new int[k];
        foreach(var n in nums){
            if(d.ContainsKey(n)){
                d[n]++;
            }
            else{
                d[n] = 1;
            }
        }   
        foreach(var item in d){
            if(lookup.ContainsKey(item.Value)){
                lookup[item.Value].Add(item.Key);
            }
            else{
                 lookup[item.Value] = new List<int>(){item.Key};
            }
        }
        var freq = lookup.Keys.ToArray();
        Array.Sort(freq);
        var idx = 0;
        for(var i=0;i<k;i++){
            if(idx == k) break;
            foreach(var n in lookup[freq[freq.Length-1-i]]){
                 res[idx] = n;
                 idx++;
            }
        }
        return res;
    }
}