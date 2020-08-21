/*

Remove All Special Characters from a String
Create a function that takes a string, removes all "special" characters (e.g. !, @, #, $, %, ^, &, \, *, (, )) and returns the new string. The only non-alphanumeric characters allowed are dashes -, underscores _ and spaces.

Examples
RemoveSpecialCharacters("The quick brown fox!") ➞ "The quick brown fox"

RemoveSpecialCharacters("%fd76$fd(-)6GvKlO.") ➞ "fd76fd-6GvKlO"

RemoveSpecialCharacters("D0n$c sed 0di0 du1") ➞ "D0nc sed 0di0 du1"
Notes

*/


//#############################################################
//#                        MY SOLUTIONS                       #
//#############################################################




/*

Solution 1

*/

using System;
using System.Linq;
using System.Text.RegularExpressions;

public class Program 
{
  public static string RemoveSpecialCharacters(string str) 
  {
		return string.Join("", str.Where(c => 
                                     Char.IsLetterOrDigit(c) ||
                                     Char.IsWhiteSpace(c) ||
                                     c == '-' ||
                                     c == '_'));
  }
}

/*

Solution 2

*/
using System.Text.RegularExpressions;
public class Program 
{
    public static string RemoveSpecialCharacters(string str) 
    {
      return Regex.Replace(str, "[^0-9A-Za-z _-]", "");
    }
}



/*

Solution 3

*/

using System;
using System.Linq;
public class Program 
{
    public static string RemoveSpecialCharacters(string str) 
    {
      return new string(str.Where(c => c >= 'a' && c <= 'z'
                                          || c >= 'A' && c <= 'Z'
                                          || c >= '0' && c <= '9'
                                          || c == '-' || c == '_' 
                                  				|| c == ' ').ToArray());
    }
}



/*

Solution 4

*/



using System.Text;
public class Program 
{
    public static string RemoveSpecialCharacters(string str) 
    {
      StringBuilder result = new StringBuilder();
			foreach(char item in str)
			{
				if(char.IsLetterOrDigit(item) || item == ' ' || item == '-' || item == '_')
					result.Append(item);
			}
			return result.ToString();
    }
}





using System.Linq;
public class Program 
{
    public static string RemoveSpecialCharacters(string str) 
    {
      return string.Concat(str.Where(ch => char.IsLetterOrDigit(ch)|| ch == ' ' || ch == '-' || ch =='_' ));
    }
}