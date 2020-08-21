/*
How Many Vowels?
Create a function that takes a string and returns the number (count) of vowels contained within it.

Examples
CountVowels("Celebration") ➞ 5

CountVowels("Palm") ➞ 1

CountVowels("Prediction") ➞ 4
Notes
a, e, i, o, u are considered vowels (not y).
All test cases are one word and only contain letters.

*/



//#############################################################
//#                        MY SOLUTIONS                       #
//#############################################################



/*

Solution 1

*/

using System.Linq;
public class Program 
{
    public static int CountVowels(string str)
      => str.Count(a=>$"aeiouAEIOU".Contains(a));
}


/*

Solution 2

*/

//using System.Collections.Generic;
//using System.Linq;

public class Program 
{
  	private static List<char> Vowels = new List<char>
    {
      	'a', 'e', 'i', 'o', 'u'
    };
  
    public static int CountVowels(string str) 
    {
      	return str.Count(c => Vowels.Contains(c));
    }
}




/*

Solution 3

*/

public class Program 
{
    public static int CountVowels(string str) 
    {
      return str.Count((e) => "aeiou".Contains(e));
    }
}


public class Program 
{
    public static int CountVowels(string str) 
    {
      str = str.ToLower();
      var vowels = "aeiou";
      return str.Count(c => vowels.Contains(c));
    }
}


/*

Solution 4

*/



public class Program 
{
    public static int CountVowels(string str) 
    {
        return str.ToArray().Where(c => "aeiou".Contains(c.ToString())).Count();
    }
}



public class Program 
{
    public static int CountVowels(string str) 
    {
      Char[] arr = str.ToLower().ToCharArray();
      return arr.Count(x => x.Equals('a') || x.Equals('e') || x.Equals('i') || x.Equals('o') || x.Equals('u'));
    }
}