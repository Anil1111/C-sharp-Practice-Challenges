/*

Is the Phone Number Formatted Correctly?
Create a function that accepts a string and returns true if it's in the format of a proper phone number and false if it's not. Assume any number between 0-9 (in the appropriate spots) will produce a valid phone number.

This is what a valid phone number looks like:

(123) 456-7890
Examples
IsValidPhoneNumber("(123) 456-7890") ➞ true

IsValidPhoneNumber("1111)555 2345") ➞ false

IsValidPhoneNumber("098) 123 4567") ➞ false
Notes
Don't forget the space after the closing parentheses.

*/








/*

Solution 1

*/

using System.Text.RegularExpressions;

public class Program 
{
    public static bool IsValidPhoneNumber(string str) => 
      Regex.IsMatch(str, @"^\(\d{3}\) \d{3}\-\d{4}$");
}


/*

Solution 2

*/


public class Program 
{
    public static bool IsValidPhoneNumber(string str)
      => new Regex(@"^\(\d{3}\) \d{3}-\d{4}$").IsMatch(str);
}



/*

Solution 3

*/

public class Program 
{
    public static bool IsValidPhoneNumber(string str) 
    {
      string correct = "(123) 456-7890";
      return str.Length == correct.Length && 
        correct.Zip(str, (a,b) => char.IsDigit(a) ? char.IsDigit(b) : a == b).All(b=>b);
    }
}




/*

Solution 4

*/


public class Program 
{
    public static bool IsValidPhoneNumber(string str) 
    {
      var numberMask = "^\\(\\d{3}\\) \\d{3}-\\d{4}$";
      return Regex.IsMatch(str, numberMask, RegexOptions.Compiled); 
    }
}
