/*

Find the Largest Numbers in a Group of Arrays
Create a function that takes an array of arrays with numbers. Return a new (single) array with the largest numbers of each.

Examples
FindLargest([[4, 2, 7, 1], [20, 70, 40, 90], [1, 2, 0]]) ➞ [7, 90, 2]

FindLargest([[-34, -54, -74], [-32, -2, -65], [-54, 7, -43]]) ➞ [-34, -2, 7]

FindLargest([[0.4321, 0.7634, 0.652], [1.324, 9.32, 2.5423, 6.4314], [9, 3, 6, 3]]) ➞ [0.7634, 9.32, 9]
Notes
Watch out for negative numbers.

*/








/*

Solution 1

*/

using System;
using System.Linq;
public class Program 
{
    public static double[] FindLargest(double[][] values) 
    {
				return  values.Select(v=>v.Max()).ToArray();
    }
}



/*

Solution 2

*/

//using System;
//using System.Linq;
public class Program 
{
    public static double[] FindLargest(double[][] values) 
    {
				double[] maxNumbers = new double[values.Length];
      	
      	int i = 0;
      	foreach(double[] array in values)
        {
          maxNumbers[i] = array.Max();
          i++;
        }
      
      	return maxNumbers;
    }
}



public class Program 
{
    public static double[] FindLargest(double[][] values) 
    {
      var outputArr = new double[values.Length];
      for (int i = 0; i < values.Length; i++) {
        outputArr[i] = values[i].Max();
      }
      return outputArr;
    }
}


/*

Solution 3

*/
public class Program 
{
    public static double[] FindLargest(double[][] values) 
    {
				var ret = new double[values.GetUpperBound(0)+1];
            for (int i = 0; i <= values.GetUpperBound(0); i++)
            {
                ret[i] = values[i].Max();
            }
            return ret;
    }
}


/*

Solution 4

*/



public class Program 
{
    public static double[] FindLargest(double[][] values) => values.Select(p => p.Max()).ToArray();    
}





public class Program 
{
    public static double[] FindLargest(double[][] values) 
    {
			double[] total = new double[values.Length];
			
			for(int x = 0; x < values.Length; x++)
			{
				total[x] = values[x].Max();
			}
			
			return total;
    }
}




public class Program 
{
    public static double[] FindLargest(double[][] values) 
    {
	  	double[] array = new double[values.Length];
	  	for (int i=0; i < values.Length; i++) {
		  	double largest = values[i][0];
		  	foreach (double num in values[i]) {
				if (largest < num)
				  largest = num;
		  	}
		  	array[i] = largest;
		}
	  	return array;
    }
}




public class Program 
{
    public static double[] FindLargest(double[][] values) 
    {
			List<double> arr = new List<double> ();
				for (int i = 0; i < values.Length; i++){
						arr.Add((from v in values[i] select v).Max());
					}
			return arr.ToArray();
    }
}





public class Program 
{
    public static double[] FindLargest(double[][] values) 
    {
				return values.Select(x => x).Select(y => y.Max()).ToArray();
    }
}





public class Program 
{
    public static double[] FindLargest(double[][] values) 
    {
				// Create new array
            var result = new double[3];
            for (int i = 0; i < values.Length; i++)
            {
                // Create new max value
                var maxValue = values[i][0];
                for (int y = 0; y < values[i].Length; y++)
                {
                    // Compare the values and find the largest
                    if (values[i][y] > maxValue)
                        maxValue = values[i][y];
                }
                // Assign max value to array;
                result[i] = maxValue;
            }

            return result;
    }
}