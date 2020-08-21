/*

No Yelling
Create a function that transforms sentences ending with multiple question marks ? or exclamation marks ! into a sentence only ending with one without changing punctuation in the middle of the sentences.

Examples
NoYelling("What went wrong?????????") ➞ "What went wrong?"

NoYelling("Oh my goodness!!!") ➞ "Oh my goodness!"

NoYelling("I just!!! can!!! not!!! believe!!! it!!!") ➞ "I just!!! can!!! not!!! believe!!! it!"
// Only change repeating punctuation at the end of the sentence.

NoYelling("Oh my goodness!") ➞ "Oh my goodness!"
// Do not change sentences where there exists only one or zero exclamation marks/question marks.

NoYelling("I just cannot believe it.") ➞ "I just cannot believe it."
Notes
Only change ending punctuation - keep the exclamation marks or question marks in the middle of the sentence the same (see third example).
Don't worry about mixed punctuation (no cases that end in something like ?!??!).
Keep sentences that do not have question/exclamation marks the same.

*/


//#############################################################
//#                        MY SOLUTIONS                       #
//#############################################################


/*

Solution 1

*/

public class Program 
{
    public static string NoYelling(string phrase) 
    {
	    if (phrase.EndsWith("!")) {
		  return phrase.TrimEnd('!') + "!";
		}
	  
	    if (phrase.EndsWith("?")) {
		  return phrase.TrimEnd('?') + "?";
		}
	  
	    return phrase;
    }
}


/*

Solution 2

*/


// using System.Text.RegularExpressions;

public class Program 
{
    public static string NoYelling(string phrase) 
    {
			return Regex.Replace(phrase, @"([?|!])\1*$", @"$1");
    }
}



/*

Solution 3

*/

public class Program 
{
    public static string NoYelling(string phrase) 
    {
			
			int i=0;
			while(phrase[phrase.Length-i-1]=='?' || phrase[phrase.Length-i-1]=='!') {
				i++;
			}
			string s="";
			for(int j=0; j<phrase.Length-i; j++){
				s=s+phrase[j];
			}
			
			if(i>0){
				s=s+phrase[phrase.Length-1];
			}
			
			return s;
    }
}



/*

Solution 4

*/