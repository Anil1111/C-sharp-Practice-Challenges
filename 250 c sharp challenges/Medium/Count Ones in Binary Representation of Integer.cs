/*

Count Ones in Binary Representation of Integer
Count the amount of ones in the binary representation of an integer. So for example, since 12 is '1100' in binary, the return value should be 2.

Examples
CountOnes(0) ➞ 0

CountOnes(100) ➞ 3

CountOnes(999) ➞ 8
Notes
The input will always be a valid integer (number).

*/








/*

Solution 1

*/
using System;
using System.Linq;

public class Program
{
    public static int CountOnes(int i)
    {
	    return Convert.ToString(i, 2).Count(c => c == '1');
    }
}



/*

Solution 2

*/

public class Program
{
    public static int CountOnes(int i)
    {
			 int db=0;
			 while (i>0){
				 if(i%2==1) db++;
				 i=i/2;
			 }
			return db;
    }
}




/*

Solution 3

*/
public class Program
{
    public static int CountOnes(int i)
    {
				return Convert.ToString(i, 2).Count(c => c == '1');
    }
}


/*

Solution 4

*/


public class Program
{
    public static int CountOnes(int i)
    {
			return Convert.ToString(i, 2).Count(s => s == '1');
    }
}