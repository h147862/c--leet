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
        var st = new Stack<string>();
        var res = new List<string>();
        Generate(1, 0, n, ref st, ref res, "(");
        return res;
    }

    private void Generate(int lc, int rc, int n, 
                    ref Stack<string> st, ref List<string> res, string p){
        st.Push(p);
        if(lc + rc == n*2){
            var tmpStack = new Stack<string>(st);
            var s = "";
            while(tmpStack.Any()){
                s += tmpStack.Pop();
            }
            res.Add(s);
            st.Pop();
            return;
        } else if (lc < rc){
            st.Pop();
            return;
        }
        if(lc < n) Generate(lc+1,rc, n , ref st, ref res, "(");
        if(rc < n)  Generate(lc,rc+1, n , ref st, ref res, ")");
        st.Pop();
       
        

        // if(lc == rc){
        //     st.Push("(");
        //     Generate(lc+1,rc, n , ref st, ref res);
        // }
        // else if (lc > rc){
        //     st.Push(")");
        //     Generate(lc,rc+1, n , ref st, ref res);
        //     st.Push("(");
        //     Generate(lc+1,rc, n , ref st, ref res);
        // }
    }
}