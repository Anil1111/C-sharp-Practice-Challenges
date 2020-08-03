/*

Letters Only
Write a function that removes any non-letters from a string, returning a well-known film title.

Examples
LettersOnly("R!=:~0o0./c&}9k`60=y") ➞ "Rocky"

LettersOnly("^,]%4B|@56a![0{2m>b1&4i4") ➞ "Bambi"

LettersOnly("^U)6$22>8p).") ➞ "Up"
Notes
See the Resources section for more information on C# string methods.

*/








/*

Solution 1

*/


using System.Text.RegularExpressions;
public class Program
{
    public static string LettersOnly(string str)
    {
			return Regex.Replace(str, @"[^a-zA-Z]+","");
    }
}

/*

Solution 2

*/

public class Program
{
    public static string LettersOnly(string str)
    {
			string temp="";
			for(int i=0; i<str.Length; i++) if (str[i]>='a' && str[i]<='z' || str[i]>='A' && str[i]<='Z' ) temp=temp+str[i];
			return temp;
    }
}



/*

Solution 3

*/

public class Program
{
    public static string LettersOnly(string str)
    {
			string lettersOnlyText = string.Empty;
			
			for (int i = 0; i < str.Length; i++)
			{
				if (char.IsLetter(str[i]))
				{
					lettersOnlyText += str[i];
				}
			}
			
			return lettersOnlyText;	
    }
}




/*

Solution 4

*/


//using System.Text.RegularExpressions;
//using System;
//using System.Linq;

public class Program
{
    public static string LettersOnly(string str)
    {
			var onlyLetters = new String(str.Where(Char.IsLetter).ToArray());
													 
			return onlyLetters.ToString();
    }
}





public class Program
{
    public static string LettersOnly(string str)
    {

			string letters = "";
			for (int i=0; i<str.Length; i++){
				if(char.IsLetter(str[i])){
					letters += str[i];
				}
			}
			return letters;
    }
}




public class Program
{
    public static string LettersOnly(string str)
    {
        StringBuilder test = new StringBuilder(str);
        int index = 0;
        while (index < test.Length)
        {
            while (index < test.Length && !char.IsLetter(test[index]))
            {
                test.Remove(index, 1);
            }
            index++;
        }
        return test.ToString();
    }
}




public class Program
{
    public static string LettersOnly(string str)
    {
			string final = "";
			for(int i = 0; i < str.Length ; i++){
				if (char.IsLetter(str[i])){
					final += str[i];
				}
			}
			return final;
    }
}




public class Program
{
    public static string LettersOnly(string str)
    {
			return new String(str.Where(ch => char.IsLetter(ch)).ToArray());
    }
}