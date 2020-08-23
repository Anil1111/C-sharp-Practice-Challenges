/*

Positive Count / Negative Sum
Create a function that takes an array of positive and negative numbers. Return an array where the first element is the count of positive numbers and the second element is the sum of negative numbers.

Examples
CountPosSumNeg([1, 2, 3, 4, 5, 6, 7, 8, 9, 10, -11, -12, -13, -14, -15]) ➞ [10, -65]
// There are a total of 10 positive numbers.
// The sum of all negative numbers equals -65.

CountPosSumNeg([92, 6, 73, -77, 81, -90, 99, 8, -85, 34]) ➞ [7, -252]

CountPosSumNeg([91, -4, 80, -73, -28]) ➞ [2, -105]

CountPosSumNeg([]) ➞ []
Notes
If given an empty array, return an empty array: []
Cast sum to int, don't mind the remaining decimal places.
0 is not positive.

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
    public static int[] CountPosSumNeg(double[] arr)
    {
      return (arr.Length == 0)? new int[0] : new int[]{ arr.Count(x => x > 0), (int)arr.Where(y => y <= 0).Aggregate((a, b) => a + b) };
    }
}







/*

Solution 2

*/



public class Program 
{
    public static int[] CountPosSumNeg(double[] arr) 
    {
      if(arr.Length == 0)
        return new int[0];
      int posCount = arr.Where(n => n > 0).Count();
            int negSum = (int)arr.Where(n => n < 0).Sum();
            return new int[2] { posCount, negSum };
    }
}










/*

Solution 3

*/





using System.Linq;
public class Program 
{
    public static int[] CountPosSumNeg(double[] nums) 
    {
      	if (!nums.Any()) return new int[0];
      	var pos = nums.Where(n => n > 0);
      	var neg = nums.Where(n => n < 0);
      	return new int[2]{pos.Count(), (int)neg.Sum()};
    }
}






/*

Solution 4

*/