**20. Valid Parentheses**

Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.

An input string is valid if:

1. Open brackets must be closed by the same type of brackets.
2. Open brackets must be closed in the correct order.
3. Every close bracket has a corresponding open bracket of the same type.

```csharp
public class Solution
{
    public bool IsValid(string s)
    {
        Stack<char> strStack = new Stack<char>(); //Used the LC hint provided to use a Stack

        //If odd length string by definition cannot be valid
        if(s.Length % 2 != 0)
        {
            return false;
        }

        //Iterates through each character of the string and if it is an open-type: ( { [ adds to stack
        //If it is a closed type and the stack is not empty and the close matches the open at the top of the stack remove the open
        //If the stack is empty when a close type is found or there is not a corresponding correct match open type returns false
        for(int i = 0; i < s.Length; i++)
        {
            if(s[i].Equals('(') || s[i].Equals('{') || s[i].Equals('['))
            {
                strStack.Push(s[i]);
            }
            else if(strStack.Count() > 0 && s[i].Equals(')') && strStack.Peek().Equals('('))
            {
                strStack.Pop();
            }
            else if(strStack.Count() > 0 && s[i].Equals('}') && strStack.Peek().Equals('{'))
            {
                strStack.Pop();
            }
            else if(strStack.Count() > 0 && s[i].Equals(']') && strStack.Peek().Equals('['))
            {
                strStack.Pop();
            }
            else
            {
                return false;
            }
        }

        //At the end of program is stack is empty then the string was valid, otherwise it was invalid and returns false
        return strStack.Count() == 0;

    }
}
```
