/*
Return the Highest and Lowest Numbers
Create a function that accepts a string of space separated numbers and returns the highest and lowest number (as a string).

Examples
HighLow("1 2 3 4 5") ➞ "5 1"

HighLow("1 2 -3 4 5") ➞ "5 -3"

HighLow("1 9 3 4 -5") ➞ "9 -5"

HighLow("13") ➞ "13 13"
Notes
All numbers are valid Int32, no need to validate them.
There will always be at least one number in the input string.
Output string must be two numbers separated by a single space, and highest number is first.

*/




//#############################################################
//#                        MY SOLUTIONS                       #
//#############################################################





/*

Solution 1

*/

using System.Linq;
public class Program
{
    public static string HighLow(string str) 
		=> $"{str.Split(' ').Select(a=>int.Parse(a)).Max()} {str.Split(' ').Select(a=>int.Parse(a)).Min()}";
}


/*

Solution 2

*/

public class Program 
{
    public static string HighLow(string str) 
    {
      List<int> ints = new List<int>();
      List<string> listStrLineElements = str.Split(' ').ToList();
      foreach (string number in listStrLineElements){
        ints.Add(int.Parse(number));
      }
      // go through number list now and take out min and max
      int min =ints[0];
      int max = ints[0];
      foreach(int num in ints){
        if (min > num){
          min =num;
        }
        else if (max < num){
          max = num;
        }
        }
    return max.ToString() + " " + min.ToString();
    }
    }




/*

Solution 3

*/


public class Program 
{
    public static string HighLow(string str) 
    {
      var nums = str.Split(' ').Select(s => int.Parse(s));
      return $"{nums.Max()} {nums.Min()}";
    }
}





public class Program 
{
    public static string HighLow(string str) 
    {
      var arr = str.Split(' ').Select(int.Parse).ToArray();
      return arr.Max() + " " + arr.Min();
    }
}



/*

Solution 4

*/


public class Program 
{
    public static string HighLow(string str) 
    {
  			var ints = str.Split(' ').Select(s => int.Parse(s));
      	return ints.Max() + " " + ints.Min();
    }
}