/*


Eliminate Odd Numbers within an Array
Create a function that takes an array of numbers and returns only the even values.

Examples
NoOdds([1, 2, 3, 4, 5, 6, 7, 8]) ➞ [2, 4, 6, 8]

NoOdds([43, 65, 23, 89, 53, 9, 6]) ➞ [6]

NoOdds([718, 991, 449, 644, 380, 440]) ➞ [718, 644, 380, 440]
Notes
Return all even numbers in the order they were given.
All test cases contain valid numbers ranging from 1 to 3000.

*/








/*

Solution 1

*/


using System.Linq;

public class Program
    {
        public static int[] NoOdds(int[] arr)
        {
            return arr.Where(n => n % 2 == 0).ToArray();
        }
    }

/*

Solution 2

*/


//using System.Collections.Generic;

public class Program
    {
        public static int[] NoOdds(int[] arr)
        {
          	List<int> ints = new List<int>();
            for(var i = 0; i<arr.Length; i++){
              if (arr[i] % 2 == 0) {
                ints.Add(arr[i]);
              }
            }
          return ints.ToArray();
        }
    }


/*

Solution 3

*/

//using System.Linq;

public class Program
    {
        public static int[] NoOdds(int[] arr) => arr.Where(i=>i % 2 == 0).ToArray();
    }


/*

Solution 4

*/


public class Program
    {
        public static int[] NoOdds(int[] arr)
        {
            return arr.Where(n => n % 2 == 0).ToArray();
        }
    }





//using System.Linq;
public class Program
    {
        public static int[] NoOdds(int[] arr) => arr.Where(i => i%2 == 0).ToArray();
    }




    //using System.Linq;
public class Program
    {
        public static int[] NoOdds(int[] arr)
        {
            return arr.Where(i => (i & 1) == 0).ToArray();
        }
    }





    //using System.Linq;
public class Program
{
    public static int[] NoOdds(int[] arr) => arr.Where(v => v % 2 == 0).ToArray();
}





//using System.Linq;
public class Program
    {
        public static int[] NoOdds(int[] arr) => arr.Where(x => x % 2 == 0).ToArray();
    }