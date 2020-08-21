/*


Profitable Gamble
Create a function that takes in three arguments (prob, prize, pay) and returns true if prob * prize > pay; otherwise return false.

To illustrate, ProfitableGamble(0.2, 50, 9) should yield true, since the net profit is 1 (0.2 * 50 - 9), and 1 > 0.

Examples
ProfitableGamble(0.2, 50, 9) ➞ true

ProfitableGamble(0.9, 1, 2) ➞ false

ProfitableGamble(0.9, 3, 2) ➞ true
Notes
A profitable gamble is a game that yields a positive net profit, where net profit is calculated in the following manner: net_outcome = probability_of_winning * prize - cost_of_playing.

*/



//#############################################################
//#                        MY SOLUTIONS                       #
//#############################################################




/*

Solution 1

*/



public class Program 
{
    public static bool ProfitableGamble(double prob, int prize, double pay) 
    {
				return (prob * prize) > pay;
    }
}



/*

Solution 2

*/

public class Program 
{
    public static bool ProfitableGamble(double prob, int prize, double pay) 
    {
				return prob * (double)prize > pay;
    }
}





/*

Solution 3


*/




public class Program 
{
    public static bool ProfitableGamble(double prob, int prize, double pay) 
    {
			if ((prob * prize) > pay)
			{
				return true;
			}
			else
			{
				return false;
			}
    }
}