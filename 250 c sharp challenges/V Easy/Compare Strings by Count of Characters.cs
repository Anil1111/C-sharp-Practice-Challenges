/*
Compare Strings by Count of Characters
Create a function that takes two strings as arguments and return either true or false depending on whether the total number of characters in the first string is equal to the total number of characters in the second string.

Examples
Comp("AB", "CD") ➞ true

Comp("ABC", "DE") ➞ false

Comp("hello", "edabit") ➞ false
Notes
Don't forget to return the result.
If you get stuck on a challenge, find help in the Resources tab.
If you're really stuck, unlock solutions in the Solutions tab.


*/


//#############################################################
//#                        MY SOLUTIONS                       #
//#############################################################




public class Program 
{
    public static bool Comp(string str1, string str2) 
    {
			return str1.Length == str2.Length;
    }
}


public class Program 
{
    public static bool Comp(string str1, string str2) => str1.Length == str2.Length;
}


