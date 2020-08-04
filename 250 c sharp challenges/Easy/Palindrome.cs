/*


Palindrome?
A palindrome is a word that is identical forward and backwards.

mom
racecar
kayak
Given a word, create a function that checks whether it is a palindrome.

Examples
CheckPalindrome("mom") ➞ true

CheckPalindrome("scary") ➞ false

CheckPalindrome("reviver") ➞ true

CheckPalindrome("stressed") ➞ false
Notes
All test input is lower cased.
*/








/*

Solution 1

*/

using System.Linq;
public class Program
{
    public static bool CheckPalindrome(string str)
    {
			return str == string.Concat(str.Reverse());
    }
}


/*

Solution 2

*/

using System.Linq;
public class Program
{
    public static bool CheckPalindrome(string str)
    {
			return str == string.Concat(str.Reverse());
    }
}



/*

Solution 3

*/

public class Program
{
    public static bool CheckPalindrome(string str)
    {
			char[] arr = str.ToCharArray();
    	Array.Reverse(arr);
			string nstr = new string(arr);
			return str == nstr ? true : false;
    }
}

/*

Solution 4

*/


public class Program
{
    public static bool CheckPalindrome(string str)
    {
			var length = str.Length / 2;
			var lastPos = str.Length - 1;
			for(int i = 0; i < length; i++)
			{
				if(str[i] != str[lastPos - i])
				{
					return false;
				}
			}
			return true;
    }
}





public class Program
{
    public static bool CheckPalindrome(string str)
    {
			char[] array = str.ToCharArray();
            string returnString = "";
            for (int i = 0; i < array.Length; i++)
            {
                if (char.IsLetter(array[i]))
                 returnString += char.ToLower(array[i]);
            }
                return returnString.First() == returnString.Last();
    }
}