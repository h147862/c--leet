// 739. Daily Temperatures
// Medium
// 12.1K
// 275
// Companies
// Given an array of integers temperatures represents the daily temperatures, return an array answer such that answer[i] is the number of days you have to wait after the ith day to get a warmer temperature. If there is no future day for which this is possible, keep answer[i] == 0 instead.

 

// Example 1:           
// Input: temperatures = [73,74,75,71,69,72,76,73]
// Output: [1,1,4,2,1,1,0,0]
// Example 2:

// Input: temperatures = [30,40,50,60]
// Output: [1,1,1,0]
// Example 3:

// Input: temperatures = [30,60,90]
// Output: [1,1,0]
 

// Constraints:

// 1 <= temperatures.length <= 105
// 30 <= temperatures[i] <= 100

namespace p739;

public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        var res = new int[temperatures.Length];
        var st = new Stack<int>();
        st.Push(0);
        for(var i = 1;i<temperatures.Length;i++){
            int t;
            while(st.TryPeek(out t)){
                if(temperatures[t] < temperatures[i]){
                    st.Pop();
                    res[t] = i-t;
                }
                else break;
            }
            st.Push(i);
        }
        return res;
    }
}