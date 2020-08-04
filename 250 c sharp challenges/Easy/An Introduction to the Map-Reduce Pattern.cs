/*

An Introduction to the Map-Reduce Pattern
You will be implementing a basic case of the map-reduce pattern in programming. Given a vector stored as an array of numbers, find the magnitude of the vector. Use the standard distance formula for n-dimensional Cartesian coordinates.

Examples
Magnitude([3, 4]) ➞ 5

Magnitude([0, 0, -10]) ➞ 10

Magnitude([]) ➞ 0

Magnitude([2, 3, 6, 1, 8] ) ➞ 10.677078252031311
Notes
The array can have any length.
The input array will contain integers (except for empty array [] ➞ 0).
Write own .map() and .reduce() methods in your solution or use these query through LINQ (don't forget to connect the library System.Linq).
*/








/*

Solution 1

*/

using System.Linq;
using System;
public class Program 
{
    public static double Magnitude(int[] arr) 
			=> Math.Sqrt(arr.Sum(a=>a*a));
}


/*

Solution 2

*/


public class Program 
{
    public static double Magnitude(int[] arr) => Math.Sqrt(arr.Select(a => a*a).Sum());
}



/*

Solution 3

*/

public class Program 
{
    public static double Magnitude(int[] arr) 
    {
      return Sqrt(arr.Sum(n => n*n));
    }
}

/*

Solution 4

*/


public class Program 
{
    public static double Magnitude(int[] arr) 
    {
      	var quads = arr.Select(n => n*n);
      	var quadSum = quads.Sum();
      	return Math.Sqrt(quadSum);
    }
}