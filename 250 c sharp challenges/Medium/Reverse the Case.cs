/*

Reverse the Case
Given a string, create a function to reverse the case. All lower-cased letters should be upper-cased, and vice versa.

Examples
ReverseCase("Happy Birthday") ➞ "hAPPY bIRTHDAY"

ReverseCase("MANY THANKS") ➞ "many thanks"

ReverseCase("sPoNtAnEoUs") ➞ "SpOnTaNeOuS"
Notes

*/








/*

Solution 1

*/


using System.Linq;
public class Program 
{
    public static string ReverseCase(string str) 
    {
			return string.Concat(str.Select(x=>char.IsUpper(x)?char.ToLower(x):char.ToUpper(x)));
    }
}

/*

Solution 2

*/


public class Program 
{
    public static string ReverseCase(string str) 
    {
			string s="";
			for(int i=0; i<str.Length; i++){
				if(str[i]==str.ToUpper()[i]){
					s=s+str.ToLower()[i];											
				}
			else {
					s=s+str.ToUpper()[i];
			}
			}
			return s;
    }
}


/*

Solution 3

*/

public class Program 
{
    public static string ReverseCase(string str) 
    {
			string res = "";
      for (int i = 0; i < str.Length; i++)
      {
          if (str[i].ToString() == str[i].ToString().ToLower()) res += str[i].ToString().ToUpper();
          else res += str[i].ToString().ToLower();
      }
      return res;
    }
}


/*

Solution 4

*/



//using System;
//using System.Linq;
public class Program 
{
    public static string ReverseCase(string str) 
    {
			return new string(str.Select(s => char.IsUpper(s) ? char.ToLower(s) : char.ToUpper(s)).ToArray());
    }
}




//using System;
public class Program 
{
    public static string ReverseCase(string str) 
    {
			char[] resultArray = new char[str.Length];
      for (int i = 0; i < str.Length; i++)
      {
      	if (char.IsUpper(str[i])) resultArray[i] = char.ToLower(str[i]);
        else resultArray[i] = char.ToUpper(str[i]);
      }
			return new string(resultArray);
    }
}



public class Program 
{
    public static string ReverseCase(string str) 
    {
			string nstr = "";
			for(int i = 0 ; i < str.Length; i++)
			{
				if(char.IsUpper(str[i]))
					nstr += char.ToLower(str[i]);
				else
					nstr += char.ToUpper(str[i]);
			}
			return nstr;
    }
}