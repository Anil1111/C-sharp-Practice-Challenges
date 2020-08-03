/*
Return the Next Number from the Integer Passed
Create a function that takes a number as an argument, increments the number by +1 and returns the result.

Examples
Addition(0) ➞ 1

Addition(9) ➞ 10

Addition(-3) ➞ -2
Notes
Don't forget to return the result.
If you get stuck on a challenge, find help in the Resources tab.
If you're really stuck, unlock solutions in the Solutions tab.


*/








/*

Solution 1

*/

public class Program
{
    public static int Addition(int num)
    {
			return ++num; 
    }
}




/*

Solution 2

*/

public class Program
{
    public static int Addition(int num)
    {
			return num - -1;
    }
}



/*

Solution 3

*/

public class Program
{
    public static int Addition(int num)
    {
			int res=num+1;
			return res;
			
    }
}

/*

Solution 4

*/



public class Program
{
    public static int Addition(int num)
			=> num + 1;
}