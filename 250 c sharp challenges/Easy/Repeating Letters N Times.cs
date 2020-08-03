/*

Repeating Letters N Times
Create a function that repeats each character in a string n times.

Examples
Repeat("mice", 5) ➞ "mmmmmiiiiiccccceeeee"

Repeat("hello", 3) ➞ "hhheeellllllooo"

Repeat("stop", 1) ➞ "stop"
Notes

*/








/*

Solution 1

*/

using System.Linq;

public class Program
{
    public static string ReplaceVowels(string str, string ch)
    {
			var vowels = new string[]{"a","e","i","o","u"};
			foreach(var vowel in vowels)
			{
				str = str.Replace(vowel, ch);
			}
			
			return str;
    }
}


/*

Solution 2

*/
public class Program
{
    public static string ReplaceVowels(string str, string ch)
    {
			return str.Replace("a", ch).Replace("e", ch).Replace("i", ch).Replace("o", ch).Replace("u", ch);
    }
}




/*

Solution 3

*/



/*

Solution 4

*/