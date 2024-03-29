/*

Is the Word Singular or Plural?
Create a function that takes in a word and determines whether or not it is plural. A plural word is one that ends in "s".

Examples
IsPlural("changes") ➞ true

IsPlural("change") ➞ false

IsPlural("dudes") ➞ true

IsPlural("magic") ➞ false
Notes
Don't forget to return the result.
Remember that return true (boolean) is not the same as return "true" (string).
This is an oversimplification of the English language. We are ignoring edge cases like "goose" and "geese", "fungus" and "fungi", etc.
If you get stuck on a challenge, find help in the Resources tab.
If you're really stuck, unlock solutions in the Solutions tab.


*/


//#############################################################
//#                        MY SOLUTIONS                       #
//#############################################################



/*

Solution 1

*/



//using System;
public class Program
{
    public static bool IsPlural(string word)
    {
			return word.EndsWith("s");
    }
}



/*

Solution 2

*/



public class Program
{
    public static bool IsPlural(string word)
    {
			return word.EndsWith("s", System.StringComparison.InvariantCultureIgnoreCase);
    }
}



/*

Solution 3


*/


public class Program
{
    public static bool IsPlural(string word) => word[word.Length - 1] == 's';
}