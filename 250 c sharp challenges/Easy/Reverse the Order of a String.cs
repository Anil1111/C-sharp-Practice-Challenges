/*


Reverse the Order of a String
Create a function that takes a string as its argument and returns the string in reversed order.

Examples
Reverse("Hello World") ➞ "dlroW olleH"

Reverse("The quick brown fox.") ➞ ".xof nworb kciuq ehT"

Reverse("Edabit is really helpful!") ➞ "!lufpleh yllaer si tibadE"
Notes
You can expect a valid string for all test cases.
*/








/*

Solution 1

*/


using System.Linq;

public class Program 
{
    public static string Reverse(string str) 
    {
      return string.Concat(str.Reverse());
    }
}

/*

Solution 2

*/


public class Program 
{
    public static string Reverse(string str) => string.Concat(str.Reverse());
}


/*

Solution 3

*/

//using System;
public class Program 
{
    public static string Reverse(string str) 
    {
      char[] arr = str.ToCharArray();
      Array.Reverse(arr);
      return new string(arr);
    }
}

/*

Solution 4

*/

public class Program 
{
    public static string Reverse(string str) 
    {
      return String.Concat(str.Reverse());
    }
}



public class Program 
{
    public static string Reverse(string str) 
    {
      	return str.Reverse().Select(c => c.ToString()).Aggregate((a, b) => a + b);
    }
}


public class Program 
{
    public static string Reverse(string str) 
    {
      return new String( str.ToCharArray().Reverse().ToArray() );
    }
}



public class Program 
{
    public static string Reverse(string str) 
    {
      var arr = str.ToCharArray();
      Array.Reverse(arr);
      return new String(arr);
    }
}





public class Program 
{
    public static string Reverse(string str) => string.Join("", str.Reverse());
}
