/*

Difference of Max and Min Numbers in Array
Create a function that takes an array and returns the difference between the biggest and smallest numbers.

Examples
differenceMaxMin([10, 4, 1, 4, -10, -50, 32, 21]) ➞ 82
// Smallest number is -50, biggest is 32.

differenceMaxMin([44, 32, 86, 19]) ➞ 67
// Smallest number is 19, biggest is 86.
Notes


*/






//#############################################################
//#                        MY SOLUTIONS                       #
//#############################################################







/*

Solution 1

*/



//using System.Linq;
public class Program 
{
	public static int differenceMaxMin(int[] arr) 
	{
		return arr.Max() - arr.Min();
	}
}



public class Program 
{
	public static int differenceMaxMin(int[] arr) 
	{
		int max = arr[0];
		int min = arr[0];
		foreach(int number in arr)
		{
			max = number > max ? number : max;
			min = number < min ? number : min;
		}
		return max-min;
	}
}




//using System;

public class Program 
{
	public static int differenceMaxMin(int[] arr) 
	{
		int min = arr[0];
		int max = arr[0];
		
		foreach (int number in arr)
		{
			if (number < min)
			{
				min = number;
			}
			
			if (number > max)
			{
				max = number;
			}
		}
		
		return Math.Abs(min - max);
		
	}
}




/*

Solution 2

*/


//using System.Linq;
public class Program 
{
	public static int differenceMaxMin(int[] arr) 
	{
		return arr.Max() - arr.Min();
	}
}




/*

Solution 3


*/



//using System;
//using System.Linq;
public class Program 
{
	public static int differenceMaxMin(int[] arr) 
	{
		        int a = arr.Max();
            int b = arr.Min();

            int c = a - b;
            return c;
	}
}



//using System;
//using System.Linq;
public class Program 
{
	public static int differenceMaxMin(int[] arr) 
	{
		return arr.Min() < 0 ? Math.Abs(arr.Max()) + Math.Abs(arr.Min()) : arr.Max() - arr.Min();
	}
}