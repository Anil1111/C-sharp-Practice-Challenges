/*


Between Words
Write a function that takes three string arguments (first, last, and word) and returns true if word is found between first and last in the dictionary, otherwise false.

Examples
isBetween("apple", "banana", "azure") ➞ true

isBetween("monk", "monument", "monkey") ➞ true

isBetween("bookend", "boolean", "boost") ➞ false
Notes
All letters will be in lowercase.
All three words will be different.
Remember that the string word is in the middle.
*/








/*

Solution 1

*/

public class Program
{
    public static bool isBetween(string first, string last, string word)
    {
			return first.CompareTo(word) == -1 && last.CompareTo(word) == 1; 
    }
}


/*

Solution 2

*/


public class Program
{
    public static bool isBetween(string first, string last, string word)
    {
	  	return first.CompareTo(word) < 0 && last.CompareTo(word) > 0;
    }
}


/*

Solution 3

*/
public class Program
{
    public static bool isBetween(string first, string last, string word)
    {
			return (string.Compare(first, word) <= 0 && string.Compare(word, last) <= 0);
    }
}


/*

Solution 4

*/


public class Program
{
    public static bool isBetween(string first, string last, string word)
    {
			
			string[] allWords = new string[] {first, last, word};
			
			Array.Sort(allWords);
			
			return allWords[1].Equals(word);
			
    }
}









/*
Between Words
Write a function that takes three string arguments (first, last, word) 
and returns true if (when alphabetically sorted) 
word is found between first and last.

Examples
isBetween("apple", "banana", "azure") ➞ true

isBetween("monk", "monument", "monkey") ➞ true

isBetween("bookend", "boolean", "boost") ➞ false
*/
public class Program
{
    public static bool isBetween(string first, string last, string word)
    {
			return (string.Compare(word,first)>0 &&string.Compare(last,word)>0)?true:false;
    }
}








//using System.Collections.Generic;
public class Program
{
    public static bool isBetween(string first, string last, string word)
    {
			List<string> words = new List<string>();
			words.Add(first);
			words.Add(last);
			words.Add(word);
			words.Sort();
			if(words[1] == word) return true;
			else return false;
    }
}






//using System.Linq;

public class Program
{
    public static bool isBetween(string first, string last, string word)
    {
			string[] wordArray = {first, last, word};
					
			return wordArray.OrderBy(x => x).ToArray()[1] == word; 
    }
}