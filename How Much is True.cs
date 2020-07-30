/*
How Much is True?
Create a function which returns the number of true values there are in an array.

Examples
CountTrue([true, false, false, true, false]) ➞ 2

CountTrue([false, false, false, false]) ➞ 0

CountTrue([]) ➞ 0
Notes
Return 0 if given an empty array.
All array items are of the type bool (true or false).
*/

using System;
using System.Linq;

public class Program {
	public static int CountTrue(bool[] arr) {
		return arr.Count(val => val);
	}
}




public class Program {
	public static int CountTrue(bool[] arr) 
	{
		int waar = 0;
	for(int i = 0;i < arr.Length;i++) 
	{
		if (arr[i] == true) 
		{
			waar++;
		}
	}	
		return waar;
	}
}





public class Program {
	public static int CountTrue(bool[] arr) {
		int count = 0;
		foreach(var a in arr)
		{
			if(a)
				count++;
		}
		return count;
	}
}