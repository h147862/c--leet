// 125. Valid Palindrome
// Easy
// 8.7K
// 8.1K
// Companies
// A phrase is a palindrome if, after converting all uppercase letters into lowercase letters and removing all non-alphanumeric characters, it reads the same forward and backward. Alphanumeric characters include letters and numbers.

// Given a string s, return true if it is a palindrome, or false otherwise.

 

// Example 1:

// Input: s = "A man, a plan, a canal: Panama"
// Output: true
// Explanation: "amanaplanacanalpanama" is a palindrome.
// Example 2:

// Input: s = "race a car"
// Output: false
// Explanation: "raceacar" is not a palindrome.
// Example 3:

// Input: s = " "
// Output: true
// Explanation: s is an empty string "" after removing non-alphanumeric characters.
// Since an empty string reads the same forward and backward, it is a palindrome.
 

// Constraints:

// 1 <= s.length <= 2 * 105
// s consists only of printable ASCII characters.

namespace p125;

public class Solution {
    public bool IsPalindrome(string s) {
        var cr = new List<char>();
        foreach(var c in s){
            if(char.IsLetter(c) || char.IsDigit(c)){
                cr.Add(char.ToLower(c));
            }
        }
        var length = cr.Count();
        if (length ==0) return true;
        for(var i = 0; i < (int)(length/ 2); i++){
            if(cr[i] != cr[length -1 -i]) return false;
        }
        return true;
    }
}