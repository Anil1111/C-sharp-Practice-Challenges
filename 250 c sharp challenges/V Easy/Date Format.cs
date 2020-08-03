/*

Date Format
Create a function that converts a date formatted as MM/DD/YYYY to YYYYDDMM.

Examples
FormatDate("11/12/2019") ➞ "20191211"

FormatDate("12/31/2019") ➞ "20193112"

FormatDate("01/15/2019") ➞ "20191501"
Notes
Return value should be a string.

*/








/*

Solution 1

*/

public class Program 
{
    public static string FormatDate(string date) 
    {
		  	DateTime inputDate = DateTime.Parse(date);
				return inputDate.ToString("yyyydMM");
    }
}


/*

Solution 2

*/


//using System;
//using System.Globalization;
public class Program 
{
    public static string FormatDate(string date) 
    {
			return Convert.ToDateTime(date).ToString("yyyyddMM");
    }
}


/*

Solution 3

*/

public class Program 
{
    public static string FormatDate(string date) 
    {
  		//MM/DD/YYYY to YYYYDDMM.
	  
	  	return date.Substring(6,4) + date.Substring(3,2) + date.Substring(0,2);
    }
}

/*

Solution 4

*/



//using System;

public class Program 
{
    public static string FormatDate(string date) 
    {
        var inter = DateTime.Parse(date);
        return $"{inter:yyyyddMM}";
    }
}