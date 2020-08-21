/*

Hurdle Jump
Create a function that takes an array of hurdle heights and a jumper's jump height, and determine whether or not the hurdler can clear all the hurdles.

A hurdler can clear a hurdle if their jump height is greater than or equal to the hurdle height.

Examples
hurdleJump([1, 2, 3, 4, 5], 5) ➞ true

hurdleJump([5, 5, 3, 4, 5], 3) ➞ false

hurdleJump([5, 4, 5, 6], 10) ➞ true

hurdleJump([1, 2, 1], 1) ➞ false
Notes
Return true for the edge case of an empty array of hurdles. (Zero hurdles means that any jump height can clear them).

*/



//#############################################################
//#                        MY SOLUTIONS                       #
//#############################################################




/*

Solution 1

*/


using System.Linq;
public class Program
{
	public static bool hurdleJump(int[] hurdles, int jumpHeight)
	{
		return hurdles.Length == 0 ? true : jumpHeight >= hurdles.Max();
	}
}

/*

Solution 2

*/


using System.Linq;
public class Program
{
	public static bool hurdleJump(int[] hurdles, int jumpHeight)
	{
		return hurdles.All(a=>a <= jumpHeight);
	}
}




using System.Linq;

public class Program
{
	public static bool hurdleJump(int[] hurdles, int jumpHeight)
	{
		if (hurdles.Length <= 0) return true;
			return jumpHeight >= hurdles.Max();
	}
}


using System.Linq;

public class Program
{
	public static bool hurdleJump(int[] hurdles, int jumpHeight)
	{
	    return hurdles.All(x => x <= jumpHeight);
	}
}






/*

Solution 3

*/

public class Program
{
	public static bool hurdleJump(int[] hurdles, int jumpHeight)
	{
		for (int i = 0; i < hurdles.Length; i++) {
			if (hurdles[i] > jumpHeight) {
				return false;
			}
		}
		return true;
	}
}




using System.Linq;
public class Program
{
	public static bool hurdleJump(int[] hurdles, int jumpHeight)
	{
				return (hurdles.Length==0 || hurdles.Max()<=jumpHeight);
	}
}





/*

Solution 4

*/




public class Program
{
	public static bool hurdleJump(int[] hurdles, int jumpHeight)
	{
		if (hurdles.Length == 0) return true;
                int max = hurdles[0];
                foreach (int number in hurdles)
                {
                    if (number > max)
                        max = number;
                }
                return jumpHeight >= max;
	}
}





public class Program
{
	public static bool hurdleJump(int[] hurdles, int jumpHeight)
	{
		 for (int i = 0; i < hurdles.Length; i++)
     {
         if (jumpHeight < hurdles[i])
         {
            goto End;
         }
     }
     return true;
     End:
     return false;
	}
}