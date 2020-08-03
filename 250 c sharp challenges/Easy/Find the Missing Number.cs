/*

Find the Missing Number
Create a function that takes an array of numbers between 1 and 10 (excluding one number) and returns the missing number.

Examples
MissingNum([1, 2, 3, 4, 6, 7, 8, 9, 10]) ➞ 5

MissingNum([7, 2, 3, 6, 5, 9, 1, 4, 8]) ➞ 10

MissingNum([10, 5, 1, 2, 4, 6, 8, 3, 9]) ➞ 7
Notes
The array of numbers will be unsorted (not in order).
Only one number will be missing.

*/








/*

Solution 1

*/

using System.Linq;
public class Program 
{
    public static int MissingNum(int[] arr) 
    {
      return 55 - arr.Sum();
    }
}


/*

Solution 2

*/
public class Program 
{
    public static int MissingNum(int[] arr) 
    {
      return Enumerable.Range(1,10).First(i => !arr.Contains(i));
    }
}




/*

Solution 3

*/
public class Program 
{
    public static int MissingNum(int[] arr) 
      => new [] {1,2,3,4,5,6,7,8,9,10}.Except(arr).Single();
}


/*

Solution 4

*/


//using System.Collections.Generic;
//using System.Linq;
//using System;

public class Program 
{
    public static int MissingNum(int[] arr) 
    {
      	var list = arr.ToList();	
      	for (int i = 1; i < 11; i++)
        {
          	if (!list.Contains(i)) return i;
        }
      	throw new ArgumentException();
    }
}



public class Program 
{
    public static int MissingNum(int[] arr) => 55 - arr.Sum();
}