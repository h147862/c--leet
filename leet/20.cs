// 20. Valid Parentheses
// Companies
// Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.

// An input string is valid if:

// Open brackets must be closed by the same type of brackets.
// Open brackets must be closed in the correct order.
// Every close bracket has a corresponding open bracket of the same type.
 

// Example 1:

// Input: s = "()"
// Output: true
// Example 2:

// Input: s = "()[]{}"
// Output: true
// Example 3:

// Input: s = "(]"
// Output: false
 

// Constraints:

// 1 <= s.length <= 104
// s consists of parentheses only '()[]{}'.

namespace p20;

public class Solution {
    public bool IsValid(string s) {
        var st = new Stack<char>();
        var res = true;
        foreach(var c in s){
            if(c == '(' || c== '{' || c== '[' ) st.Push(c);
            else{
                char result;
                if(st.TryPop(out result)){
                    var t = new string(new char[]{result,c});
                    if(t == "()" || t == "[]" || t == "{}") continue;
                    res = false;
                    break;
                }
                res = false;
                break;
            }
        }
        if(st.Any()) return false;
        return res;
    }
}