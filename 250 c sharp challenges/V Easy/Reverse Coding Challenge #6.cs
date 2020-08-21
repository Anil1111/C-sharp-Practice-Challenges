/*

Reverse Coding Challenge #6
This is a reverse coding challenge. Normally you're given explicit directions with how to create a function. Here, you must generate your own function to satisfy the relationship between the inputs and outputs.

Your task is to create a function that, when fed the inputs below, produces the sample outputs shown.

Examples
MysteryFunc(152) ➞ 10

MysteryFunc(832) ➞ 48

MysteryFunc(19) ➞ 9

MysteryFunc(133) ➞ 9
Notes

*/






//#############################################################
//#                        MY SOLUTIONS                       #
//#############################################################



/*

Solution 1

*/


public class Program 
{
    public static int MysteryFunc(int num) 
    {
				return (num < 10) ? num : MysteryFunc(num / 10) * MysteryFunc(num % 10) ;
    }
}





/*

Solution 2

*/


public class Program 
{
    public static int MysteryFunc(int num) 
    {
				int sum=1;
			 while(num!=0)
			 {
				 sum*=num%10;
				 num/=10;
			 }
			return sum;
    }
}




/*

Solution 3

*/


using System;
public class Program 
{
    public static int MysteryFunc(int num) 
    {
           int lastNm , firstNm=1;
            var str = Convert.ToString(num);

            for (int i = 0; i < str.Length; i++)
            {
                int.TryParse(str[i].ToString(), out lastNm);

                firstNm *= lastNm;
            }
			return firstNm;
    }
}





/*

Solution 4

*/



using System.Collections.Generic;
public class Program 
{
    public static int MysteryFunc(int num) 
    {
				List<int> temp = new List<int>();
			while(num !=0)
			{
				temp.Add(num % 10);
					num = num / 10;
			}
			int result = 1;
			for(int i = 0; i <= temp.Count-1; i++)
			{
				result = result * temp[i]; 
			}
			return result;
		}
}