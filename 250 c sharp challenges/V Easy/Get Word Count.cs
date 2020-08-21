/*


Get Word Count
Create a function that takes a string and returns the word count. The string will be a sentence.

Examples
countWords("Just an example here move along") ➞ 6

countWords("This is a test") ➞ 4

countWords("What an easy task, right") ➞ 5
Notes
If you get stuck on a challenge, find help in the Resources tab.
If you're really stuck, unlock solutions in the Solutions tab.
*/


//#############################################################
//#                        MY SOLUTIONS                       #
//#############################################################




/*

Solution 1

*/

public class Program
    {
        public static int CountWords(string str)
        {
            return str.Split().Length;
        }
    }


/*

Solution 2

*/


using System.Linq;

public class Program
{
	public static int CountWords(string str) => str.Count(@char=>@char==' ') + 1;
}

/*

Solution 3

*/


public class Program
    {
        public static int CountWords(string str)
        {
            return str.Split().Length;
        }
    }
/*

Solution 4

*/


using System.Linq;
public class Program
    {
        public static int CountWords(string str)
        {
						string[] str1 = str.Split(' '); 
            return str1.Length;
        }
    }