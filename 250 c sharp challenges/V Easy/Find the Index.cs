/*


Find the Index
Create a function that takes an array and a string as arguments and return the index of the string.

Examples
FindIndex(new string[] {"hi", "edabit", "fgh", "abc"}, "fgh") ➞ 2

FindIndex(new string[] {"Red", "blue", "Blue", "Green"}, "blue") ➞ 1

FindIndex(new string[] {"a", "g", "y", "d"}, "d") ➞ 3

FindIndex(new string[] {"Pineapple", "Orange", "Grape", "Apple"}, "Pineapple") ➞ 0
Notes
Don't forget to return the result.
If you are stuck, find help in the Resources tab.
*/








/*

Solution 1

*/

using System;

public class Program 
{
    public static int FindIndex(string[] arr, string str) 
    {
			return Array.IndexOf(arr, str);
    }
}


/*

Solution 2

*/

public class Program 
{
    public static int FindIndex(string[] arr, string str) 
    {
			for (int i = 0; i < arr.Length; i++)
				if (arr[i] == str)
					return i;
			return 0;
    }
}




/*

Solution 3

*/



// using System.Linq;
public class Program
{
    public static int FindIndex(string[] arr, string str)
    {
        int result = 0;
        for (int i = 0; arr.Length > i; i++)
        {
            if (arr[i] == str)
            {
                result = i;
            }
        }
        return result;
    }

}


/*

Solution 4

*/



//using System;

public class Program
{
    public static int FindIndex(string[] arr, string str) 
    {
			return Array.FindIndex(arr, w => w == str);
    }
}



//using System;
public class Program
{
    public static int FindIndex(string[] arr, string str) 
    {
			return Array.IndexOf(arr,str);
    }
}





public class Program 
{
    public static int FindIndex(string[] arr, string str) 
    {
			int ind = 0;
			for(int i = 0; i < arr.Length; i++){
				if(str == arr[i]){
					ind = i;
					break;
				}
			}
			return ind;
    }
}





//using System;
public class Program 
{
    public static int FindIndex(string[] arr, string str) 
    {
	  return Array.IndexOf(arr,str);
    }
}