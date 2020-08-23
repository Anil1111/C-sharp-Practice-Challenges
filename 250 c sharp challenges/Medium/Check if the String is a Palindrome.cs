/*

Check if the String is a Palindrome
A palindrome is a word, phrase, number or other sequence of characters which reads the same backward or forward, such as madam or kayak.

Write a function that takes a string and determines whether it's a palindrome or not. The function should return a boolean (true or false value).

Examples
IsPalindrome("Neuquen") ➞ true

IsPalindrome("Not a palindrome") ➞ false

IsPalindrome("A man, a plan, a cat, a ham, a yak, a yam, a hat, a canal-Panama!") ➞ true
Notes
Should be case insensitive.
Special characters (punctuation or spaces) should be ignored.

*/







//#############################################################
//#                        MY SOLUTIONS                       #
//#############################################################








/*

Solution 1

*/


using System;
using System.Text;

public class Program 
{
    public static bool IsPalindrome(string str) 
    {
				var direct = new StringBuilder();
				var reverse = new StringBuilder();
				foreach (char c in str)
				{
						if (!Char.IsLetterOrDigit(c)) continue;
						direct.Append(Char.ToLower(c));
						reverse.Insert(0, Char.ToLower(c));
				}
				return direct.ToString() == reverse.ToString();
    }
}




/*

Solution 2

*/



public class Program 
{
    public static bool IsPalindrome(string str)
        {
            str = str.ToLower();
            int start = 0;
            int end = str.Length - 1;

            while (!(start >= end))
            {

                char a = str[start];
                char b = str[end];
                if (!((a >= 67 && a <= 90) || (a >= 97 && a <= 122)))
                {
                    start++;
                    continue;
                }

                if (!((b >= 67 && b <= 90) || (b >= 97 && b <= 122)))
                {
                    end--;
                    continue;
                }

                if (str[start] != str[end])
                    return false;
                start++;
                end--;
            }

            return true;
        }
}




/*

Solution 3

*/




using System;
using System.Text.RegularExpressions;

public class Program 
{
    public static bool IsPalindrome(string str) 
    {
			str = str.ToLower();
			str = Regex.Replace(str, "[^a-zA-Z0-9_.]+","",RegexOptions.Compiled);
			char[] chars = str.ToCharArray();
      char[] result = new char[chars.Length];
			for (int i = 0; i < chars.Length; i++){
				result[result.Length - 1 - i] = chars[i];
			}
			return str == new string(result);
    }
}





/*

Solution 4

*/



using System;
using System.Text;
public class Program 
{
    public static bool IsPalindrome(string str) 
    {
			str = str.Replace("!", String.Empty);
            str = str.Replace(",", String.Empty);
            str = str.Replace("-", String.Empty);
            str = str.Replace(" ", String.Empty);
            str = str.ToLower();
            StringBuilder a = new StringBuilder();
            char[] b = str.ToCharArray();
            for (int i = str.Length-1; i >= 0; i--)
            {  
                a.Append( b[i]);
            }
            Console.WriteLine(a.ToString());
            Console.WriteLine(str);
            if (str.ToLower() == a.ToString().ToLower())
            {
                return true;
            }
            else
               return false;
    }
}





/*

Solution 5

*/








using System.Linq;
using System.Text.RegularExpressions;
public class Program 
{
    public static bool IsPalindrome(string str) 
    {
			return Regex.Replace(str, @"([ |,|!|-])", "").ToLower() ==  string.Concat(Regex.Replace(str, @"([ |,|!|-])", "").ToLower().Reverse());
    }
}