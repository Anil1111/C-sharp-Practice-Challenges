/*
Sort Numbers in Descending Order
Create a function that takes any nonnegative number as an argument and return it with it's digits in descending order. Descending order is when you sort from highest to lowest.

Examples
SortDescending(123) ➞ 321

SortDescending(2619805) ➞ 9865210

SortDescending(73065) ➞ 76530
Notes
You can expect non-negative numbers for all test cases.


*/




//#############################################################
//#                        MY SOLUTIONS                       #
//#############################################################





/*

Solution 1

*/

using System.Linq;
using System;

public class Program 
{
    public static int SortDescending(int num) 
    {
      return Convert.ToInt32(String.Concat(num.ToString().OrderByDescending(c => c)));
    }
}


/*

Solution 2

*/

public class Program 
{
    public static int SortDescending(int num) 
    {
      var x = num.ToString().ToList();
            x.Sort();
            x.Reverse();
            string ret = String.Empty;
            foreach (var n in x)
            {
                ret += n;
            }
            return Convert.ToInt32(ret);
    }
}



/*

Solution 3

*/

public class Program 
{
    public static int SortDescending(int num) 
    {
      return int.Parse(string.Concat(num.ToString().OrderByDescending(c=>int.Parse(c.ToString()))));
    }
}





public class Program 
{
    public static int SortDescending(int num) 
      => int.Parse(string.Concat(num.ToString().OrderByDescending(x=>x)));
}





/*

Solution 4

*/



public class Program 
{
    public static int SortDescending(int num)
      => int.Parse(string.Concat(num.ToString().OrderByDescending(a=>a)));
}






public class Program 
{
    public static int SortDescending(int num) 
    {
      string temp = num.ToString();
            char[] charr = temp.ToCharArray();
            Array.Sort(charr);
            string result = "";

            for (int i = temp.Length - 1; i >= 0; i--)
            {
                result += charr[i];
            }           

            return Int32.Parse(result);
    }
}







public class Program 
{
    public static int SortDescending(int num) 
    {
      string str = "";
      char[] arr = num.ToString().ToArray();
      Array.Sort(arr);
      Array.Reverse(arr);
      
      for(int i = 0; i < arr.Length; i++)
      {
        str += arr[i].ToString();
      }
      int result = int.Parse(str);
      return result;
    }
}







public class Program 
{
    public static int SortDescending(int num) =>
      int.Parse(string.Join("", num.ToString().OrderByDescending(x => x)));
}
