/*
Concatenate First and Last Name into One String
Given two strings, firstName and lastName, return a single string in the format "last, first".

Examples
ConcatName("First", "Last") ➞ "Last, First"

ConcatName("John", "Doe") ➞ "Doe, John"

ConcatName("Mary", "Jane") ➞ "Jane, Mary"
Notes
Don't forget to return the result.
If you get stuck on a challenge, find help in the Resources tab.
If you're really stuck, unlock solutions in the Solutions tab.
*/

public class Program
{
    public static string ConcatName(string firstName, string lastName)
    {
			return $"{lastName}, {firstName}";
    }
}



public class Program
{
	public static string ConcatName(string firstName, string lastName)
	{
		return lastName + ", " + firstName;
	}
}



