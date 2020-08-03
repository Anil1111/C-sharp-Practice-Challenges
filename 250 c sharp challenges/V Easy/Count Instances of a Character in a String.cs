/*

Count Instances of a Character in a String
Create a function that takes a character and a string as arguments and returns the number of times the character is found in the string.

Examples
CharCount("a", "edabit") ➞ 1

CharCount("c", "Chamber of secrets") ➞ 1

CharCount("b", "big fat bubble") ➞ 4
Notes
Your output must be case-sensitive (see second example).

*/








/*

Solution 1

*/

using System.Linq;
public class Program 
{
    public static int CharCount(char myChar, string str) 
    {
			return str.Count(c => c == myChar);
    }
}


/*

Solution 2

*/


using System.Linq;
public class Program 
{
    public static int CharCount(char myChar, string str) 
    {
			return str.Where(x=>x==myChar).Count();
    }
}


/*

Solution 3

*/

using System.Text.RegularExpressions;
public class Program 
{
    public static int CharCount(char myChar, string str) 
    {
			int newCount = str.Replace(myChar.ToString(),"").Length;
			return str.Length - newCount;
    }
}







public class Program 
{
    public static int CharCount(char myChar, string str) 
    {
			int count = 0;
			foreach (char letter in str)
			{
				if (letter == myChar)
				{
					count++;
				}
			}
			return count;
    }
}

/*

Solution 4

*/




public class Program 
{
    public static int CharCount(char myChar, string str) 
    {
			int end = str.Split(myChar).Length - 1;
			return end;
    }
}





public class Program 
{
    public static int CharCount(char myChar, string str) => str.Split(myChar).Length - 1;
}




public class Program 
{
    public static int CharCount(char myChar, string str) 
    {
			int counter = 0;
			foreach (char letter in str)
			{
				if (letter == myChar)
				{
					counter++;
				}
			}
			return counter;
    }
}




public class Program 
{
    public static int CharCount(char myChar, string str)
        {
            int charCount = 0;
            foreach(char x in str)
            {
                if (x == myChar)
                {
                    charCount++;
                }
            }
            return charCount;
        }
}