**1470. Shuffle the Array**

Given the array nums consisting of 2n elements in the form [x1,x2,...,xn,y1,y2,...,yn].

Return the array in the form [x1,y1,x2,y2,...,xn,yn].

 

Example 1:

>Input: nums = [2,5,1,3,4,7], n = 3
>
>Output: [2,3,5,4,1,7] 
>
>Explanation: Since x1=2, x2=5, x3=1, y1=3, y2=4, y3=7 then the answer is [2,3,5,4,1,7].

2, 5, 1, 3, 4, 7
0  1  2  3  4  5
x1 x2 x3 y1 y2 y3

```csharp 
public class Solution
{
    public int[] Shuffle(int[] nums, int n)
    {
        int[] ans = new int[2*n];


        //x1 will always be the 0 element so by problem definition x values will be even 
        //y1 starts at the nth index of nums and will always be the odd indexes 
        for(int i = 0; i < ans.Length; i++)
        {
            if(i % 2 == 0)
            {
                ans[i] = nums[i / 2];
            }
            else
            {
                ans[i] = nums[n];
                n++;
            }
        }
        return ans;
    }
}
```
