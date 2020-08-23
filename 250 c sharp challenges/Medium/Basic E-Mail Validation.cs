/*
Basic E-Mail Validation
Create a function that accepts a string, checks if it's a valid email address and returns either true or false, depending on the evaluation.

The string must contain an @ character.
The string must contain a . character.
The @ must have at least one character in front of it.
e.g. "e@edabit.com" is valid while "@edabit.com" is invalid.
The . and the @ must be in the appropriate places.
e.g. "hello.email@com" is invalid while "john.smith@email.com" is valid.
If the string passes these tests, it's considered a valid email address.

Examples
ValidateEmail("@gmail.com") ➞ false

ValidateEmail("hello.gmail@com") ➞ false

ValidateEmail("gmail") ➞ false

ValidateEmail("hello@gmail") ➞ false

ValidateEmail("hello@edabit.com") ➞ true
Notes
Check the Tests tab to see exactly what's being evaluated.
You can solve this challenge with RegEx, but it's intended to be solved with logic.
Solutions using RegEx will be accepted but frowned upon :(

*/



//#############################################################
//#                        MY SOLUTIONS                       #
//#############################################################





/*

Solution 1

*/

public class Program 
{
    public static bool ValidateEmail(string str) 
    {
			 int atIndex = str.IndexOf('@');
			 int dotIndex = str.LastIndexOf('.');
       if (atIndex >= dotIndex || atIndex <= 0 || dotIndex == str.Length - 1) return false;
			 return true;
    }
}







/*

Solution 2

*/


public class Program 
{
    
        public static bool ValidateEmail(string str)
        {
            int last_dot = 0;
            int a = 0;
     
                for (int i = 0; i < str.Length; i++)
                {
                    if (str[i] == '.')
                    {
                        last_dot = i;
                    }
                    if (str[i] == '@')
                    {
                        a = i;
                    }
                }
            if (last_dot > a && a > 0)
            {
                return true;
            }
            else return false;
        } 
}




/*

Solution 3

*/

public class Program 
{
    public static bool ValidateEmail(string str) 
    {
      if (string.IsNullOrWhiteSpace(str))
            return false;  
			var s1 = str.Split('@');
        if (s1 == null || s1.Length != 2)
            return false;
        string preAt = s1[0];
        string postAt = s1[1];
        if (preAt.Length == 0 || postAt.Length == 0)
            return false;
        return postAt.Contains(".");
    }
}


/*

Solution 4

*/



using System;
using System.Linq;
public class Program 
{
    public static bool ValidateEmail(string str) 
    {
      if (!str.Contains('@') || !str.Contains('.')) return false;

            var testForAt = str.Split('@');
            if (testForAt[0].Length == 0 || testForAt[1].Length == 0) return false;
            if (!testForAt[1].Contains('.')) return false;

            var testForDot = str.Split('.');
            if (testForDot[0][testForDot[0].Length-1] == '@' || testForDot[1].Length == 0) return false;
            
            return true;
    }
}
