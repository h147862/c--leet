// https://leetcode.com/problems/valid-anagram/
// 242. Valid Anagram
// Given two strings s and t, return true if t is an anagram of s, and false otherwise.

// An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase, typically using all the original letters exactly once.

 

// Example 1:

// Input: s = "anagram", t = "nagaram"
// Output: true
// Example 2:

// Input: s = "rat", t = "car"
// Output: false
 

// Constraints:

// 1 <= s.length, t.length <= 5 * 104
// s and t consist of lowercase English letters.
 

namespace p242;
public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Count() != t.Count()) return false;
        var sr = s.ToCharArray();
        var tr = t.ToCharArray();
        Array.Sort(sr);
        Array.Sort(tr);
        for(var i =0;i<tr.Count();i++){
            if (sr[i] != tr[i]) return false;
        }
        return true;
    }
}