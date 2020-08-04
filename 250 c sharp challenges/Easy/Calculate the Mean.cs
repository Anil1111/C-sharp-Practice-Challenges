/*

Calculate the Mean
Create a function that takes an array of numbers and returns the mean value.

Examples
Mean([1, 0, 4, 5, 2, 4, 1, 2, 3, 3, 3]) ➞ 2.55

Mean([2, 3, 2, 3]) ➞ 2.50

Mean([3, 3, 3, 3, 3]) ➞ 3.00
Notes
Round to two decimal places.
You can expect a number ranging from 0 to 10,000.

*/








/*

Solution 1

*/


using System;
using System.Linq;

public class Program 
{
    public static double Mean(int[] arr) 
    {
      	return Math.Round(arr.Average(), 2);
    }
}

/*

Solution 2

*/
public class Program 
{
    public static double Mean(int[] arr) 
    {
			float sum = 0;
			float count = 0;
			
      for (int i = 0; i < arr.Length; i++)
			{
				Console.Write(arr[i]);
			}
			
			for (int i = 0; i < arr.Length; i++)
			{
				sum += arr[i];
				count++;
			}
			
			return sum/count;
			
    }
}




/*

Solution 3

*/
public class Program 
{
    public static double Mean(int[] arr) 
    {
      return (double)decimal.Round((decimal)arr.Average(), 2);
    }
}



/*

Solution 4

*/


public class Program 
{
    public static double Mean(int[] arr) 
    {
      var sum = 0;
			foreach (int i in arr)
			{
				sum += i;
			}
			return Math.Round(sum / (double) arr.Length, 2);
    }
}




public class Program 
{
    public static double Mean(int[] arr) 
    {
			double sum = 0;
			double total = 0;
			double mean = 0;
      foreach(var number in arr) {
				total = total + 1;
				sum = sum + number;
			}
			mean = sum / total;
			return Math.Round(mean, 2);
    }
}
