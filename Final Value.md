**2011. Final Value of Variable After Performing Operations**

There is a programming language with only four operations and one variable X:

    ++X and X++ increments the value of the variable X by 1.
    --X and X-- decrements the value of the variable X by 1.

Initially, the value of X is 0.

Given an array of strings operations containing a list of operations, return the final value of X after performing all the operations.

This one was pretty simple so I didn't really think comments were necessary


```csharp
public class Solution
{
    public int FinalValueAfterOperations(string[] operations)
    {
        int x = 0;

        foreach(string s in operations)
        {
            if(s.Contains("++"))
            {
                x++;
            }
            else
            {
                x--;
            }
        }

        return x;
    }
}
```
