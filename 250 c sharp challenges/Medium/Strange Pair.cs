/*

Strange Pair
A pair of strings form a strange pair if both of the following are true:

The 1st string's first letter = 2nd string's last letter.
The 1st string's last letter = 2nd string's first letter.
Create a function that returns true if a pair of strings constitutes a strange pair, and false otherwise.

Examples
IsStrangePair("ratio", "orator") ➞ true
// "ratio" ends with "o" and "orator" starts with "o".
// "ratio" starts with "r" and "orator" ends with "r".

IsStrangePair("sparkling", "groups") ➞ true

IsStrangePair("bush", "hubris") ➞ false

IsStrangePair("", "") ➞ true
Notes
It should work on a pair of empty strings (they trivially share nothing).

*/








/*

Solution 1

*/


public class Program
{
    public static bool IsStrangePair(string str1, string str2)
    {
			if(string.IsNullOrEmpty(str1) || string.IsNullOrEmpty(str2))
			{
				return str1 == str2;
			}
			
			return str1.First() == str2.Last()
				&& str2.First() == str1.Last();
    }
}



/*

Solution 2

*/

public class Program
{
    public static bool IsStrangePair(string str1, string str2)
    {
			if(str1.Length==0 && str2.Length==0)
			{
			return true;
    }
			else if(str1.Length!=0 && str2.Length!=0) 
				if (str1[0] == str2[str2.Length - 1] && str1[str1.Length - 1] == str2[0])
            {
                return true;
            }
				
			return false;
		}
}



/*

Solution 3

*/

public class Program
{
    public static bool IsStrangePair(string str1, string str2)
    {
			 if (str1.Length == 0 && str2.Length == 0)
                return true;
            else if (str1.Length == 0 && str2.Length != 0)
                return false;

            char a = str1.ToCharArray()[0];
            char b = str1.ToCharArray()[str1.Length - 1];
            char c = str2.ToCharArray()[0];
            char d = str2.ToCharArray()[str2.Length - 1];
         
             if (a==d&&b==c)
                return true;
            else
                return false;
    }
}

/*

Solution 4

*/



public class Program
{
    public static bool IsStrangePair(string str1, string str2)
    {
			if(string.IsNullOrWhiteSpace(str1) != string.IsNullOrWhiteSpace(str2))
			{
				return false;
			}
			
			if(str1.Length > 0 && str2.Length > 0)
			{
				return str1[0] == str2[str2.Length - 1] && str2[0] == str1[str1.Length - 1];
			}
			
			return true;
    }
}