/*

Factorial Number
Create a Fact method that receives a non-negative integer and returns the factorial of that number.

Examples
Fact(1) ➞ 1

Fact(3) ➞ 6

Fact(6) ➞ 720
Notes
Consider that 0! = 1.
You should return a long data type number.

*/





//#############################################################
//#                        MY SOLUTIONS                       #
//#############################################################




/*

Solution 1

*/

public class Program
{
    public static long Fact(int n)
    {
				long total = 1;
				for (int i = n; i > 0; i--)
				{
						total *= i;
				}
				return total;
    }
}


/*

Solution 2

*/

public class Program
{
	public static long Fact(int n)
		=> n <= 1 ? 1 : n * Fact(n - 1);
}



/*

Solution 3

*/

public class Program
{
    public static long Fact(int n)
    {
			long m=1;
			for(int i=1;i<=n;i++){
				m*=i;
			}
			return m;
		
    }
}

/*

Solution 4

*/


//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

public class Program
{
    public static long Fact(int n)
    {
		            long j = 1;
            for(int i = n; i > 0; i--)
            {
                j *= Convert.ToInt64(i);
            }
            return j;
    }
}



public class Program
{
    public static long Fact(int n)
    {
		 long factorialNumber = 1;
            for (int i = 1; i <= n; i++)
            {
                factorialNumber = factorialNumber * i;
            }
			return factorialNumber;
    }
}




public class Program
{
    public static long Fact(int n)
    {
			return n > 0 ? n * Fact(n - 1) : 1;
    }
}




public class Program
{
    public static long Fact(int n)
    {
			if (n < 0) throw new ArgumentException("Input should be non-negative");
			if (n == 0) return 1;

			long fact = 1;
			for (var i = 1; i <= n; i++)
					fact *= i;
			return fact;
    }
}