/*

Check if a String Contains only Identical Characters
Write a function that returns true if all characters in a string are identical and false otherwise.

Examples
isIdentical("aaaaaa") ➞ true

isIdentical("aabaaa") ➞ false

isIdentical("ccccca") ➞ false

isIdentical("kk") ➞ true
Notes

*/








/*

Solution 1

*/


using System.Linq;

public class Program
{
    public static bool isIdentical(string str)
    {
			return str.Distinct().Count() == 1;
    }
}

/*

Solution 2

*/



//using System.Linq;

public class Program
{
    public static bool isIdentical(string str)
    {
			return str.All(a => a == str[0]);
    }
}




//using System.Linq;
public class Program
{
    public static bool isIdentical(string str) => str.ToArray().GroupBy(s => s).Count() == 1;
}


/*

Solution 3

*/



public class Program
{
    public static bool isIdentical(string str)
    {
			char a = str[0];
          
            for (int i = 0; i < str.Length; i++)
            {
                if (a != str[i])
                {
                    return false;
                }
            }

            return true ;
    }
}



public class Program
{
    public static bool isIdentical(string str)
    {
			return str.All( c => c == str[0]);
    }
}





/*

Solution 4

*/



public class Program
{
    public static bool isIdentical(string str)
    {
			char start = str[0];
			for(int i = 1; i < str.Length; i++){
				if(str[i] != start)
					return false;
			}
			return true;
    }
}



public class Program
{
    public static bool isIdentical(string str)
    {
	  for(int i=0; i<str.Length-1;i++)
	  {
		if(!str[i].Equals(str[i+1]))
		  return false;
	  }
	  return true;
    }
}



public class Program
{
    public static bool isIdentical(string str)
    { 
			for (int i =0; i < str.Length; i++)
				if (str[i] != str[0])
				return false;
				return true;
	
    }
}




public class Program
{
    public static bool isIdentical(string str)
    {
			int n = str.Length;
			for (int i = 1; i < n; i++)
				 if (str[i] != str[0]) 
            return false; 
			return true;
    }
}



public class Program
{
    public static bool isIdentical(string str)
    {
			for(int i=1; i<str.Length; i++)
			{
				if (str[i] != str[0])
					return false;
			}
			return true;
    }
}