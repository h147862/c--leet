// 74. Search a 2D Matrix
// Medium
// 15.1K
// 400
// Companies
// You are given an m x n integer matrix matrix with the following two properties:

// Each row is sorted in non-decreasing order.
// The first integer of each row is greater than the last integer of the previous row.
// Given an integer target, return true if target is in matrix or false otherwise.

// You must write a solution in O(log(m * n)) time complexity.

// Input: matrix = [[1,3,5,7],[10,11,16,20],[23,30,34,60]], target = 3
// Output: true

// Example 2:

// Input: matrix = [[1,3,5,7],[10,11,16,20],[23,30,34,60]], target = 13
// Output: false

namespace p74;


public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        var idx = 0;
        for(var i =1;i < matrix.Length; i++){
            if(matrix[i][0] == target) return true; 
            else if(target < matrix[i][0]){
                idx = i-1;
                break;
            } 
            else{
                idx = i;
            }
        }
        var l = 0;
        var r = matrix[idx].Length - 1;
        int mid;
        while(l<=r){
            mid = (l + r) / 2;
            if(matrix[idx][mid] == target) return true;
            else if (matrix[idx][mid] < target){
                l = mid +1;
            }
            else{
                r = mid -1;
            }
        }
        return false;
    }
}