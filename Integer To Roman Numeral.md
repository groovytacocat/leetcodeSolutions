**12. Integer to Roman**

Roman numerals are represented by seven different symbols: I, V, X, L, C, D and M.

Symbol       Value
I             1
V             5
X             10
L             50
C             100
D             500
M             1000

For example, 2 is written as II in Roman numeral, just two one's added together. 12 is written as XII, which is simply X + II. The number 27 is written as XXVII, which is XX + V + II.

Roman numerals are usually written largest to smallest from left to right. However, the numeral for four is not IIII. Instead, the number four is written as IV. Because the one is before the five we subtract it making four. The same principle applies to the number nine, which is written as IX. There are six instances where subtraction is used:

1. I can be placed before V (5) and X (10) to make 4 and 9. 
2. X can be placed before L (50) and C (100) to make 40 and 90. 
3. C can be placed before D (500) and M (1000) to make 400 and 900.

This is an obnoxiously long chain of if/elses that each have an if/else themselves and I haven't come up with a solution I liked more/looked cleaner. 

Also I feel like there is a recursive solution but that also escapes me at time of posting.

```csharp
public class Solution
{
    public string IntToRoman(int num)
    {
        StringBuilder sb = new StringBuilder();

        while(num > 0)
        {
            if(num >= 900)
            {
                if(num >= 1000)
                {
                    num -= 1000;
                    sb.Append("M");
                }
                else
                {
                    num -= 900;
                    sb.Append("CM");
                }
            }
            else if(num >= 400)
            {
                if(num >= 500)
                {
                    num -= 500;
                    sb.Append("D");
                }
                else
                {
                    num -= 400;
                    sb.Append("CD");
                }
            }
            else if(num >= 90)
            {
                if(num >= 100)
                {
                    num -= 100;
                    sb.Append("C");
                }
                else
                {
                    num -= 90;
                    sb.Append("XC");
                }
            }
            else if(num >= 40)
            {
                if(num >= 50)
                {
                    num -= 50;
                    sb.Append("L");
                }
                else
                {
                    num -= 40;
                    sb.Append("XL");
                }
            }
            else if(num >= 9)
            {
                if(num >= 10)
                {
                    num -= 10;
                    sb.Append("X");
                }
                else
                {
                    num -= 9;
                    sb.Append("IX");
                }
            }
            else if(num >= 4)
            {
                if(num >= 5)
                {
                    num -= 5;
                    sb.Append("V");
                }
                else
                {
                    num -= 4;
                    sb.Append("IV");
                }
            }
            else if(num >= 1)
            {
                num -= 1;
                sb.Append("I");
            }
        }

        return sb.ToString();
    }
}
```
