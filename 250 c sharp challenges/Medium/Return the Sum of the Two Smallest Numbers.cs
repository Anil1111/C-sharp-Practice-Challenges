/*

Return the Sum of the Two Smallest Numbers
Create a function that takes an array of numbers and returns the sum of the two lowest positive numbers.

Examples
SumSmallest([19, 5, 42, 2, 77]) ➞ 7

SumSmallest([10, 343445353, 3453445, 3453545353453]) ➞ 3453455

SumSmallest([2, 9, 6, -1]) ➞ 8

SumSmallest([879, 953, 694, -847, 342, 221, -91, -723, 791, -587]) ➞ 563

SumSmallest([3683, 2902, 3951, -475, 1617, -2385]) ➞ 4519
Notes
Don't count negative numbers.
Floats and empty arrays will not be used in any of the test cases.

*/








/*

Solution 1

*/


using System;
using System.Linq;
public class Program 
{
    public static int SumSmallest(int[] values) 
    {
			return values.Where(x=>x>=0).OrderBy(x=>x).Take(2).Sum();
		}
}


/*

Solution 2

*/

public class Program 
{
    public static int SumSmallest(int[] values) 
    {
				Array.Sort(values);
				return values.SkipWhile(x => x <= 0).Take(2).Sum();
    }
}




/*

Solution 3

*/

public class Program 
{
    public static int SumSmallest(int[] values) 
    {
			int result = 0, count = 0;
			Array.Sort(values);
			for(int i = 0; i < values.Length && count < 2; i++)
			{
				if(values[i] >= 0)
				{
					result += values[i];
					count++;
				}
			}
			return result;
    }
}

/*

Solution 4

*/


public class Program 
{
    public static int SumSmallest(int[] values) 
    {
			var positiveValues = values.OrderBy(num => num).Where(x => x > 0);
            return positiveValues.Min() + positiveValues.ElementAt(1);
    }
}




public class Program 
{
			public static int SumSmallest(int[] values)
			{
					int[] sortedValues = values.Where(x => x >= 0).OrderBy(x => x).ToArray();

					return sortedValues[0] + sortedValues[1];
			}
}




public class Program 
{
    public static int SumSmallest(int[] values) 
    {
		Array.Sort(values);
			int sumo = 0;
			for(int i = 0 ; i < values.Length; i++ ){
				if(values[i] > 0) {
				sumo = values[i] + values[i+1];
					break;
				}
			}
			return sumo;	
			
		
			
    }
}





public class Program 
{
	
    public static int SumSmallest(int[] values) 
    {
			int min1 = values.Where(i => i > 0).DefaultIfEmpty(0).Min();
			int min2 = values.Where(i => i > min1).DefaultIfEmpty(min1).Min();
			return min1+min2;
    }
}