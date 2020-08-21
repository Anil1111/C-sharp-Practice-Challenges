/*

Perfect Number
Create a function that tests whether or not an integer is a perfect number. A perfect number is a number that can be written as the sum of its factors, excluding the number itself.

For example, 6 is a perfect number, since 1 + 2 + 3 = 6, where 1, 2, and 3 are all factors of 6. Similarly, 28 is a perfect number, since 1 + 2 + 4 + 7 + 14 = 28.

Examples
CheckPerfect(6) ➞ true

CheckPerfect(28) ➞ true

CheckPerfect(496) ➞ true

CheckPerfect(12) ➞ false

CheckPerfect(97) ➞ false

*/






//#############################################################
//#                        MY SOLUTIONS                       #
//#############################################################






/*

Solution 1

*/

using System;
using System.Collections.Generic;

public class Program 
{
    public static bool CheckPerfect(int num) 
    {
			List<int> factors = new List<int>();
			for(int i=1;i<num;i++){
				if(num%i==0){
					factors.Add(i);
				}
			}
			var total=0;
			for(int i=0;i<factors.Count;i++){
				total+=factors[i];
			}
			return total==num;
    }
}



/*

Solution 2

*/


using System;
using System.Collections.Generic;
using System.Linq;

public class Program 
{
    public static bool CheckPerfect(int num) 
    {
		return GetFactors(num).Sum() == num;
    }
  
  	public static List<int> GetFactors(int number) {
    	List<int> factors = new List<int>();
	  
		for(int factor = 1; factor < number; factor += 1) {
			if(number % factor == 0) {
				factors.Add(factor);
			}
		}
	  
    	return factors;
	}
}


/*

Solution 3

*/


using System.Collections.Generic;
using System;

public class Program 
{
    public static bool CheckPerfect(int num) 
    {
			int sum = 0;
			double sqrt = Math.Ceiling(Math.Sqrt(num));
			List<int> nums = new List<int>();
			for (int i = 1; i < sqrt; i++)
			{
				if (num % i == 0)
				{
					nums.Add(i);
					nums.Add(num/i);
				}
			}
			foreach (int val in nums)
			{
				sum += val;
			}
			return sum/2 == num;
    }
}



/*

Solution 4

*/