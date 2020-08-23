/*

Remove Every Vowel from a String
Create a function that takes a string and returns a new string with all vowels removed.

Examples
RemoveVowels("I have never seen a thin person drinking Diet Coke.")
➞ " hv nvr sn  thn prsn drnkng Dt Ck."

RemoveVowels("We're gonna build a wall!")
➞ "W'r gnn bld  wll!"

RemoveVowels("Happy Thanksgiving to all--even the haters and losers!")
➞ "Hppy Thnksgvng t ll--vn th htrs nd lsrs!"
Notes
"y" is not considered a vowel.
Expect a valid string for all test cases.

*/




//#############################################################
//#                        MY SOLUTIONS                       #
//#############################################################





/*

Solution 1

*/


using System.Linq;

public class Program 
{
    public static string RemoveVowels(string str) 
    {
      return string.Concat(str.Where(c => !"aeiou".Contains($"{c}".ToLower())));
    }
}

/*

Solution 2

*/



public class Program 
{
    public static string RemoveVowels(string str) => string.Concat(str.Select(s => "AEIOUaeiou".Contains(s) ? string.Empty : s.ToString()));
}

/*

Solution 3

*/


//using System.Linq;
//using System.Collections.Generic;
public class Program 
{
    public static string RemoveVowels(string str) 
    {
      var vowels = new List<char> { 'a', 'e', 'i', 'o', 'u' };
      return string.Join(string.Empty, str.Where(c => ! vowels.Contains(char.ToLower(c))));
    }
}


public class Program 
{
    public static string RemoveVowels(string str)
            => string.Concat(str.Where(s => !"aeiou".Contains(Char.ToLower(s))));
}




public class Program 
{
	 static char[] VOWELS = new char[] { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
    public static string RemoveVowels(string str) => string.Concat(str.Select(c => {
                if (!VOWELS.Contains(c))
                    return c;
                return (char) 0; }).Where((i) => i > 0) );
}







/*

Solution 4

*/


public class Program 
{
    public static string RemoveVowels(string str) 
    {
      return string.Concat(str.Select((c) => (Char.ToLower(c)=='a' || 
                                              Char.ToLower(c) == 'e' || 
                                              Char.ToLower(c) == 'i' ||
                                              Char.ToLower(c) == 'o' || 
                                              Char.ToLower(c) == 'u') ? $"" : $"{c}"));
    }
}





public class Program 
{
    public static string RemoveVowels(string str) 
    {
      var charsToRemove = new string[] { "a", "e", "i", "o", "u", "A", "E", "I", "O", "U" };
        foreach (var c in charsToRemove)
        {
            str = str.Replace(c, string.Empty);
        }
      return str;
    }
}

