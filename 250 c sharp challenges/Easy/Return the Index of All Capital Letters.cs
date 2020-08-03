/*

Return the Index of All Capital Letters
Create a function that takes a single string as argument and returns an ordered array containing the indices of all capital letters in the string.

Examples
IndexOfCapitals("eDaBiT") ➞ [1, 3, 5]

IndexOfCapitals("eQuINoX") ➞ [1, 3, 4, 6]

IndexOfCapitals("determine") ➞ []

IndexOfCapitals("STRIKE") ➞ [0, 1, 2, 3, 4, 5]

IndexOfCapitals("sUn") ➞ [1]
Notes
Return an empty array if no uppercase letters are found in the string.
Special characters ($#@%) and numbers will be included in some test cases.

*/








/*

Solution 1

*/

using System;
using System.Linq;
using System.Collections.Generic;
public class Program 
{
    public static int[] IndexOfCapitals(string str) 
    {
       return str.Select((x, i) => i).Where(i => char.IsUpper(str[i])).ToArray();
    }
}


/*

Solution 2

*/

public class Program 
{
    public static int[] IndexOfCapitals(string str) 
    {
				return str.Where(x => char.IsLetter(x) && x == char.ToUpper(x))
					.Select(x => str.IndexOf(x)).ToArray();
    }
}



/*

Solution 3

*/


public class Program 
{
    public static int[] IndexOfCapitals(string str) 
    {
      List<int> result = new List<int>();
			
			for(int i = 0; i < str.Length; i++)
			{
				if(char.IsUpper(str[i]))
					result.Add(i);
			}
			
			return result.ToArray();
    }
}
/*

Solution 4

*/