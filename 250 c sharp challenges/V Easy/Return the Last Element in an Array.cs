/*
Return the Last Element in an Array
Create a function that accepts an array and returns the last item in the array. The array can contain any of C#'s primitive data types.

Examples
GetLastItem([1, 2, 3]) ➞ 3

GetLastItem(["cat", "dog", "duck"]) ➞ "duck"

GetLastItem([true, false, true]) ➞ true
Notes
Don't forget to return the result.
If you get stuck on a challenge, find help in the Resources tab.
If you're really stuck, unlock solutions in the Solutions tab.
*/




//#############################################################
//#                        MY SOLUTIONS                       #
//#############################################################



public class Program 
{
    public static object GetLastItem(object[] arr) 
    {
      return arr[arr.Length - 1];
    }
}




public class Program 
{
    public static object GetLastItem(object[] arr) 
    {
      int last;
      last = arr.GetUpperBound(0);
      return arr[last];
    }
}


public class Program 
{
    public static object GetLastItem(object[] arr) 
    {
      return arr[arr.Length-1];
    }
}