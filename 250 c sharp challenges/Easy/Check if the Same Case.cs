/*

Check if the Same Case
Create a function that returns true if an input string contains only uppercase or only lowercase letters.

Examples
SameCase("hello") ➞ true

SameCase("HELLO") ➞ true

SameCase("Hello") ➞ false

SameCase("ketcHUp") ➞ false
Notes

*/








/*

Solution 1

*/

public class Program
{
    public static bool SameCase(string str)
    {
			return str==str.ToUpper() | str==str.ToLower();
    }
}


/*

Solution 2

*/


using System.Linq;
public class Program
{
    public static bool SameCase(string str)
    {
			 return str.All(x => char.IsUpper(x)) || str.All(x =>char.IsLower(x));
    }
}


/*

Solution 3

*/

using System.Text.RegularExpressions;

public class Program
{
    public static bool SameCase(string str)
    {
	  	return Regex.IsMatch(str, "^([a-z]*|[A-Z]*)$");
    }
}

/*

Solution 4

*/


public class Program
{
    public static bool SameCase(string str)
        {
            string checkUpper = str.ToUpper();
            string checkLower = str.ToLower();

            if (checkUpper == str || checkLower == str) return true;
            return false;
        }
}



using System.Linq;
public class Program
{
    public static bool SameCase(string str)
    {
        bool result = false;
        char[] huhu = str.ToCharArray();
        if (huhu.All(char.IsLower)==true || huhu.All(char.IsUpper) == true)
        {
            result = true;
        }
        return result;
    }
}








using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
public class Program
{
    public static bool SameCase(string str)
    {
			char[] x=str.ToCharArray();
			int upper=0;
			int lower=0;
			
			for (int i=0;i<str.Length;i++)
			{
				if (Char.IsUpper(x[i])) upper++;
				else if (Char.IsLower(x[i])) lower++;
			}
			
			if (lower==0 || upper==0)
				return true;
			else
				return false;
    }
}