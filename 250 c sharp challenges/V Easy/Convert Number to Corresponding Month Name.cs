/*
Convert Number to Corresponding Month Name
Create a function that takes a number (from 1 to 12) and returns its corresponding month name as a string. For example, if you're given 3 as input, your function should return "March", because March is the 3rd month.

Number	Month Name
1	January
2	February
3	March
4	April
5	May
6	June
7	July
8	August
9	September
10	October
11	November
12	December
Examples
MonthName(3) ➞ "March"

MonthName(12) ➞ "December"

MonthName(6) ➞ "June"
Notes
You can expect only integers ranging from 1 to 12 as test input.
If you get stuck on a challenge, find help in the Resources tab.
If you're really stuck, unlock solutions in the Solutions tab.


*/




//#############################################################
//#                        MY SOLUTIONS                       #
//#############################################################






/*

Solution 1

*/

using System.Globalization;
public class Program 
{
    public static string MonthName(int num) 
    {
			return CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(num);
    }
}


/*

Solution 2

*/

public class Program 
{
    public static string MonthName(int num) 
    {
			switch(num) {
				case 1:
					return "January";
				case 2:
					return "February";
				case 3:
					return "March";
				case 4:
					return "April";
				case 5:
					return "May";
				case 6:
					return "June";
				case 7:
					return "July";
				case 8:
					return "August";
				case 9:
					return "September";
				case 10:
					return "October";
				case 11:
					return "November";
				case 12:
					return "December";
				default:
					return "Santa isn't real";
			}
    }
}



/*

Solution 3

*/

public class Program 
{
    public static string MonthName(int num) 
    {
			return new DateTime(1,num, 1).ToString("MMMM");
    }
}

public class Program 
{
    public static string MonthName(int num) 
    {
			Dictionary<int, string> months = new Dictionary<int, string> {
                [1]="January",[2]="February",[3]="March",[4]="April",[5]="May",[6]="June",
                [7]="July",[8]="August",[9]="September",[10]="October",[11]="November",[12]="December"
            };

            return months[num];
    }
}


/*

Solution 4

*/


using System.Collections.Generic;
public class Program 
{
    public static string MonthName(int num) 
    {
			Dictionary<int, string> Months = new Dictionary<int, string>();
			
			Months.Add(1, "January");
			Months.Add(2, "February");
			Months.Add(3, "March");
			Months.Add(4, "April");
			Months.Add(5, "May");
			Months.Add(6, "June");
			Months.Add(7, "July");
			Months.Add(8, "August");
			Months.Add(9, "September");
			Months.Add(10, "October");
			Months.Add(11, "November");
			Months.Add(12, "December");			
			return Months[num];
    }

}





//using System.Globalization;
public class Program 
{
    public static string MonthName(int num) 
    {
	  return DateTimeFormatInfo.CurrentInfo.GetMonthName(num);
    }
}






//using System;
//using System.Collections;
//using System.Linq;
public class Program 
{
    public static string MonthName(int num) 
    {
			var now = DateTime.Now;
			DateTime dt = new DateTime(now.Year, num, 1);
			return( dt.ToString( "MMMM" ) );
    }
}