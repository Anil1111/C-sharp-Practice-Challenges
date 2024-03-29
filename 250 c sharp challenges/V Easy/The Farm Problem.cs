/*

The Farm Problem
In this challenge, a farmer is asking you to tell him how many legs can be counted among all his animals. The farmer breeds three species:

chickens = 2 legs
cows = 4 legs
pigs = 4 legs
The farmer has counted his animals and he gives you a subtotal for each species. You have to implement a function that returns the total number of legs of all the animals.

Examples
animals(2, 3, 5) ➞ 36

animals(1, 2, 3) ➞ 22

animals(5, 2, 8) ➞ 50
Notes
Don't forget to return the result.
The order of animals passed is animals(chickens, cows, pigs).
Remember that the farmer wants to know the total number of legs and not the total number of animals.

*/



//#############################################################
//#                        MY SOLUTIONS                       #
//#############################################################





/*

Solution 1

*/

public class Program
{
	public static int animals(int chickens, int cows, int pigs)
	{
		int totalLegs = (2 * chickens)+ (4 * (cows + pigs));
		return totalLegs;
	}
}


/*

Solution 2

*/


public class Program
{
	public static int animals(int chickens, int cows, int pigs)
	{
		return 2*chickens + 4*cows + 4*pigs;
	}
}


/*

Solution 3

*/

public class Program
{
	public static int animals(int chickens, int cows, int pigs)
	{
		int res=((chickens*2)+(cows*4)+(pigs*4));
		return res;
	
	}
}

/*

Solution 4

*/


public class Program
{
	public static int chickenLegs = 2;
	public static int pigLegs = 4;
	public static int cowLegs = 4;
	
	public static int animals(int chickens, int cows, int pigs)
	{
		int totalLegs = (chickens*chickenLegs)+(cows*cowLegs)+(pigs*pigLegs);
		return totalLegs;
	}
	
	
	public void Start(){
		animals(2, 4, 4);
	}
}