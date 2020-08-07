/*

Pi to N Decimal Places
Given a number n, write a function that returns PI to n decimal places.

Examples
MyPi(5) ➞ 3.14159

MyPi(4) ➞ 3.1416

MyPi(15) ➞ 3.141592653589793
Notes
n will not be above 15, to keep this challenge simple.
Round up the last digit if the next digit in PI is greater or equal to 5 (see second example above).
The return value must be a number (add suffix -m to returning number), not a string.

*/








/*

Solution 1

*/


public class Program 
{
    public static decimal MyPi(int n) 
    {
    	return decimal.Round(3.1415926535897931m, n);
    }
}


/*

Solution 2

*/

public class Program 
{
    public static decimal MyPi(int n) => decimal.Round(decimal.Parse("3.141592653589793"), n);
}




/*

Solution 3

*/


public class Program 
{
    public static decimal MyPi(int n) 
    {
			if(n == 15)
			{
				return 3.1415926535897931m;
			}
    	decimal pi = Convert.ToDecimal(Math.Round(Math.PI, n));
			return pi;
    }
}


/*

Solution 4

*/


public class Program 
{
    public static decimal MyPi(int n) 
    {
			 decimal pi = 3.1415926535897931M;
            return (Math.Round(pi,n));
    }
}






public class Program 
{
    public static decimal MyPi(int n) 
    {
    	decimal pi = 3.14159265358979323846m;
			return Math.Round(pi, n);
    }
}