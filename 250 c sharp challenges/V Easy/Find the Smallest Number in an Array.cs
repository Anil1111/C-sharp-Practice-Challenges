/*

Find the Smallest Number in an Array
Create a function that takes an array of numbers and returns the smallest number in the set.

Examples
FindSmallestNum([34, 15, 88, 2]) ➞ 2

FindSmallestNum([34, -345, -1, 100]) ➞ -345

FindSmallestNum([-76, 1.345, 1, 0]) ➞ -76

FindSmallestNum([0.4356, 0.8795, 0.5435, -0.9999]) ➞ -0.9999

FindSmallestNum([7, 7, 7]) ➞ 7
Notes
Test cases contain decimals.
If you get stuck on a challenge, find help in the Resources tab.
If you're really stuck, unlock solutions in the Solutions tab.


*/











/*

Solution 1

*/


//using System.Linq;
public class Program 
{
    public static double FindSmallestNum(double[] arr) => arr.Min();

}




/*

Solution 2

*/


public class Program 
{
    public static double FindSmallestNum(double[] arr) 
    {
      double smolBoi = arr[0];
      
			for(int i = 1; i < arr.Length; i++) {
        if (arr[i] < smolBoi) {
          smolBoi = arr[i];
        }
      }
      return smolBoi;
    }
}






/*

Solution 3


*/


public class Program 
{
    public static double FindSmallestNum(double[] arr) 
    {
      double min = arr[0];
      foreach (double element in arr)
			{
    		if (element < min) { min = element; }
			}
      return min;
    }
}




//using System.Linq;

public class Program 
{
    public static double FindSmallestNum(double[] arr) 
    {
      return arr.OrderBy(n => n).First();
    }
}



public class Program 
{
    public static double FindSmallestNum(double[] arr) 
    {
      	double smallest = double.MaxValue;
      	foreach (double d in arr)
        {
          	smallest = smallest < d ? smallest : d;
        }
      	return smallest;
    }
}




public class Program 
{
    public static double FindSmallestNum(double[] arr) 
    {
      var min = arr[0];
      foreach(var a in arr){
        min = a < min ? a : min;
      }
      return min;
    }
}
