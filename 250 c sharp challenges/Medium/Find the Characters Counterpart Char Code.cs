/*


Find the Characters Counterpart Char Code
Create a function that takes a single character as an argument and returns the char code of its lowercased / uppercased counterpart.

Examples
Given that:
  - "A" char code is: 65
  - "a" char code is: 97

CounterpartCharCode("A") ➞ 97

CounterpartCharCode("a") ➞ 65
Notes
The argument will always be a single character.
Not all inputs will have a counterpart (e.g. numbers), in which case return the inputs char code.
*/








/*

Solution 1

*/


public class Program 
{
    public static int CounterpartCharCode(char symbol) 
    {
			if (char.IsLetter(symbol))
            {
                char ch = char.IsLower(symbol) ? char.ToUpper(symbol) : char.ToLower(symbol);
                return (int)ch;
            }
            return (int)symbol;
    }
}

/*

Solution 2

*/

public class Program 
{
    public static int CounterpartCharCode(char symbol) 
    {        
			if (char.IsLower(symbol))
            symbol = char.ToUpper(symbol);
        else
            symbol = char.ToLower(symbol);

        return (int)symbol;
    }
}



/*

Solution 3

*/


//using System;
//using System.Linq;

public class Program 
{
    public static int CounterpartCharCode(char symbol) 
    {
			if (Char.IsLower(symbol)) {
				return Char.ToUpper(symbol);
			} else {
				return Char.ToLower(symbol);
			}
    }
}
/*

Solution 4

*/