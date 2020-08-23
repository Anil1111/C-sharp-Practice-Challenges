/*

Check if a Number is a Palindrome
Create a function that returns true if a number is a palindrome.

Examples
IsPalindrome(838) ➞ true

IsPalindrome(4433) ➞ false

IsPalindrome(443344) ➞ true
Notes
A palindrome is a number that remains the same when reversed.
Bonus: Try solving this without turning the number into a string.

*/





//#############################################################
//#                        MY SOLUTIONS                       #
//#############################################################




/*

Solution 1

*/


using System.Linq;

public class Program
{
    public static bool IsPalindrome(int num)
    {
		return num.ToString() == string.Concat(num.ToString().Reverse().ToArray());
    }
}

/*

Solution 2

*/

public class Program
{
    public static bool IsPalindrome(int num)
    {
			 int remainder,sum=0,temp=num;     
          while(num>0)      
          {      
           remainder=num%10;      
           sum=(sum*10)+remainder;      
           num=num/10;      
          }      
       if(temp==sum)
				return true;
			return false;
    }
}



/*

Solution 3

*/

public class Program
{
    public static bool IsPalindrome(int num)
    {
        string str = num.ToString();
        for (int i = 0; i <= str.Length/2; i++)
        {
            if (!(str[i] == str[str.Length-1-i]))
            {
                return false;
            }
        }
        return true;			
    }
}

/*

Solution 4

*/


public class Program {
	public static bool IsPalindrome(int num) {
		string str = num.ToString();
		for (int i = 0; i < str.Length; i += 1) {
			if (str[i] != str[str.Length - i - 1]) {
				return false;
			}
		}
		
		return true;
	}
}