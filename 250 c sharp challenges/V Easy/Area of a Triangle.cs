/*

Area of a Triangle
Write a function that takes the base and height of a triangle and return its area.

Examples
triArea(3, 2) ➞ 3

triArea(7, 4) ➞ 14

triArea(10, 10) ➞ 50
Notes
The area of a triangle is: (base * height) / 2
Don't forget to return the result.
If you get stuck on a challenge, find help in the Resources tab.
If you're really stuck, unlock solutions in the Solutions tab.

*/








/*

Solution 1

*/

public class Program
{
	public static int triArea(int b, int h)
	{
		return ((b * h) / 2);
	}
}


/*

Solution 2

*/

public class Program
{
	public static int triArea(int b, int h)
	{
		int res = (b * h) / 2;
		return res;
	}
}



/*

Solution 3

*/
public class Program
{
	public static int triArea(int b, int h)
	{
		int area = (b*h)/2;
		return area;
	}
	
	public void Start(){
		triArea(2, 4);
		return;
	}
}

/*

Solution 4

*/


public class Program
{
	public static int triArea(int b, int h)
	{
		return (b*h)/2;
	}
}