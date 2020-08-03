/*
Purge and Organize
Given an array of numbers, write a function that returns an array that...

Has all duplicate elements removed.
Is sorted from least value to greatest value.
Examples
UniqueSort([1, 2, 4, 3]) ➞ [1, 2, 3, 4]

UniqueSort([1, 4, 4, 4, 4, 4, 3, 2, 1, 2]) ➞ [1, 2, 3, 4]

UniqueSort([6, 7, 3, 2, 1]) ➞ [1, 2, 3, 6, 7]
Notes


*/








/*

Solution 1

*/
using System.Linq;
public class Program
    {
        public static double[] UniqueSort(double[] arr) => arr.Distinct().OrderBy(a=>a).ToArray();
    }



/*

Solution 2

*/


public class Program
    {
        public static double[] UniqueSort(double[] arr)
        {
          return arr.Distinct().OrderBy(n => n).ToArray();
        }
    }


/*

Solution 3

*/

public class Program
    {
        public static double[] UniqueSort(double[] arr)
        {
          Array.Sort(arr);
      		var stuff = arr.Distinct();
     		 	return stuff.ToArray();
        }
    }




public class Program
{
    public static double[] UniqueSort(double[] arr)
    {
				return arr.Distinct().OrderBy(x => x).ToArray();
    }
}



public class Program
    {
        public static double[] UniqueSort(double[] arr)
        {
            var singlesOnly = arr
              .Select(item => item).Distinct().OrderBy(name=>name);
            return singlesOnly.ToArray();
        }
    }


public class Program
    {
        public static double[] UniqueSort(double[] arr)
        {
            List<double> fin = new List<double>();
          for (int i = 0; i < arr.Length; i++) {
            if (!fin.Contains(arr[i])) {
              fin.Add(arr[i]);
            }
          }
          fin.Sort();
          return fin.ToArray();
        }
    }




/*



Solution 4

*/



public class Program
    {
        public static double[] UniqueSort(double[] arr)
        {
            return arr.Distinct().OrderBy(n=>n).ToArray();
        }
    }






    public class Program
    {
        public static double[] UniqueSort(double[] arr)
        {
            return arr.Distinct().OrderBy(e => e).ToArray();
        }
    }



    public class Program
    {
        public static double[] UniqueSort(double[] arr)
        {
					return arr.Distinct().OrderBy(x=>x).ToArray();
        }
    }




    public class Program
    {
        public static double[] UniqueSort(double[] arr)
        {
           return arr.Distinct().OrderBy(x => x).ToArray(); 
        }
    }




    public class Program
    {
        public static double[] UniqueSort(double[] arr)
        {
   				return arr.GroupBy(d => d).Select(d => d.First()).OrderBy(d => d).ToArray();        
        }
    }




    public class Program
    {
        public static double[] UniqueSort(double[] arr)
        {
            List<double> answer = new List<double>();
						foreach(double number in arr)
						{
							if (!answer.Contains(number)) answer.Add(number);
						}
					answer.Sort();
					return answer.ToArray();
        }
    }