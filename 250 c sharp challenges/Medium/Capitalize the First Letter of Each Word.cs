/*
Capitalize the First Letter of Each Word
Create a function that takes a string as an argument and converts the first character of each word to uppercase. Return the newly formatted string.

Examples
MakeTitle("This is a title") ➞ "This Is A Title"

MakeTitle("capitalize every word") ➞ "Capitalize Every Word"

MakeTitle("I Like Pizza") ➞ "I Like Pizza"

MakeTitle("PIZZA PIZZA PIZZA") ➞ "PIZZA PIZZA PIZZA"
Notes
You can expect a valid string for each test case.

*/





//#############################################################
//#                        MY SOLUTIONS                       #
//#############################################################




/*

Solution 1

*/




using System;
using System.Linq;
public class Program 
{
    public static string MakeTitle(string str) => string.Join(" ", str.Split(' ').Select(s => char.ToUpper(s[0]) + s.Substring(1)));
}






/*

Solution 2

*/


using System;
using System.Linq;
using System.Globalization;
public class Program 
{
    public static string MakeTitle(string str) 
    {
            string[] s = str.Split(' ');
            string result = "";

            foreach (var v in s)
            {
                char[] a = v.ToCharArray();
                a[0] = char.ToUpper(a[0]);
                result += new string(a) + ' ';
            }
            return (result.TrimEnd());;
    }
}




/*

Solution 3

*/


using System;
public class Program 
{
    public static string MakeTitle(string str) 
    {
		  char[] arr = str.ToCharArray();			//Because str.this[int] is read only
			arr[0]=arr[0].ToString().ToUpper()[0];
      for(int i = 0; i<str.Length-1;i++){
				if(str[i]==' '){
					arr[i+1]=str[i+1].ToString().ToUpper()[0];
				}
			}
			return new string(arr);
    }
}



/*

Solution 4

*/


using System;
using System.Linq;
public class Program 
{
    public static string MakeTitle(string str) 
    {
      return string.Join(" ", str.Split(' ').Select(x =>
            {
							return $"{x.Substring(0,1).ToUpper()}{x.Substring(1)}";
            }));
    }
}



using System;
using System.Linq;
public class Program 
{
    public static string MakeTitle(string str) 
    {
      return string.Join(" ", str.Split(' ').Select(x =>
            {
							return $"{x.Substring(0,1).ToUpper()}{x.Substring(1)}";
            }));
    }
}