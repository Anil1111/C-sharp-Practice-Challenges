/*

GCD of Two Numbers
Write a function that returns the greatest common divisor (GCD) of two integers.

Examples
gcd(32, 8) ➞ 8

gcd(8, 12) ➞ 4

gcd(17, 13) ➞ 1
Notes
Both values will be positive.
The GCD is the largest factor that divides both numbers.

*/








/*

Solution 1

*/

public class Program
{
	public static int gcd(int n1, int n2)
	{
		int temp = 0;
            for (int i = 1; i < 20; i++)
            {
                if (n1 % i == 0 && n2 % i == 0)
                {
                    temp = i;
                }
            }
            return temp;
	}
}


/*

Solution 2

*/


public class Program
{
	public static int gcd(int n1, int n2)
	{
			int divisor = n1 > n2 ? n2 : n1;
			for (int i = divisor; i > 0; i--)
			{
					if (n1%i == 0 && n2%i == 0) return i;
			}
			return 1;
	}
}




/*

Solution 3

*/


public class Program
{
	 public static int gcd(int n1, int n2)
        {
            int max;
            if (n1 >= n2) max = n1;
            else max = n2;

            int result = 1;
            for (int i = 2; i <= max; i++)
            {
                if (n1 % i == 0 && n2 % i == 0)
                    result = i;
            }

            return result;
        }
}



/*

Solution 4

*/


using System;
public class Program
{
	public static int gcd(int n1, int n2)
	{
		int num=Math.Min(n1,n2);
		for(int i=num;i>=1;i--){
			if(n1%i==0 && n2%i==0){
				return i;
			}
		}
		return num;
	}
}