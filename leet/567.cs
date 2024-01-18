// 567. Permutation in String
// Medium
// Topics
// Companies
// Hint
// Given two strings s1 and s2, return true if s2 contains a permutation of s1, or false otherwise.

// In other words, return true if one of s1's permutations is the substring of s2.

 

// Example 1:

// Input: s1 = "ab", s2 = "eidbaooo"
// Output: true
// Explanation: s2 contains one permutation of s1 ("ba").
// Example 2:

// Input: s1 = "ab", s2 = "eidboaoo"
// Output: false
 

// Constraints:

// 1 <= s1.length, s2.length <= 104
// s1 and s2 consist of lowercase English letters.

namespace p567;

public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        if(s1.Length > s2.Length) return false;
        var len = s1.Length;
        var arr1 = s1.ToArray();
        var arr2 = s2.ToArray();
        var d1 = new Dictionary<char,int>();
        var d2 = new Dictionary<char,int>();
        for(var i = 0;i<len;i++){
            if(d1.ContainsKey(arr1[i])) d1[arr1[i]]++;
            else d1[arr1[i]] = 1;
            if(d2.ContainsKey(arr2[i])) d2[arr2[i]]++;
            else d2[arr2[i]] = 1;
        }
        var l = 0;
        if(Compare(d1,d2)) return true;
        d2[arr2[l]]--;
        l++;
        for(var r = len;r<s2.Length;r++){
            if(d2.ContainsKey(arr2[r])) d2[arr2[r]]++;
            else d2[arr2[r]] = 1;
            if(Compare(d1,d2)) return true;
            d2[arr2[l]]--;
            l++;
        }
        return false;
    }

    public bool Compare(Dictionary<char, int> d1, Dictionary<char, int> d2){
        foreach(var item in d1){
            int value;
            if(d2.TryGetValue(item.Key, out value)){
                if(item.Value != value) return false;
            }
            else return false;
        }
        return true;
    }
}