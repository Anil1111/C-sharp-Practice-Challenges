/*

Is the Input Factorial of an Integer?
Create a function that checks if a given integer is exactly the factorial of an integer or not. true if it is, false otherwise.

Examples
isFactorial(2) ➞ true
// 2 = 2 * 1 = 2!

isFactorial(27) ➞ false

isFactorial(24) ➞ true
// 24 = 4 * 3 * 2 * 1 = 4!
Notes
No error handling is necessary. Inputs are all positive integers.
Alternatively, you can solve this with a recursive approach.

*/






//#############################################################
//#                        MY SOLUTIONS                       #
//#############################################################






/*

Solution 1

*/

public class Program
{
    public static bool isFactorial(int n) 
		{
			int j = 1;
			for (int i = 1; i < n; i++) {
				j *= i;
				if (j == n)
				  return true;
			}	
			return false;
		}
}


/*

Solution 2

*/





/*

Solution 3

*/



/*

Solution 4

*/