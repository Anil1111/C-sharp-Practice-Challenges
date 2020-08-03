/*

Return the Factorial
Create a function that takes an integer and returns the factorial of that integer. That is, the integer multiplied by all positive lower integers.

Examples
Factorial(3) ➞ 6

Factorial(5) ➞ 120

Factorial(13) ➞ 6227020800
Notes
Assume all inputs are greater than or equal to 0.

*/








/*

Solution 1

*/

public class Program
{
    public static int Factorial(int num)
    {
			if(num == 1)
				return 1;
			else
				return num * Factorial(num-1);
    }
}


/*

Solution 2

*/

public class Program
{
    public static int Factorial(int num)
    {
			if(num == 1){
				return num;
			}
			//Recursion: calls itself (below) until the base case
			//is met which is 1 then returns its value
			num = num * Factorial(num-1);
			return num;
    }
}



/*

Solution 3

*/


public class Program
{
    public static int Factorial(int num)
    {
			int baseNum = num;
			for (int i = 1; i < baseNum; i++) {
				num *= i;
			}
			return num;
    }
}



/*

Solution 4

*/




public class Program
{
    public static int Factorial(int num)
    {
			var total = 1;
			var times = 1;
			for (var a = 0; a < num; a++){
				total = total * times;
				times++;
			}
			return total;
    }
}






public class Program
{
    public static int Factorial(int num)
    {int fakt=1;
			
			for(int i=1;i<=num;i++)
			{
				
			 	fakt*=i;
				
			}return fakt;
    }
}




