/*


Add up the Numbers from a Single Number
Create a function that takes a number as an argument. Add up all the numbers from 1 to the number you passed to the function. For example, if the input is 4 then your function should return 10 because 1 + 2 + 3 + 4 = 10.

Examples
AddUp(4) ➞ 10

AddUp(13) ➞ 91

AddUp(600) ➞ 180300
Notes
Expect any positive number between 1 and 1000.

*/











/*

Solution 1

*/


public class Program 
{
    public static int AddUp(int num) 
    {
      	return (num*(num+1))/2;
    }
}




/*

Solution 2

*/


// using System.Linq;
public class Program 
{
    public static int AddUp(int num) => Enumerable.Range(1, num).Sum();
}




/*

Solution 3


*/


public class Program 
{
    public static int AddUp(int num) => (num * (num+1)) / 2 ;
    
}



public class Program 
{
    public static int AddUp(int num) 
    {
      int i = 1;
			int sum = 0;
			while(i <= num){
				sum += i;
				i++;
			}
			return sum;
    }
}