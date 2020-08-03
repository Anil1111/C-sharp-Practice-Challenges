/*


Multiply by Length
Create a function to multiply all of the values in an array by the amount of values in the given array.

Examples
MultiplyByLength([2, 3, 1, 0]) ➞ [8, 12, 4, 0]

MultiplyByLength([4, 1, 1]) ➞ ([12, 3, 3])

MultiplyByLength([1, 0, 3, 3, 7, 2, 1]) ➞  [7, 0, 21, 21, 49, 14, 7]

MultiplyByLength([0]) ➞ ([0])
Notes
All of the values given are numbers.
All arrays will have at least one element.
Don't forget to return the result.
*/








/*

Solution 1

*/


using System.Linq;
public class Program
{
	public static int[] MultiplyByLength(int[] arr)
	{
		var multiplier = arr.Length;
		return arr.Select(x => x * multiplier).ToArray();
	}
}

/*

Solution 2

*/

public class Program
{
	public static int[] MultiplyByLength(int[] arr)
	{
		for(int i = 0 ; i< arr.Length ; i++)
		{
			arr[i] *= arr.Length;
		}
		return arr;
	}
}



/*

Solution 3

*/

using System.Linq;

public class Program
{
	public static int[] MultiplyByLength(int[] arr)
	{
	    return arr.Select(n => n * arr.Length).ToArray();
	}
}


public class Program
{
	public static int[] MultiplyByLength(int[] arr)
	{
		return arr.Select(e => e * arr.Length).ToArray();
	}
}


/*

Solution 4

*/



public class Program
{
	public static int[] MultiplyByLength(int[] arr)
	{
		for(int i = 0; i < arr.Length; i++)
		{
			arr[i] *= arr.Length;
		}
		return arr;
	}
}




public class Program
{
	public static int[] MultiplyByLength(int[] arr)
	{
		int l = arr.Length;
		for(int i=0;i<l;i++)
		{
			arr[i] = arr[i] * l;
		}
		return arr;
	}
}




public class Program
{
	public static int[] MultiplyByLength(int[] arr)
	{
		int a = 0;
		int b = arr.Length;
		while(a < b){
			arr[a] = arr[a] * b;
			a++;
		}
		return arr;
	}
}



public class Program
{
	public static int[] MultiplyByLength(int[] arr)
	{
		    int[] answer = new int[arr.Length];

        for (int i = 0; i < arr.Length; i++)
        {
            answer[i] = arr[i] * arr.Length;
        }
        return answer;
	}
}