/*

Is the Word an Isogram?
An isogram is a word that has no repeating letters, consecutive or nonconsecutive. Create a function that takes a string and returns either true or false depending on whether or not it's an "isogram".

Examples
IsIsogram("Algorism") ➞ true

IsIsogram("PasSword") ➞ false
// Not case sensitive.

IsIsogram("Consecutive") ➞ false
Notes
Ignore letter case (should not be case sensitive).
All test cases contain valid one word strings.

*/








/*

Solution 1

*/

using System;
using System.Linq;
using System.Collections.Generic;
public class Program 
{
    public static bool IsIsogram(string str) 
    {
			return str.ToLower().Distinct().Count() == str.Length;
    }
}


/*

Solution 2

*/


public class Program 
{
    public static bool IsIsogram(string str) 
    {
			HashSet<char> hashSet = new HashSet<char>(str.ToLower());
			hashSet.Overlaps(str);
			return (hashSet.Count == str.Length);
    }
}


/*

Solution 3

*/

public class Program 
{
    public static bool IsIsogram(string str) 
    {
						IEnumerable<char> stringArr = str.ToLower().Distinct();
            return str.ToLower() == new string(stringArr.ToArray());
    }
}



/*

Solution 4

*/



public class Program 
{
    public static bool IsIsogram(string str) 
    {
			List<char> strL1 = new List<char>();
			foreach(char c in str) {
				strL1.Add(Char.ToLower(c));
			}
			List<char> strL2 = strL1.Distinct().ToList();
			
			if(string.Join("", strL2.ToArray()) == string.Join("", strL1.ToArray())) {
				return true;
			} else {
				return false;
			}
    }
}









public class Program 
{
    public static bool IsIsogram(string str) 
    {
		            var charArray = str.ToLower().ToCharArray();
            Array.Sort(charArray);

            for (int i = 0; i < str.Length - 1; i++)
            {
                if (charArray[i] == charArray[i + 1])
                    return false;
            }

            return true;
    }
}





public class Program 
{
	   public static bool IsIsogram(string str)
        {
           string st=str.ToLower();
					for (int i = 0; i < st.Length - 1; i++)
					{

							for (int j = i + 1; j < st.Length - 1; j++)
							{
									if (st[i]==st[j])
											return false;
							}
					}
					return true;
 		   }
}