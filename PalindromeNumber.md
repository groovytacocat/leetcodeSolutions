**Palindrome Number**

Given an integer x, return true if x is a palindrome, and false otherwise.

>Example 1:
>
>Input: x = 121
>
>Output: true
>
>Explanation: 121 reads as 121 from left to right and from right to left.

>Example 2:
>
>Input: x = -121
>
>Output: false
>
>Explanation: From left to right, it reads -121. From right to left, it becomes 121-. Therefore it is not a palindrome.

>Example 3:
>
>Input: x = 10
>
>Output: false
>
>Explanation: Reads 01 from right to left. Therefore it is not a palindrome.


I converted the int to a string then iterate through the string. By definition of a palindrome the character at position `i` has to be the same as `^(i + 1)`.

```csharp
public class Solution
{
    public bool IsPalindrome(int x)
    {
        string xString = x.ToString();
        bool same = true;
        
        for(int i = 0; i < xString.Length; i++)
        {
            if(xString[i] == xString[^(i+1)])
            {
                same = true;
            }
            else { return false;}
        }
        return same;
    }
}
```

I was curious to see that the below solution that seemed more efficient in my head was actually slower than the above (by ~5ms)
```csharp
public class Solution
{
    public bool IsPalindrome(int x)
    {
        string xString = x.ToString();
        
        for(int i = 0; i < xString.Length / 2; i++)
        {
            if(xString[i] != xString[^(i+1)])
            {
                same = true;
            }
        }
        
        return true;
    }
}
```
