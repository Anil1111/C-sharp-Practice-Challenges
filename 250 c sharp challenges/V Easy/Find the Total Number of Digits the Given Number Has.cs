/*

Find the Total Number of Digits the Given Number Has
Create a function that takes a number as an argument and returns the amount of digits it has.

Examples
FindDigitAmount(123) ➞ 3

FindDigitAmount(56) ➞ 2

FindDigitAmount(7154) ➞ 4

FindDigitAmount(61217311514) ➞ 11

FindDigitAmount(0) ➞ 1
Notes
If you get stuck on a challenge, find help in the Resources tab.
If you're really stuck, unlock solutions in the Solutions tab.

*/


//#############################################################
//#                        MY SOLUTIONS                       #
//#############################################################



/*

Solution 1

*/


public class Program
{
    public static int FindDigitAmount(int num)
    {
			return num.ToString().Length;
    }
}

/*

Solution 2

*/


public class Program
{
    public static int FindDigitAmount(int num)
    {
			int i = 0;
			if(num == 0 ) return 1;
			while(num >= 1){
				i++;
				num = num / 10;
			}
			return i;
    }
}


/*

Solution 3

*/

using System;
public class Program
{
    public static int FindDigitAmount(int num)
    {
			int numCount = num.ToString().Length;
			return numCount;
    }
}

/*

Solution 4

*/


public class Program
{
    public static int FindDigitAmount(int num)
    {
			string i = num.ToString();
			return i.Length;
    }
}




public class Program
{
    public static int FindDigitAmount(int num)
    {
			return num.ToString().Length;
    }
}



public class Program
{
    public static int FindDigitAmount(int num)
    {
			string num1 = num.ToString();
			return num1.Length;
    }
}
//accourding to all known laws of aviation, there is no way a bee should be able to fly. The bee, of course, flies anyway, because it doesnt care about what humans think is impossible. 
//