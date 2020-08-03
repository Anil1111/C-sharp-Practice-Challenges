/*
How Many Solutions Does This Quadratic Have?
A quadratic equation a x² + b x + c = 0 has either 0, 1, or 2 distinct solutions for real values of x. Given a, b and c, you should return the number of solutions to the equation.

Examples
solutions(1, 0, -1) ➞ 2
// x² - 1 = 0 has two solutions (x = 1 and x = -1).

solutions(1, 0, 0) ➞ 1
// x² = 0 has one solution (x = 0).

solutions(1, 0, 1) ➞ 0
// x² + 1 = 0 has no solutions.
Notes
You do not have to calculate the solutions, just return how many there are.
a will always be non-zero.


*/








/*

Solution 1

*/


public class Program {
	public static int solutions(int a, int b, int c) {
		int x = b*b - 4*a*c; return x > 0 ? 2 : x < 0 ? 0 : 1;
	}
}

/*

Solution 2

*/


public class Program {
	public static int solutions(int a, int b, int c) {
		int delta = b*b - 4*a*c;
		int nr = 0;
		if(delta > 0) nr = 2;
		else if(delta == 0) nr = 1;
		return nr;
	}
}


/*

Solution 3

*/



/*

Solution 4

*/