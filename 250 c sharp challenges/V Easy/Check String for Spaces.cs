/*
Check String for Spaces
Create a function that returns true if a string contains any spaces.

Examples
HasSpaces("hello") ➞ false

HasSpaces("hello, world") ➞ true

HasSpaces(" ") ➞ true

HasSpaces("") ➞ false

HasSpaces(",./!@#") ➞ false
Notes
An empty string does not contain any spaces.
Try doing this without RegEx.
Don't forget to return the result.
If you get stuck on a challenge, find help in the Resources tab.
If you're really stuck, unlock solutions in the Solutions tab.
*/


public class Program
{
    public static bool HasSpaces(string str)
    {
			return (str.Contains(" "));
    }
}




