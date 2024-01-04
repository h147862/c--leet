// 155. Min Stack
// Medium
// 13.5K
// 819
// Companies
// Design a stack that supports push, pop, top, and retrieving the minimum element in constant time.

// Implement the MinStack class:

// MinStack() initializes the stack object.
// void push(int val) pushes the element val onto the stack.
// void pop() removes the element on the top of the stack.
// int top() gets the top element of the stack.
// int getMin() retrieves the minimum element in the stack.
// You must implement a solution with O(1) time complexity for each function.

 

// Example 1:

// Input
// ["MinStack","push","push","push","getMin","pop","top","getMin"]
// [[],[-2],[0],[-3],[],[],[],[]]

// Output
// [null,null,null,null,-3,null,0,-2]

// Explanation
// MinStack minStack = new MinStack();
// minStack.push(-2);
// minStack.push(0);
// minStack.push(-3);
// minStack.getMin(); // return -3
// minStack.pop();
// minStack.top();    // return 0
// minStack.getMin(); // return -2

namespace p155;
public class MinStack {

    private Stack<int> st;
    private Stack<int> minimumStack;
    private int minimum;
    private LinkedList<int> dq;

    public MinStack() {
        st = new Stack<int>();
        minimumStack = new Stack<int>();
        minimum = int.MaxValue; 
    }
    
    public void Push(int val) {
        st.Push(val);
        if(val <= minimum){
            minimum = val;
            minimumStack.Push(minimum);
        }
    }
    
    public void Pop() {
        var m = st.Pop();
        if(m == minimum) minimumStack.Pop();
        if(minimumStack.Any())   minimum = minimumStack.Peek();
        else minimum = int.MaxValue;
    }
    
    public int Top() {
        return st.Peek();
    }
    
    public int GetMin() {
        return minimum;
    }
}

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(val);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */