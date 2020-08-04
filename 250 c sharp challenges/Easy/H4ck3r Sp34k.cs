/*

H4ck3r Sp34k
Create a function that takes a string as an argument and returns a coded (h4ck3r 5p34k) version of the string.

Examples
HackerSpeak("javascript is cool") ➞ "j4v45cr1pt 15 c00l"

HackerSpeak("programming is fun") ➞ "pr0gr4mm1ng 15 fun"

HackerSpeak("become a coder") ➞ "b3c0m3 4 c0d3r"
Notes
In order to work properly, the function should replace all "a"s with 4, "e"s with 3, "i"s with 1, "o"s with 0, and "s"s with 5.

*/








/*

Solution 1

*/

public class Program
{
    public static string HackerSpeak(string str)
    {
			return str.Replace("a", "4").Replace("e", "3").Replace("i", "1").Replace("o", "0").Replace("s", "5");
    }
}


/*

Solution 2

*/


using System.Collections.Generic;

public class Program
{
    public static string HackerSpeak(string str)
    {
	  	var replacements = new Dictionary<string, string>()
		{
		    { "a", "4" },
		    { "e", "3" },
		    { "i", "1" },
		    { "o", "0" },
		    { "s", "5" }
		};
	  
	  	foreach (var replace in replacements)
		{
			str = str.Replace(replace.Key, replace.Value);
		}
	  	
	  	return str;
    }
}


/*

Solution 3

*/
public class Program
{
    public static string HackerSpeak(string str)
    {
			str = str.Replace("a", "4");
			str = str.Replace("e", "3");
			str = str.Replace("i", "1");
			str = str.Replace("o", "0");
			str = str.Replace("s", "5");
			
			return str;
    }
}


/*

Solution 4

*/


using System.Linq;
public class Program
{
    public static string HackerSpeak(string str)
    {
			string returnStr=str.Replace("a","4").Replace("e","3").Replace("i","1").Replace("o","0").Replace("s","5");
			return returnStr;
    }
}




public class Program
{
    public static string HackerSpeak(string str)
    {
			return str.Replace("a", "4").Replace("e", "3").Replace("i", "1").Replace("o", "0").Replace("s", "5");
    }
}