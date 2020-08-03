/*
Find the Smallest and Biggest Numbers
Create a function that takes an array of numbers and return both the minimum and maximum numbers, in that order.

Examples
FindMinMax([1, 2, 3, 4, 5]) ➞ [1, 5]

FindMinMax([2334454, 5]) ➞ [5, 2334454]

FindMinMax([1]) ➞ [1, 1]
Notes
All test arrays will have at least one element and are valid.


*/








/*

Solution 1

*/


using System;
using System.Linq;
public class Program 
{
    public static double[] FindMinMax(double[] values) 
    {
				return new[] {values.Min(), values.Max()};
    }
}

/*

Solution 2

*/


public class Program 
{
    public static double[] FindMinMax(double[] values) => new[] {values.Min(), values.Max()};
}


/*

Solution 3

*/
public class Program 
{
    public static double[] FindMinMax(double[] values) 
    {
			Array.Sort(values);
      return new double[]{values[0], values[values.Length-1]};;
    }
}


/*

Solution 4

*/


public class Program
{
	public static double[] FindMinMax(double[] values)
	{
		double min_value = values[0];
		double max_value = values[0];

		foreach (double value in values)
		{
			if (value > max_value) max_value = value;
			if (value < min_value) min_value = value;
		}

		return new double[] {min_value,max_value };
	}
}



public class Program 
{
    public static double[] FindMinMax(double[] values) 
    {
			return new [] {values.Min(), values.Max()};
    }
}




public class Program 
{
    public static double[] FindMinMax(double[] values) => new double[]{values.Min(), values.Max()};
}



public class Program 
{
    public static double[] FindMinMax(double[] values) => new double[]{values.Min(),values.Max()};
}