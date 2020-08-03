/*

Return the Four Letter Strings
Create a function that takes an array of strings and returns the words that are exactly four letters.

Examples
IsFourLetters(["Tomato", "Potato", "Pair"]) ➞ ["Pair"]

IsFourLetters(["Kangaroo", "Bear", "Fox"]) ➞ ["Bear"]

IsFourLetters(["Ryan", "Kieran", "Jason", "Matt"]) ➞ ["Ryan", "Matt"]
Notes
You can expect valid strings for all test cases.

*/








/*

Solution 1

*/

using System.Linq;
using System.Collections.Generic;
public class Program 
{
    public static string[] IsFourLetters(string[] arr) => arr.Where(i=>i.Length == 4).ToArray();
}



/*

Solution 2

*/


public class Program 
{
    public static string[] IsFourLetters(string[] arr) 
    {
      	return arr.Where(str => str.Length == 4).ToArray();
    }
}


/*

Solution 3

*/

public class Program 
{
    public static string[] IsFourLetters(string[] arr) => Array.FindAll(arr, a => a.Length == 4);
}

/*

Solution 4

*/



public class Program 
{
  public static string[] IsFourLetters(string[] arr) 
  {
		return arr.Where(x => x.Length == 4).ToArray();
  }
}




public class Program 
{
    public static string[] IsFourLetters(string[] arr) 
    {
        return arr.Where(e => e.Length == 4).ToArray();
    }
}




public class Program 
{
    public static string[] IsFourLetters(string[] arr) 
    {
      string[] ans = new string[arr.Length];
      int a = 0;
      for (int i = 0; i < arr.Length; i++){
        if (arr[i].Length == 4){
          ans[a] = arr[i];
          a++;
        }
      }
      ans = ans.Where(color => !string.IsNullOrEmpty(color)).ToArray();
      return ans;
    }
}