/*

Is the Number Symmetrical?
Create a function that takes a number as an argument and returns true or false depending on whether the number is symmetrical or not. A number is symmetrical when it is the same as its reverse.

Examples
IsSymmetrical(7227) ➞ true

IsSymmetrical(12567) ➞ false

IsSymmetrical(44444444) ➞ true

IsSymmetrical(9939) ➞ false

IsSymmetrical(1112111) ➞ true
Notes

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
    public static bool IsSymmetrical(int num)
    {
		return num.ToString() == string.Concat( num.ToString().ToCharArray().Reverse() );
    }
}


/*

Solution 2

*/

public class Program
{
    public static bool IsSymmetrical(int num)
    {
        bool result = false;
        string numm = num.ToString();
        if (string.Concat(numm.Reverse()) == numm)
        {
            result = true;
        }
        return result;
    }
}



/*

Solution 3

*/

public class Program
{
    public static bool IsSymmetrical(int num)
    {
			return num.ToString() == string.Concat(num.ToString().Reverse());
    }
}

/*

Solution 4

*/


public class Program
{
    public static bool IsSymmetrical(int num)
    {
			
			string numString = num.ToString();
			
			int leftIndex = 0;
			int rightIndex = numString.Length - 1;
			
			while (leftIndex < rightIndex)
			{
				if (numString[leftIndex] != numString[rightIndex])
				{
					return false;
				}
				
				leftIndex++;
				rightIndex--;
			}
			
			return true;
			
			
			
			
			
    }
}