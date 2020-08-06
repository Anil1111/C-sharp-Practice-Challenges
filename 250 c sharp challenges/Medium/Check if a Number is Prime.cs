/*

Check if a Number is Prime
Create a function that outputs true if a number is prime, and false otherwise.

Examples
isPrime(31) ➞ true

isPrime(18) ➞ false

isPrime(11) ➞ true
Notes
A prime number has no other factors except 1 and itself.
1 is not considered a prime number.

*/








/*

Solution 1

*/
public class Program
{
	public static bool isPrime(int x)
	{
	 int i=2;
	 while (i++<=x && x%i!=0);
   return i==x;
	 
	}
}



/*

Solution 2

*/


public class Program
{
	public static bool isPrime(int x) {
		if ((x - 1) <= 1) return false;
        return AuxIsPrime(x, x - 1);
    }
    public static bool AuxIsPrime(int x, int n) {
        if (n <= 1) return true;
        else if (x % n == 0) return false;
        return AuxIsPrime(x, n - 1);
    }
}




/*

Solution 3

*/

public class Program
{
	public static bool isPrime(int x)
	{
		if (x <= 1) return false;

            for (int i = 2; i < Math.Sqrt(x); i++)
            {
                if (x % i == 0) return false;
            }
            return true;
	}
}

/*

Solution 4

*/



