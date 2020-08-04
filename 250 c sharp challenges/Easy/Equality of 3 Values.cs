/*

Equality of 3 Values
Create a function that takes three integer arguments (a, b, c) and returns the amount of integers which are of equal value.

Examples
Equal(3, 4, 3) ➞ 2

Equal(1, 1, 1) ➞ 3

Equal(3, 4, 1) ➞ 0
Notes
Your function must return 0, 2 or 3.

*/








/*

Solution 1

*/


public class Program
{
    public static int Equal(int a, int b, int c)
    {
			return (a==b && b==c) ? 3 : (a!=b && b!= c && a!=c) ? 0 : 2; 
    }
}

/*

Solution 2

*/


using System.Linq;
public class Program
{
    public static int Equal(int a, int b, int c)
    {
			int[] array=new int[]{a,b,c};
		 var count =  array.GroupBy(item => item).Where(item => item.Count() > 1).Sum(item => item.Count());
		return count;
    }
}


/*

Solution 3

*/

public class Program
{
    public static int Equal(int a, int b, int c)
    {
			var matches = 0;
			if(a == b) matches++;
			if(a == c) matches++;
			if(b == c) matches++;
			if(matches == 1)
				matches = 2;
			return matches;
    }
}

/*

Solution 4

*/


public class Program
{
    public static int Equal(int a, int b, int c)
    {
			if(a==b && b==c)
			{
				return 3;
			}
			else if(a==b || b==c || a==c)
			{
				return 2;
			}
			else
			{
				return 0;
			}
    }
}