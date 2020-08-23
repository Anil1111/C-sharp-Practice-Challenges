/*

ATM PIN Code Validation
ATM machines allow 4 or 6 digit PIN codes and PIN codes cannot contain anything but exactly 4 digits or exactly 6 digits. Your task is to create a function that takes a string and returns true if the PIN is valid and false if it's not.

Examples
ValidatePIN("1234") ➞ true

ValidatePIN("12345") ➞ false

ValidatePIN("a234") ➞ false

ValidatePIN("") ➞ false
Notes
Some test cases contain special characters.
Empty strings must return false.

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
    public static bool ValidatePIN(string pin) 
    {
		  return  (pin.Length == 4 || pin.Length == 6) && pin.All(char.IsDigit);    
    }
}


/*

Solution 2

*/



public class Program 
{
    public static bool ValidatePIN(string pin) 
    {
      return (pin.Length == 4 || pin.Length == 6) && pin.All(char.IsDigit);
    }
}


/*

Solution 3

*/
public class Program 
{
    public static bool ValidatePIN(string pin) 
    {
      if(pin.Length != 4 && pin.Length != 6)
        return false;
      foreach(char c in pin)
      {
        if(c < 48 || c > 57)
        {
          return false;
        }
      }
      return true;
    }
}




/*

Solution 4

*/


public class Program 
{
    public static bool ValidatePIN(string pin) 
    {
      if (pin?.Length == 0 || pin.Length == 5) return false;

            return pin.All(char.IsDigit);
    }
}




public class Program 
{
    public static bool ValidatePIN(string pin) 
    {
      if(pin.Length < 4 || pin.Length == 5 || pin.Length > 6)
				return false;
			
			for(int i=0;i<pin.Length;i++){
				if(System.Char.IsDigit(pin[i])){
					
				}
				else{
					return false;
				}
			}
			return true;
    }
}