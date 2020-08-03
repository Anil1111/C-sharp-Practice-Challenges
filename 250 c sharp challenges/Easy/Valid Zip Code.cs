/*

Valid Zip Code
Zip codes consist of 5 consecutive digits. Given a string, write a function to determine whether the input is a valid zip code. A valid zip code is as follows:

Must only contain numbers (no non-digits allowed).
Must not contain any spaces.
Must not be greater than 5 digits in length.
Examples
IsValid("59001") ➞ true

IsValid("853a7") ➞ false

IsValid("732 32") ➞ false

IsValid("393939") ➞ false
Notes

*/








/*

Solution 1

*/
using System;
public class Program
{
    public static bool IsValid(string zip)
    {
			int num;
            return (Int32.TryParse(zip, out num) && zip.Length == 5);
    }
}



/*

Solution 2

*/

using System.Text.RegularExpressions;
public class Program
{
    public static bool IsValid(string zip)
    {
			Match match = Regex.Match(zip, @"^\d{5}$");
			return match.Success;
    }
}


public class Program
{
    public static bool IsValid(string zip)
    {
			    bool result = zip.All(char.IsNumber);

          if (zip.Length > 5 || zip.Contains(' ') || result == false)
        	{
              return false;
          }
          return true;
    }
}




/*

Solution 3

*/
public class Program
{
    public static bool IsValid(string zip)
    {
			  try
        {
            return int.Parse(zip) <= 99999 && int.Parse(zip) >= 10000;
        }
        catch (Exception)
        {
            return false;
        }
    }
}


/*

Solution 4

*/



public class Program
{
    public static bool IsValid(string zip)
    {
			return zip.All(a=>char.IsDigit(a)) && zip.Length.Equals(5);
    }
}