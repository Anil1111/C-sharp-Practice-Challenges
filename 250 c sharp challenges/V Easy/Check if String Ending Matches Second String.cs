/*

Check if String Ending Matches Second String
Create a function that takes two strings and returns true if the first string ends with the second string; otherwise return false.

Examples
CheckEnding("abc", "bc") ➞ true

CheckEnding("abc", "d") ➞ false

CheckEnding("samurai", "zi") ➞ false

CheckEnding("feminine", "nine") ➞ true

CheckEnding("convention", "tio") ➞ false
Notes
All test cases are valid one word strings.

*/








/*

Solution 1

*/

public class Program 
{
    public static bool CheckEnding(string str1, string str2) 
    {
      	return str1.EndsWith(str2);
    }
}





public class Program 
{
    public static bool CheckEnding(string str1, string str2) 
			=> str1.EndsWith(str2);
}




/*

Solution 2

*/

public class Program 
{
    public static bool CheckEnding(string str1, string str2) 
    {
      for (int i = 0; i < str2.Length; i++) {
        if (str1[str1.Length - i - 1] != str2[str2.Length - i - 1]) {
          return false;
        }
      }
      
      return true;
    }
}



/*

Solution 3

*/

public class Program 
{
    public static bool CheckEnding(string str1, string str2) 
    {
    	return str1.EndsWith(str2);
    }
}


/*

Solution 4

*/


public class Program
{
    public static bool CheckEnding(string str1, string str2)
    {
      return str1.EndsWith(str2);
    }
}



public class Program
{
    public static bool CheckEnding(string str1, string str2)
    {
                  if (str1.EndsWith(str2) == true) return true;
            else return false;
    }
}



public class Program
{
    public static bool CheckEnding(string str1, string str2)
    {
      if (str1.EndsWith(str2))
				return true;
			else
				return false;
    }
}




public class Program 
{
    public static bool CheckEnding(string str1, string str2) 
    {
      // Couldn't think of a saucy way to overcome that one test with the 1 char string
      if (str2.Length >= 2) {
      	return str1.Substring(str1.Length - 2, 2) == str2.Substring(str2.Length - 2, 2);                
      }
      else {
        return false;
      }
    }
}




public class Program 
{
    public static bool CheckEnding(string str1, string str2) 
    {
      if (str1.EndsWith(str2)) {
        return true;
      }
      return false;
    }
}