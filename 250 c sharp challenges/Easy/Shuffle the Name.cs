/*

Shuffle the Name
Create a function that accepts a string (of a person's first and last name) and returns a string with the first and last name swapped.

Examples
NameShuffle("Donald Trump") ➞ "Trump Donald"

NameShuffle("Rosie O'Donnell") ➞ "O'Donnell Rosie"

NameShuffle("Seymour Butts") ➞ "Butts Seymour"
Notes
There will be exactly one space between the first and last name.
If you get stuck on a challenge, find help in the Resources tab.
If you're really stuck, unlock solutions in the Solutions tab.

*/








/*

Solution 1

*/

using System.Linq;
public class Program
    {
        public static string NameShuffle(string str)
        {
            return string.Join(" ", str.Split(' ').Reverse());
        }
    }



/*

Solution 2

*/


//using System.Linq;

public class Program
{
    public static string NameShuffle(string str)
    {
        return str.Split(' ').Reverse().Aggregate((a, b) => a + " " + b);
    }
}


/*

Solution 3

*/

public class Program
    {
        public static string NameShuffle(string str)
        {
            return str.Split(' ').Reverse()
              .Aggregate((a, b) => a.ToString() + " " + b.ToString());
        }
    }




/*

Solution 4

*/


public class Program
    {
        public static string NameShuffle(string str)
        {
            return str.Split(' ')[1] + " " + str.Split(' ')[0];
        }
    }