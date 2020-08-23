/*

Return the Middle Character(s) of a String
Create a function that takes a string and returns the middle character(s). If the word's length is odd, return the middle character. If the word's length is even, return the middle two characters.

Examples
GetMiddle("test") ➞ "es"

GetMiddle("testing") ➞ "t"

GetMiddle("middle") ➞ "dd"

GetMiddle("A") ➞ "A"
Notes
All test cases contain a single word (as a string).

*/



//#############################################################
//#                        MY SOLUTIONS                       #
//#############################################################




/*

Solution 1

*/
public class Program 
{
    public static string GetMiddle(string str) 
    {
      int i = 1 - str.Length % 2;
      return str.Substring(str.Length/2 - i, 1 + i);
    }
}



/*

Solution 2

*/

public class Program 
{
   public static string GetMiddle(string str)
        {
            return str.Substring((str.Length - 1 )/ 2, 2 - (str.Length % 2));
        }
}




/*

Solution 3

*/

public class Program 
{
    public static string GetMiddle(string str) 
    {
      if(str.Length%2==0)
      {
        return str.Substring((str.Length/2)-1, 2);
      }
      else
      {
        return str.Substring(str.Length/2, 1);
      }
    }
}


/*

Solution 4

*/


public class Program 
{
    public static string GetMiddle(string str) 
    {
      if (str.Length == 1) { return str; }  
      if(((str.Length)%2) == 0){
				return str.Substring((str.Length/2)-1,2);
      }
      else { return str.Substring(str.Length/2,1);}
    }
}