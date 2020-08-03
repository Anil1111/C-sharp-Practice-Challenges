/*
Count the Letters and Digits
Write a function that takes a string and calculates the number of letters and digits within it. Return the result as anonymous type in string format.

Examples
count_all("Hello World") ➞ " { LETTERS =  10,  DIGITS =  0 }"

count_all("H3ll0 Wor1d") ➞ " { LETTERS =  7,  DIGITS =  3 }"

count_all("149990") ➞  "{ LETTERS =  0, DIGITS = 6 }"
Notes
Tests contain only alphanumeric characters.
Spaces are not letters.
All tests contain valid strings.
Return the result as anonymous type.


*/








/*

Solution 1

*/

using System.Linq;
using System;

public class Program 
{
    public static string ount_all(string txt) 
    {	 	
				var digits = txt.Count(char.IsDigit);
				var letters = txt.Count(char.IsLetter);
				return Convert.ToString(new {LETTERS = letters, DIGITS = digits});
    }
}


/*

Solution 2

*/

public class Program 
{
    public static string ount_all(string txt) 
    {
			int charCount = 0, numCount = 0;
			foreach (var ch in txt)
			{
					if(char.IsDigit(ch))
					{
							numCount++;
					}
					if(char.IsLetter(ch))
					{
							charCount++;
					}
			}
			var obj = new { LETTERS = charCount, DIGITS = numCount };
			return obj.ToString();
    }
}



/*

Solution 3

*/

public class Program 
{
    public static string ount_all(string txt) 
    {
			return "{" + $" LETTERS = {txt.Where(x => Char.IsLetter(x)).Count()}, DIGITS = {txt.Where(x => Char.IsDigit(x)).Count()} " + "}";
    }
}

/*

Solution 4

*/



public class Program 
{
        public static string ount_all(string txt) => ("{ LETTERS = " + txt.Count(c => char.IsLetter(c))).ToString() + ", DIGITS = " +  txt.Count(c => char.IsDigit(c)).ToString() + " }";}






        public class Program 
{
    public static string ount_all(string txt) 
    {	 	
			var input = txt.ToLower().ToCharArray();
			var letters = new List<char>();
			var digits = new List<char>();

			foreach (var c in input)
			{
					if (Char.IsLetter(c))
							letters.Add(c);
					else if (Char.IsDigit(c))
							digits.Add(c);
			}
			return new { LETTERS = letters.Count(), DIGITS = digits.Count() }.ToString();
    }
}








public class Program 
{
    public static string ount_all(string txt)
			=>"{ LETTERS = " + txt.Count(c => char.IsLetter(c)) + ", DIGITS = " + txt.Count(c => char.IsDigit(c)) + " }";
}






