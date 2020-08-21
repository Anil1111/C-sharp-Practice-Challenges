/*
Missing Third Angle
You are given 2 out of 3 angles in a triangle, in degrees.

Write a function that classifies the missing angle as either "acute", "right", or "obtuse" based on its degrees.

An acute angle is less than 90 degrees.
A right angle is exactly 90 degrees.
An obtuse angle is greater than 90 degrees (but less than 180 degrees).
For example: MissingAngle(11, 20) should return "obtuse", since the missing angle would be 149 degrees, which makes it obtuse.

Examples
MissingAngle(27, 59) ➞ "obtuse"

MissingAngle(135, 11) ➞ "acute"

MissingAngle(45, 45) ➞ "right"
Notes
The sum of angles of any triangle is always 180 degrees.


*/



//#############################################################
//#                        MY SOLUTIONS                       #
//#############################################################





/*

Solution 1

*/

public class Program 
{
    public static string MissingAngle(int angle1, int angle2) 
    {
			var angleSum = angle1 + angle2;
			
			if(angleSum != 90)
			{
				return angleSum > 90 ? "acute" : "obtuse";
			}
						
			return "right";
    }
}


/*

Solution 2

*/


public class Program 
{
    public static string MissingAngle(int a, int b) =>
			(a + b == 90) ? "right" : (a + b > 90) ? "acute" : "obtuse";
}



/*

Solution 3

*/


public class Program 
{
    public static string MissingAngle(int angle1, int angle2) 
    {
			int angle = 180 - (angle1 + angle2);
			if(angle > 90)
				return "obtuse";
			else if (angle < 90)
				return "acute";
			return "right";
    }
}



/*

Solution 4

*/


public class Program 
{
    public static string MissingAngle(int angle1, int angle2) 
    {
			//finds last angle
			int res = 180 - (angle1+angle2);
			if(res == 90)
				return "right";
			return res < 90 ? "acute" : "obtuse";			
    }
}