/*


Maskify the String
Usually when you sign up for an account to buy something, your credit card number, phone number or answer to a secret question is partially obscured in some way. Since someone could look over your shoulder, you don't want that shown on your screen. Hence, the website masks these strings.

Your task is to create a function that takes a string, transforms all but the last four characters into "#" and returns the new masked string.

Examples
Maskify("4556364607935616") ➞ "############5616"

Maskify("64607935616") ➞ "#######5616"

Maskify("1") ➞ "1"

Maskify("") ➞ ""
Notes
The maskify function must accept a string of any length.
An empty string should return an empty string (fourth example above).
*/








/*

Solution 1

*/

using System;

public class Program 
{
    public static string Maskify(string str) 
    {
      char[] chars = str.ToCharArray();
      
      for(int i = 0; i < chars.Length - 4; i ++)
      {
        chars[i] = '#';
      }
      
      return new string(chars);
    }
}



/*

Solution 2

*/

public class Program
{
    public static string Maskify(string str) => str.Length <= 4
      ? str
      : $"{new string('#', str.Length - 4)}{str.Substring(str.Length - 4)}";
}




/*

Solution 3

*/

public class Program 
{
    public static string Maskify(string str) 
    {
      return string.Concat(str.Select((c,i) => str.Length-i > 4 ? '#' : c));
    }
}

/*

Solution 4

*/


public class Program 
{
    public static string Maskify(string str) 
    {
      var charArr = str.ToCharArray();
      var result = "";
      for (int i = 0; i < str.Length; i++)
      {
        if (i < str.Length - 4)
          result += "#";
        else          
        	result += charArr[i];
      }
      
      return result;
    }
}
