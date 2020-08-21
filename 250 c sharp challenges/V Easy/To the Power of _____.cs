/*
To the Power of _____
Create a function that takes a base number and an exponent number and returns the calculation.

Examples
СalculateExponent(5, 5) ➞ 3125

СalculateExponent(10, 10) ➞ 10000000000

СalculateExponent(3, 3) ➞ 27
Notes
All test inputs will be positive integers.
Don't forget to return the result.
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
    public static long CalculateExponent(long number, long exponent) 
    {
			return (long)Math.Pow(number, exponent);
    }
}



/*

Solution 2

*/


public class Program 
{
    public static long CalculateExponent(long number, long exponent) 
    {
			long result=number;
			for (;exponent>1;exponent--)
			{
				result*=number;
			}
			return result;
    }
}


/*

Solution 3

*/

public class Program 
{
    public static long CalculateExponent(long number, long exponent) 
    {
			return (long)Math.Pow((double)number, (double)exponent);
    }
}


/*

Solution 4

*/


public class Program 
{
    public static long CalculateExponent(long number, long exponent) 
    {
			long res=1;;
			for(int i = 0;i< exponent;i++){
				res*=number;
			}
			return res;
    }
}