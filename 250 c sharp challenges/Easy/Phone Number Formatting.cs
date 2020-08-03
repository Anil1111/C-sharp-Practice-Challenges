/*


Phone Number Formatting
Create a function that takes an array of 10 numbers (between 0 and 9) and returns a string of those numbers formatted as a phone number (e.g. (555) 555-5555).

Examples
FormatPhoneNumber([1, 2, 3, 4, 5, 6, 7, 8, 9, 0]) ➞ "(123) 456-7890"

FormatPhoneNumber([5, 1, 9, 5, 5, 5, 4, 4, 6, 8]) ➞ "(519) 555-4468"

FormatPhoneNumber([3, 4, 5, 5, 0, 1, 2, 5, 2, 7]) ➞ "(345) 501-2527"
Notes
Don't forget the space after the closing parenthesis.
*/








/*

Solution 1

*/
using System.Linq;
public class Program 
{
    public static string FormatPhoneNumber(int[] numbers) 
    {
      return string.Format("({0}{1}{2}) {3}{4}{5}-{6}{7}{8}{9}",numbers.Select(x=>x.ToString()).ToArray());
		}
}



/*

Solution 2

*/


public class Program 
{
    public static string FormatPhoneNumber(int[] numbers) 
    {
      return ("(" + numbers[0] + numbers[1] + numbers[2] + ") " + numbers[3] + numbers[4] + numbers[5] +"-"+ numbers[6] + numbers[7] + numbers[8] + numbers[9]);
    }
}

/*

Solution 3

*/

//using System.Linq;

public class Program 
{
    public static string FormatPhoneNumber(int[] numbers) 
    {
    	var ns = new [] {numbers.Take(3),numbers.Skip(3).Take(3),numbers.Skip(6)}
        							.Select(n => string.Concat(n)).ToArray();
      return $"({ns[0]}) {ns[1]}-{ns[2]}";
    }
}
/*

Solution 4

*/

public class Program 
{
    public static string FormatPhoneNumber(int[] numbers) 
    {
      if (numbers.Length > 10) return "";
			string phoneNo;
			phoneNo = "(";
			for (int i = 0; i < 3; i++)
			{
				phoneNo += numbers[i].ToString();
			}
			phoneNo += ") ";
			
			for (int i = 3; i < 6; i++)
			{
				phoneNo += numbers[i].ToString();
			}
			phoneNo += "-";
			
			for (int i = 6; i < numbers.Length; i++)
			{
				phoneNo += numbers[i].ToString();
			}
			return phoneNo;
    }
}
