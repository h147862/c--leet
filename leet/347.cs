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
        var freq = new Dictionary<int,int>();
        var lookup = new Dictionary<int,IList<int>>();
        foreach(var n in nums){
            if(freq.ContainsKey(n)){
                freq[n]++;
            }
            else{
                freq[n] = 1;
            }
        }
        foreach(var item in freq){
            if(lookup.ContainsKey(item.Value)){
                lookup[item.Value].Add(item.Key);
            }
            else{
                 lookup[item.Value] = new List<int>(){item.Key};
            }
        }
        var cnt = 0;
        var res = new int[k];
        for(var idx = nums.Length; idx >= 1; idx--){
            if(cnt >= k) break;
            IList<int> value;
            if(lookup.TryGetValue(idx, out value)){
                foreach(var n in value){
                    res[cnt] = n;
                    cnt++;
                }
            }
        }
        return res;
    }
}