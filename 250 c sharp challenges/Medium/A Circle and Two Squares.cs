/*

A Circle and Two Squares
Imagine a circle and two squares: a smaller and a bigger one. For the smaller one, the circle is a circumcircle and for the bigger one, an incircle.

Scale

Create a function, that takes an integer (radius of the circle) and returns the difference of the areas of the two squares.

Examples
square_areas_difference(5) ➞ 50

square_areas_difference(6) ➞ 72

square_areas_difference(7) ➞ 98
Notes
Use only positive integer parameters.

*/








/*

Solution 1

*/

using System;

public class Program{
	public static int square_areas_difference(int radius)
	{
		int diameter =  2 * radius;
		
		return diameter * diameter / 2;
	}
}


/*

Solution 2

*/


public class Program{
  	public static int square_areas_difference(int radius) {
		return (int) Math.Pow(radius * 2, 2) / 2;
	}
}



/*

Solution 3

*/


public class Program{
  	public static int square_areas_difference(int radius) {
			var radSqr = Math.Pow(radius,2);
			var bigSquareArea = 4 * radSqr;
			// a^2 + b^2 = (2radius)^2
			// 2(a^2) = 4 * (radius)^2
			var smallSquareArea = 2 * radSqr;
			var diff = bigSquareArea - smallSquareArea;
			return (int)diff;
			
	}
}


/*

Solution 4

*/


public class Program {
	public static int square_areas_difference(int radius) => (int)Math.Round(Math.Pow(radius * 2, 2) - Math.Pow(Math.Sqrt(Math.Pow(radius, 2) * 2), 2));
}