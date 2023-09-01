/*
Roman numerals are represented by seven different symbols: I, V, X, L, C, D and M.
Symbol       Value
I             1
V             5
X             10
L             50
C             100
D             500
M             1000
For example, 2 is written as II in Roman numeral, just two ones added together. 12 is written as XII, which is simply X + II. The number 27 is written as XXVII, which is XX + V + II.
Roman numerals are usually written largest to smallest from left to right. However, the numeral for four is not IIII. Instead, the number four is written as IV. Because the one is before the five we subtract it making four. The same principle applies to the number nine, which is written as IX. There are six instances where subtraction is used:
    I can be placed before V (5) and X (10) to make 4 and 9. 
    X can be placed before L (50) and C (100) to make 40 and 90. 
    C can be placed before D (500) and M (1000) to make 400 and 900.
Given a roman numeral, convert it to an integer.

Example 1:
Input: s = "III"
Output: 3
Explanation: III = 3.

Example 2:
Input: s = "LVIII"
Output: 58
Explanation: L = 50, V= 5, III = 3.

Example 3:
Input: s = "MCMXCIV"
Output: 1994
Explanation: M = 1000, CM = 900, XC = 90 and IV = 4.

Constraints:
    1 <= s.length <= 15
    s contains only the characters ('I', 'V', 'X', 'L', 'C', 'D', 'M').
    It is guaranteed that s is a valid roman numeral in the range [1, 3999].
*/

//My Code
/*
This one I struggled with most so far. I had to lookup and find the Dictionary<T,T> structure after immeidately realizing trying to create a char[] for the Numerals and an int[] for the values and cross referencing would be too complex and time consuming
First couple solutions worked for the provided Example test cases, and failed. I attempted to start at the beginning of the number and it became too difficult because I couldn't compare just [i] to [i+1] because I had to also compare [i+1] to [i+2] and then the problem of how to move to a new index position to avoid duplicated adding/subtracting
Read the Hint which stated to work from the back and it was more manageable from there. Biggest roadblock after that was poor indexing leading to incorrect addition/subtraction or trying to check something out of bounds
*/

public class Solution
{
    public int RomanToInt(string s)
    {
        Dictionary<char, int> rom = new Dictionary<char, int>()
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };

        if(s.Length == 1){return rom[s[0]];}

        int ans = 0;

        for(int i = s.Length - 1; i >= 0; i--)
        {
            if(i == 0){return (ans + rom[s[i]]);}

            if(rom[s[i]] > rom[s[i-1]])
            {
                ans += rom[s[i]] - rom[s[i-1]];
                i -= 1;
            }
            else
            {
                ans += rom[s[i]];
            }
        }

        return ans;

    }
}
