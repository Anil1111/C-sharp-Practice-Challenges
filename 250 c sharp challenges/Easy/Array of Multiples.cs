/*

Array of Multiples
Create a function that takes two numbers as arguments (num, length) and returns an array of multiples of num up to length.

Examples
ArrayOfMultiples(7, 5) ➞ [7, 14, 21, 28, 35]

ArrayOfMultiples(12, 10) ➞ [12, 24, 36, 48, 60, 72, 84, 96, 108, 120]

ArrayOfMultiples(17, 6) ➞ [17, 34, 51, 68, 85, 102]
Notes
Notice that num is also included in the returned array.

*/








/*

Solution 1

*/


using System;
using System.Linq;

public class Program {
	public static int[] ArrayOfMultiples(int num, int length) => Enumerable.Range(1, length).Select(x => x * num).ToArray();
}

/*

Solution 2

*/

public class Program {
	  public static int[] ArrayOfMultiples(int num, int length)
		{
			  int[] multiples = new int[length];
			
			  for(int i = 0; i < length; i++) {
					  multiples[i] = num * (i + 1);
				}
			  return multiples;
	  }
}



/*

Solution 3

*/
public class Program {
	public static int[] ArrayOfMultiples(int num, int length) => Enumerable.Range(1, length).Select(i => num * i).ToArray();
}


/*

Solution 4

*/


//using System;
//using System.Collections.Generic;
public class Program {
	public static int[] ArrayOfMultiples(int num, int length) {
		List<int> result=new List<int>();
		for(int i=1;i<=length;i++)
			result.Add(num*i);
		return result.ToArray();
	}
}



public class Program {
	public static int[] ArrayOfMultiples(int num, int length) {
		int[] a = new int[length];
		for (int i = 0; i < length; i++) a[i] = num * (i+1);
		return a;
	}
}




public class Program {
	public static int[] ArrayOfMultiples(int num, int length) {
		
		int[] returnArr = new int[length];
		int newNum = num;
		for(int i = 0; i < length; i++)
		{
			returnArr[i] = newNum;
			newNum += num;
		}
		return returnArr;
	}
}



public class Program {
	public static int[] ArrayOfMultiples(int num, int length) {
		int[] arr = new int[length];
		for (int i = 0; i < arr.Length; i++)
		{
			arr[i] = num * (i + 1);
		}
		return arr;
	}
}