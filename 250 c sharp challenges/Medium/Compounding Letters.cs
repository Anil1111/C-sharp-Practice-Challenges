/*

Compounding Letters
Create a function that takes a string and returns a new string with each new character accumulating by +1. Separate each set with a dash.

Examples
Accum("abcd") ➞ "A-Bb-Ccc-Dddd"

Accum("RqaEzty") ➞ "R-Qq-Aaa-Eeee-Zzzzz-Tttttt-Yyyyyyy"

Accum("cwAt") ➞ "C-Ww-Aaa-Tttt"
Notes
Capitalize the first letter of each set.
All tests contain valid strings with alphabetic characters (a-z, A-Z).

*/


//#############################################################
//#                        MY SOLUTIONS                       #
//#############################################################



/*

Solution 1

*/


public class Program 
{
    public static string Accum(string str) 
    {
			  string answer = "";
        for (int i = 0; i < str.Length; i++)
        {
            answer = answer +  char.ToUpper(str[i]) + new string(char.ToLower(str[i]), i) + '-';
        }

        return answer.Substring(0,answer.Length-1);
    }
}



/*

Solution 2

*/

public class Program 
{
    public static string Accum(string str) 
    {
		string temp = "";
            for (int i = 0; i < str.Length; i++)
            {
                for (int j = 1; j <= i + 1; j++)
                {
                    if (j == 1)
                    {
                        temp += str[i].ToString().ToUpper();
                    }
                    else
                    {
                        temp += str[i].ToString().ToLower();
                    }
                }
                if (i != str.Length - 1)
                {
                    temp += '-';
                }
            }
            return temp;
		}
}



/*

Solution 3

*/




using System.Collections.Generic;
using System.Linq;
public class Program 
{
    public static string Accum(string str) 
    {
			List<string> meList = new List<string>();
            for (int i = 0; i < str.Length; i++)
            {
                meList.Add(new string(str[i], i + 1).ToLower());
                meList[i]=char.ToUpper(meList[i].First())+meList[i].Substring(1,meList[i].Length-1);
            }
            return string.Join("-", meList);
    }
}




/*

Solution 4

*/


using System.Linq;
using System;
public class Program
{
    public static string Accum(string str)
    {
        char[] whey = str.ToCharArray();
        string[] wheywhey = new string[(str.Length*(str.Length+1)/2)+(str.Length-1)];
        for (int i = 0; whey.Length > i; i++)
        {
            if (i + 1 == whey.Length)
            {
                wheywhey[i] = whey[i].ToString().ToUpper() + new string(whey[i], i).ToLower();
            }
            else
            {
                wheywhey[i] = whey[i].ToString().ToUpper() + new string(whey[i], i).ToLower() + "-";
            }
           
            

        }
        return string.Join("", wheywhey);
    }
}