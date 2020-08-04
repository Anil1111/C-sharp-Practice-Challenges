/*

Xs and Os, Nobody Knows
Create a function that takes a string, checks if it has the same number of x's and o's and returns either true or false.

Return a boolean value (true or false).
The string can contain any character.
When no x and no o are in the string, return true.
Examples
XO("ooxx") ➞ true

XO("xooxx") ➞ false

XO("ooxXm") ➞ true
// Case insensitive.

XO("zpzpzpp") ➞ true
// Returns true if no x and o.

XO("zzoo") ➞ false
Notes
Remember to return true if there aren't any x's or o's.
Must be case insensitive.

*/








/*

Solution 1

*/
using System.Linq;

public class Program 
{
    public static bool XO(string str)
      => str.Count(c => c == 'o' || c == 'O') == str.Count(c => c == 'x' || c == 'X');
}



/*

Solution 2

*/

public class Program 
{
    public static bool XO(string str) 
    {
        return str.Split('X', 'x').Length == str.Split('O', 'o').Length;
    }
}



/*

Solution 3

*/
public class Program 
{
    public static bool XO(string s) => 
      s.ToLower().Count(c => c == 'x') == s.ToLower().Count(c => c == 'o');
}


/*

Solution 4

*/


public class Program 
{
    public static bool XO(string str) 
    {
      	str = str.ToLower();
      	var i = 0;
      	foreach (var c in str.ToCharArray())
          if(c == 'x') i++; else if (c == 'o') i--;
        return i == 0;
    }
}




public class Program 
{
    public static bool XO(string str) 
    {
      var chars = str.ToLower().ToCharArray();
      int xCount = chars.Count(c=> c == 'x');
      int oCount = chars.Count(c=> c == 'o');
      return xCount == oCount;
    }
}




public class Program 
{
    public static bool XO(string str) 
    {
      return (str.Count(x => x.ToString().ToLower() == "x") == str.Count(o => o.ToString().ToLower() == "o"));
    }
}