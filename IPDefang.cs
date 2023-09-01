/*
Given a valid (IPv4) IP address, return a defanged version of that IP address.
A defanged IP address replaces every period "." with "[.]".

Example 1:
Input: address = "1.1.1.1"
Output: "1[.]1[.]1[.]1"

Example 2:
Input: address = "255.100.50.0"
Output: "255[.]100[.]50[.]0"

Constraints: The given address is a valid IPv4 address.
*/

//My Code
/*
My Primary attempt at this was to create a char[] with length of address + 6. then copy the string to the array and at any index i that was '.' replace it with '[' and i+1 with '.' then i+2 ']'
Then convert that array to a string and return it. after a few failures I read some documentation on String functions and found Split() which seemed like the best method at hand to use.
*/
public class Solution
{
  public string DefangIPaddr(string address)
  {
    //Create an array that stores the IP address value substrings then create the solution string using the Join() method 
    string[] pieces = address.Split(".");

    string result = String.Join("[.]", pieces); 

    return result;
  }
}
