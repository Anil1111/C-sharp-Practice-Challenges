/*


Repeating Letters
Create a function that takes a string and returns a string in which each character is repeated once.

Examples
DoubleChar("String") ➞ "SSttrriinngg"

DoubleChar("Hello World!") ➞ "HHeelllloo  WWoorrlldd!!"

DoubleChar("1234!_ ") ➞ "11223344!!__  "
Notes
All test cases contain valid strings. Don't worry about spaces, special characters or numbers. They're all considered valid characters.
*/








/*

Solution 1

*/
using System.Linq;
public class Program 
{
    public static string DoubleChar(string str) => string.Concat(str.Select(s=>$"{s}{s}"));
}




/*

Solution 2

*/

public class Program 
{
    public static string DoubleChar(string str) 
    {
      var finalStr = "";
      for(var i = 0; i < str.Length; i++){
        finalStr += str[i].ToString() + str[i].ToString();
      }
      return finalStr;
    }
}



/*

Solution 3

*/

//using System.Linq;

public class Program 
{
    public static string DoubleChar(string str) 
    {
      return string.Concat(str.SelectMany(c=>new []{c,c}));
    }
}



public class Program 
{
    public static string DoubleChar(string str) 
    {
      return string.Join("", str.Select(x => x.ToString() + x.ToString()));
    }
}

/*

Solution 4

*/


//using System;
//using System.Linq;

public class Program 
{
    public static string DoubleChar(string str) 
    {
      return String.Concat(str.Select(c => c.ToString() + c.ToString()));
    }
}



public class Program 
{
    public static string DoubleChar(string str) 
    {
			for(int i = 0; i < str.Length; i+=2)
			{
				str = str.Insert(i, str[i].ToString());
			}
			return str;
    }
}