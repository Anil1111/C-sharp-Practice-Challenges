/*
Days in a Month
Create a function that takes the month and year (as integers) and returns the number of days in that month.

Examples
Days(2, 2018) ➞ 28

Days(4, 654) ➞ 30

Days(2, 200) ➞ 29

Days(2, 1000) ➞ 29
Notes
Although you can create the algorithm to determine the leap-year number for February, there is a library function that can really help.


*/




//#############################################################
//#                        MY SOLUTIONS                       #
//#############################################################






/*

Solution 1

*/


using System;
public class Program
{
    public static int Days(int month, int year)
    {
			return DateTime.DaysInMonth(year, month);
    }
}

/*

Solution 2

*/


public class Program
{
    public static int Days(int month, int year)
    {
			int[] days = new int[] {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
			if (month == 2 && year % 4 == 0 && year % 100 != 0 || year % 400 == 0){
				return 29;
			} else return days[month-1];
    }
}


/*

Solution 3

*/

public class Program
{
    public static int Days(int month, int year) => System.DateTime.DaysInMonth(year, month);
}

/*

Solution 4

*/


using System;
public class Program
{
    public static int Days(int month, int year)
    {
			return (System.DateTime.DaysInMonth(year, month));
    }
}



public class Program
{
    public static int Days(int month, int year)
    {
			return System.DateTime.DaysInMonth(year,month);
    }
}





public class Program
{
    public static int Days(int month, int year)
    {
			int[] months= new int[]{31,28,31,30,31,30,31,31,30,31,30,31};
			int days;
			
			if((month == 2) && (year % 4 == 0))
			{
				if((year % 100 == 0) && (year % 400 != 0))
					days = 28;
				else
					days = 29;
			}
			else
				days = months[month - 1];
			
			return days;		
    }
}









public class Program
{
	public static int Days(int month, int year)
	{
		return System.DateTime.DaysInMonth(year, month);
	}
}