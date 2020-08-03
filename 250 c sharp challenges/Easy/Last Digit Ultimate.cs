/*


Last Digit Ultimate
Your job is to create a function that takes 3 numbers: a, b, c and returns true if the last digit of (the last digit of a * the last digit of b) = the last digit of c. Check the examples below for an explanation.

Examples
LastDig(25, 21, 125) ➞ true
// The last digit of 25 is 5, the last digit of 21 is 1, and the last
// digit of 125 is 5, and the last digit of 5*1 = 5, which is equal
// to the last digit of 125 (5).

LastDig(55, 226, 5190) ➞ true
// The last digit of 55 is 5, the last digit of 226 is 6, and the last
// digit of 5190 is 0, and the last digit of 5*6 = 30 is 0, which is
// equal to the last digit of 5190 (0).

LastDig(12, 215, 2142) ➞ false
// The last digit of 12 is 2, the last digit of 215 is 5, and the last
// digit of 2142 is 2, and the last digit of 2*5 = 10 is 0, which is
// not equal to the last digit of 2142 (2).
Notes
If you still don't understand:
The last digit of a = x, the last digit of b = y, and the last digit of c = z.
Return true if the last digit of x*y is equal to z, and false otherwise.
Numbers can be negative.
*/








/*

Solution 1

*/
public class Program {
	public static bool LastDig(int a, int b, int c) {
		return a * b % 10 == c % 10;
	}
}



/*

Solution 2

*/

using System;
using System.Linq;

public class Program {
	public static bool LastDig(int a, int b, int c) {
		int d= a*b;
		return (c.ToString().ToCharArray().Last() == d.ToString().ToCharArray().Last());
	}
}



/*

Solution 3

*/
public class Program {
	public static bool LastDig(int a, int b, int c)
		=> ((a % 10) * (b % 10) % 10) == (c % 10);
}


/*

Solution 4

*/


public class Program {
	public static bool LastDig(int a, int b, int c)
		=> ((a % 10) * (b % 10) % 10) == (c % 10);
}