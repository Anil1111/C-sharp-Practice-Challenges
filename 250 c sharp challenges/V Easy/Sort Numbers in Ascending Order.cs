/*

Sort Numbers in Ascending Order
Create a function that takes an array of numbers and returns a new array, sorted in ascending order (smallest to biggest).

Sort the numbers array in ascending order.
If the function's argument is null, an empty array, or undefined; return an empty array.
Return a new array of sorted numbers.
Examples
SortNumsAscending([1, 2, 10, 50, 5]) ➞ [1, 2, 5, 10, 50]

SortNumsAscending([80, 29, 4, -95, -24, 85]) ➞ [-95, -24, 4, 29, 80, 85]

SortNumsAscending(null) ➞ []

SortNumsAscending([]) ➞ []
Notes
Test input can be positive or negative.

*/








/*

Solution 1

*/


using System;
public class Program
    {
        public static int[] SortNumsAscending(int[] arr)
        {
          Array.Sort(arr);
					return arr;
        }
    }




/*

Solution 2

*/

//using System.Linq;
public class Program
    {
        public static int[] SortNumsAscending(int[] arr)
        {
          return arr.OrderBy(x=>x).ToArray();
        }
    }






public class Program
    {
        public static int[] SortNumsAscending(int[] arr)
        {
          return arr.OrderBy(x=>x).ToArray();
        }
    }




/*

Solution 3

*/

public class Program
    {
        public static int[] SortNumsAscending(int[] arr) => arr?.OrderBy(i=>i).ToArray();
    }




/*

Solution 4

*/


public class Program
    {
        public static int[] SortNumsAscending(int[] arr)
        {
          	if (arr == null){
              	return new int[0];
            }
          	System.Array.Sort(arr);
          	return arr;
        }
    }






    public class Program
    {
        public static int[] SortNumsAscending(int[] arr)
        {
          return arr.OrderBy(n => n).ToArray();
        }
    }




    public class Program
    {
        public static int[] SortNumsAscending(int[] arr)
        {
          return arr.OrderBy(s => s).ToArray();
        }
    }





public class Program
    {
        public static int[] SortNumsAscending(int[] arr)
    {
      Array.Sort(arr);
      return (arr.Length == 0 || arr == null)? new int[0]: arr;
    }
    }





///using System.Linq;
///using System.Collections.Generic;
public class Program
    {
        public static int[] SortNumsAscending(int[] arr)
        {
          if (arr==null || arr.Length==0)
            return new int[0];
          List<int> nums=new List<int>(arr);
          nums.Sort();
          return nums.ToArray();
        }
    }





    public class Program
    {
        public static int[] SortNumsAscending(int[] arr)
        {
            return arr.OrderByDescending(e => e).Reverse().ToArray();
        }
    }





    public class Program
    {
        public static int[] SortNumsAscending(int[] arr)
        {
          return arr.OrderBy(x => x).ToArray();
        }
    }