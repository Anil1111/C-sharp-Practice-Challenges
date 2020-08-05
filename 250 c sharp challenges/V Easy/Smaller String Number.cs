/*

Smaller String Number
Create a function that returns the smaller number.

Examples
smallerNum("21", "44") ➞ "21"

smallerNum("1500", "1") ➞ "1"

smallerNum("5", "5") ➞ "5"
Notes
Numbers will be represented as strings, and your output should also be a string.
If both numbers tie, return either number.
Numbers will be positive.
Bonus: See if you can do this without converting to integers.

*/








/*

Solution 1

*/

using System;
public class Program
{
	public static string smallerNum(string n1, string n2)
	{
		return Int32.Parse(n1) > Int32.Parse(n2) ? n2 : n1;
	}
}



/*

Solution 2

*/


public class Program
{
	public static string smallerNum(string n1, string n2)
        {
    //without converting to int        
		if (n1.Length < n2.Length)
                return n1;
            else if (n1.Length > n2.Length)
                return n2;
            else
            {
                for (int i = 0; i < n1.Length; i++)
                {
                    if (n1[i] < n2[i])
                        return n1;
                    else if (n1[i] > n2[i])
                        return n2;
                }

                return n1;
            }

        }
}




/*

Solution 3

*/


public class Program
{
	public static string smallerNum(string n1, string n2)
	{
		string s;
		if(int.Parse(n1)<int.Parse(n2)) s=n1; else s=n2;
		return s;
	}
}



/*

Solution 4

*/