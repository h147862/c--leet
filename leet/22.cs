// 22. Generate Parentheses
// Medium
// 20.3K
// 855
// Companies
// Given n pairs of parentheses, write a function to generate all combinations of well-formed parentheses.

 

// Example 1:

// Input: n = 3
// Output: ["((()))","(()())","(())()","()(())","()()()"]
// Example 2:

// Input: n = 1
// Output: ["()"]
 

// Constraints:

// 1 <= n <= 8

namespace p22;

public class Solution {
    public IList<string> GenerateParenthesis(int n) {
        var tmp = new List<string>();
        var res = new List<string>();
        Generate(n, 1, 0, ref tmp, ref res, "(");
        return res;
    }
    public void Generate(int n, int lc, int rc, ref List<string> tmp, ref List<string> result, string item){
        tmp.Add(item);
        if(tmp.Count() == n*2){
            result.Add(string.Join("", tmp));
            tmp.RemoveAt(tmp.Count()-1);
            return;
        }
        if(lc<=rc){
            if(lc<n) Generate(n, lc+1 , rc, ref tmp, ref result, "(");
        }
        else{
            if(lc<n) Generate(n, lc+1 , rc, ref tmp, ref result, "(");
            if(rc<n) Generate(n, lc , rc +1 , ref tmp, ref result, ")");
        }
        tmp.RemoveAt(tmp.Count()-1);
        return;
    }
}