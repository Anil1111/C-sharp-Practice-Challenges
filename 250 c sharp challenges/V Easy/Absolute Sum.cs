/*

Absolute Sum
Take an array of integers (positive or negative or both) and return the sum of the absolute value of each element.

Examples
getAbsSum([2, -1, 4, 8, 10]) ➞ 25

getAbsSum([-3, -4, -10, -2, -3]) ➞ 22

getAbsSum([2, 4, 6, 8, 10]) ➞ 30

getAbsSum([-1]) ➞ 1
Notes
The term "absolute value" means to remove any negative sign in front of a number, and to think of all numbers as positive (or zero).

*/




//#############################################################
//#                        MY SOLUTIONS                       #
//#############################################################




/*

Solution 1

*/
using System;
using System.Linq;

public class Program 
{
    public static int GetAbsSum(int[] arr) 
    {
      	return arr.Select(Math.Abs).Sum();
    }
}



/*

Solution 2

*/

//using System.Linq;
using static System.Math;

public class Program 
{
    public static int GetAbsSum(int[] arr) 
    {
      return arr.Sum(n => Abs(n));
    }
}




/*

Solution 3

*/

public class Program 
{
    public static int GetAbsSum(int[] arr) 
    {
      var sum = 0;
      foreach(var a in arr){
        sum += Math.Abs(a);
      }
      return sum;
    }
}






public class Program 
{
    public static int GetAbsSum(int[] arr) => arr.Sum(i => Math.Abs(i));
}



/*

Solution 4

*/



public class Program 
{
    public static int GetAbsSum(int[] arr) 
    {
      int sum = 0;
      for (int i = 0; i < arr.Length; i++) {
        if (arr[i] < 0) {
          sum = sum + (arr[i] * -1);
        }
        else {
          sum = sum + arr[i];
        }
          
      }
      
      return sum;
      
    }
}



public class Program 
{
    public static int GetAbsSum(int[] arr) 
    	=> arr.Sum(Math.Abs);
}



public class Program {
    public static int GetAbsSum(int[] arr) {
			int n = 0;
			
      foreach (int num in arr) {
				n += Math.Abs(num);
			}
			
			return n;
    }
}



public class Program 
{
    public static int GetAbsSum(int[] arr) 
    {
      return arr.Sum(x => x < 0 ? -x : x);
    }
}




public class Program 
{
    public static int GetAbsSum(int[] arr) 
    {
      return arr.Sum(nr => Math.Abs(nr));
    }
}



public class Program 
{
    public static int GetAbsSum(int[] arr) 
    {
      	return arr.Select(i => i < 0 ? -i : i).Sum();
    }
}