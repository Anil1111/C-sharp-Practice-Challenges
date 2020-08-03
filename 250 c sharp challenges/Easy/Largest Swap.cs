/*

Largest Swap
Create a function that takes a two-digit number and determines if it's the largest of two possible digit swaps.

To illustrate:

LargestSwap(27) ➞ false

LargestSwap(43) ➞ true
If 27 is our input, we should return false because swapping the digits gives us 72, and 72 > 27. On the other hand, swapping 43 gives us 34, and 43 > 34.

Examples
LargestSwap(14) ➞ false

LargestSwap(53) ➞ true

LargestSwap(99) ➞ true
Notes
Numbers with two identical digits (third example) should yield true (you can't do better).

*/








/*

Solution 1

*/

public class Program
{
	public static bool LargestSwap(int num)
	{
		return (int)(num / 10) >= num % 10;
	}
}





public class Program
{
    public static bool LargestSwap(int num)
    {
			var reversedNum = num.ToString().Last().ToString() 
				+ num.ToString().First().ToString();
			return num >= int.Parse($"{num.ToString().Last()}{num.ToString().Last()}");
    }
}




/*

Solution 2

*/

//using System;
//using System.Linq;

public class Program
{
    public static bool LargestSwap(int num)
    {
            var strNum = num.ToString().ToCharArray();
            var num1 = Convert.ToInt32(strNum.First());
            var num2 = Convert.ToInt32(strNum.Last());
            return (num1 >= num2);
    }
}



public class Program
{
    public static bool LargestSwap(int num)
    {
			string strNum = num.ToString();

            if (System.Int32.Parse(strNum[0].ToString()) >= System.Int32.Parse(strNum[1].ToString()))
            {
                return true;
            }
            else
            {
                return false;
            }
    }
}





/*

Solution 3

*/

//using System.Linq;
//using System;
public class Program
{
    public static bool LargestSwap(int num)
    {
			int[] numArr = num.ToString().Select(o=> Convert.ToInt32(o)).ToArray();
			
			return (numArr[0]>=numArr[1]);
    }
}

/*

Solution 4

*/



public class Program
{
    public static bool LargestSwap(int num)
    {
			var arr = num.ToString().ToCharArray();
			var swapped = string.Concat(arr[1],arr[0]);
			var swappedNum = Convert.ToInt32(swapped);
			return swappedNum <= num;
    }
}




public class Program
{
    public static bool LargestSwap(int num)
    {
			int numSwap = (num % 10 * 10) + (num / 10);
            if (numSwap > num)
                return false;
            return true;
    }
}