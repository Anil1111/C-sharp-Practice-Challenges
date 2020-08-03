/*


Remove Duplicates from an Array
Create a function that takes an array of items, removes all duplicate items and returns a new array in the same sequential order as the old array (minus duplicates).

Examples
RemoveDups([1, 0, 1, 0]) ➞ [1, 0]

RemoveDups(["The", "big", "cat"]) ➞ ["The", "big", "cat"]

RemoveDups(["John", "Taylor", "John"]) ➞ ["John", "Taylor"]
Notes
Tests contain arrays with both strings and numbers.
Tests are case sensitive.
*/








/*

Solution 1

*/

using System.Linq;
public class Program 
{
    public static object[] RemoveDups(object[] str) => str.Distinct().ToArray();
}


/*

Solution 2

*/
public class Program 
{
    public static object[] RemoveDups(object[] str) 
    {
      return str.Distinct().ToArray();
    }
}




public class Program 
{
    public static object[] RemoveDups(object[] str) 
    {
      	var returnList = str.ToList().Distinct();
      	return returnList.ToArray();
    }
}


/*

Solution 3

*/



//using System.Linq;
public class Program 
{
    public static object[] RemoveDups(object[] str) => str.Distinct().ToArray();
    
}





public class Program 
{
    public static object[] RemoveDups(object[] str) 
    {
      return str.Distinct().ToArray();
    }
}




/*

Solution 4

*/



public class Program 
{
    public static object[] RemoveDups(object[] s) => s.Distinct().ToArray();
}



public class Program 
{
    public static object[] RemoveDups(object[] str) 
    {
      IEnumerable<object> distinctItems = str.Distinct();
      return distinctItems.ToArray();
    }
}