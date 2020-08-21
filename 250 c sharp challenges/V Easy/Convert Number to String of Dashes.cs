/*
Convert Number to String of Dashes
Create a function that takes a number (from 1 - 60) and returns a corresponding string of hyphens.

Examples
Go(1) ➞ "-"

Go(5) ➞ "-----"

Go(3) ➞ "---"
Notes
You will be provided integers ranging from 1 to 60.
Don't forget to return your result as a string.
If you get stuck on a challenge, find help in the Resources tab.
If you're really stuck, unlock solutions in the Solutions tab.


*/




//#############################################################
//#                        MY SOLUTIONS                       #
//#############################################################






/*

Solution 1

*/


using System;
public class Program
{
    public static string Go(int num)
    {
			return new String('-', num);
		}
}

/*

Solution 2

*/


public class Program
{
    public static string Go(int num)
    {
			string result = "";
			for(int i = 0; i < num; i++) {
				result += "-";
			}
			return result;
    }
}


/*

Solution 3

*/

public class Program
{
    public static string Go(int num)
    {
			  if (num == 1)
            return "-";
        else
            return "-" + Go(num - 1);
    }
}

/*

Solution 4

*/


public class Program
{
    public static string Go(int num)
    {
			string resultat = "";
			for(int x=0; x< num; x++)
			{
				resultat += "-";
			}
			return resultat;
    }
}





public class Program
{
    public static string Go(int num)
    {
			if(num>0&&num<=60)
				return new string('-',num);
			else return "";
    }
}





public class Program
{
    public static string Go(int num)
    {
			string d = "";
			for(int i = 0; i < num; i++)
				d = d +"-";
			return d;
    }
}