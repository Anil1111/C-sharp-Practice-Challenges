/*

Double Letters
Create a function that takes a word and returns true if the word has two consecutive identical letters.

Examples
DoubleLetters("loop") ➞ true

DoubleLetters("yummy") ➞ true

DoubleLetters("orange") ➞ false

DoubleLetters("munchkin") ➞ false
Notes

*/








/*

Solution 1

*/

public class Program
{
    public static bool DoubleLetters(string word)
    {
				return System.Text.RegularExpressions.Regex.Match(word, @"(.)\1").Success;
    }
}


/*

Solution 2

*/
public class Program
{
    public static bool DoubleLetters(string word)
    {
			for (int i = 0; i < word.Length-1; i++)
			{
				if (word[i] == word[i+1]){return true;}
			}
			return false;
    }
}





public class Program
{
    public static bool DoubleLetters(string word)
    {
        for (int i =1; word.Length > i; i++)
        {
            if (word[i] == word[i - 1])
            {
                return true;
            }
        }
        return false;
    }
}

/*

Solution 3

*/


using System.Text.RegularExpressions;
public class Program
{
  public static bool DoubleLetters(string word)=>Regex.IsMatch(word,@"(.)\1");
}


/*

Solution 4

*/


public class Program
{
    public static bool DoubleLetters(string word)
        {
            for (int i = 0; i < word.Length - 1; i++)
            {
                if (word[i] == word[i + 1])
                    return true;  
            }
            return false;

        }
}



public class Program
{
    public static bool DoubleLetters(string word)
    {
			bool result = false;
            for (int i = 0; i < word.Length-1; i++)
            {
                if (word[i] == word[i + 1])
                    result = true;
            }
            return result;
    }
}





public class Program
{
    public static bool DoubleLetters(string word)
    {
			 for (int i = 0; i < word.Length-1;i++)
            {
                if (word[i] == word[i + 1])
                    return true;
            }
            return false;
    }
}



public class Program
{
    public static bool DoubleLetters(string word)
    {
			var isConsecutive = false;
			for(var i = 1; i < word.Length; i++)
			{
				if(word[i] == word[i-1])
				{
					isConsecutive = true;;
				}
			}
			return isConsecutive;
    }
}