/*

Count Syllables
Create a function that counts the number of syllables a word has. Each syllable is separated with a dash -.

Examples
NumberSyllables("buf-fet") ➞ 2

NumberSyllables("beau-ti-ful") ➞ 3

NumberSyllables("mon-u-men-tal") ➞ 4

NumberSyllables("on-o-mat-o-poe-ia") ➞ 6
Notes
Don't forget to return the result.
If you get stuck on a challenge, find help in the Resources tab.
If you're really stuck, unlock solutions in the Solutions tab.

*/








/*

Solution 1

*/


public class Program
{
    public static int NumberSyllables(string word)
    {
			return word.Split('-').Length;
    }
}

/*

Solution 2

*/

public class Program
{
    public static int NumberSyllables(string word)
    {
			int count = 1;
			
			foreach(char a in word){
				if(a == '-') {
					count++;
				}
			}
			
			return count;
    }
}



/*

Solution 3

*/


public class Program
{
    public static int NumberSyllables(string word)
    {
			string[] num = word.Split('-');
			return num.Length;
			
    }
}




public class Program
{
    public static int NumberSyllables(string word) => word.Split('-').Length;
}






/*

Solution 4

*/






public class Program
{
    public static int NumberSyllables(string word)
    {
			int syllCount = 1;
			for(int i = 0; i < word.Length; i++)
				if(word[i] == '-')
					syllCount++;
			return syllCount;
    }
}





//using System.Linq;
public class Program
{
    public static int NumberSyllables(string word)
    {
			return word.Count(x => x == '-') + 1;
    }
}