/*
Alphabet Soup
Create a function that takes a string and returns a string with its letters in alphabetical order.

Examples
AlphabetSoup("hello") ➞ "ehllo"

AlphabetSoup("edabit") ➞ "abdeit"

AlphabetSoup("hacker") ➞ "acehkr"

AlphabetSoup("geek") ➞ "eegk"

AlphabetSoup("javascript") ➞ "aacijprstv"
Notes
You can assume numbers and punctuation symbols won't be included in test cases. You'll only have to deal with single word, alphabetic characters.


*/








/*

Solution 1

*/

using System.Linq;
public class Program 
{
    public static string AlphabetSoup(string str) 
    {
      return new string(str.OrderBy(x => x).ToArray());
    }
}


/*

Solution 2

*/



//using System;

public class Program 
{
  public static string AlphabetSoup(string str) 
  {
    var arr = str.ToCharArray();
    Array.Sort(arr);
    
		return string.Join("", arr);
  }
}


/*

Solution 3

*/

//using System.Linq;
public class Program 
{
    public static string AlphabetSoup(string str) => string.Concat(str.OrderBy(s=>s));
}


/*

Solution 4

*/


//using System.Linq;

public class Program 
{
    public static string AlphabetSoup(string str) 
    {
     return string.Concat(str.OrderBy(c=>c));
    }
}








public class Program 
{
    public static string AlphabetSoup(string str) 
    {
       return string.Join("", from c in str orderby c select c); 
    }
}







public class Program 
{
    public static string AlphabetSoup(string str) 
    {
			var strArr = str.ToCharArray();
      Array.Sort(strArr);
      
      return new string(strArr);
    }
}