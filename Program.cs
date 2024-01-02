// See https://aka.ms/new-console-template for more information

using p347;
var s = new Solution();
var nums = new int[]{3,2,3,1,2,4,5,5,6,7,7,8,2,3,1,1,1,10,11,5,6,2,4,7,8,5,6};
var k = 10;
var res = s.TopKFrequent(nums,k);
Console.WriteLine(res);
