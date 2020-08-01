/*
Multiple of 100
Create a function that takes an integer and return true if it's divisible by 100, otherwise return false.

Examples
Divisible(1) ➞ false

Divisible(1000) ➞ true

Divisible(100) ➞ true
Notes
Don't forget to return the result.
If you get stuck on a challenge, find help in the Resources tab.
If you're really stuck, unlock solutions in the Solutions tab.
*/



public class Program 
{
    public static bool Divisible(int number) 
    {
			return (number % 100 == 0);
    }
}



class Program{public static bool Divisible(int n)=>n%100==0;}