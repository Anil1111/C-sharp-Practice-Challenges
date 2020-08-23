/*
Filter out Strings from an Array
Create a function that takes an array of non-negative integers and strings and return a new array without the strings.

Examples
FilterArray([1, 2, "a", "b"]) ➞ [1, 2]

FilterArray([1, "a", "b", 0, 15]) ➞ [1, 0, 15]

FilterArray([1, 2, "aasf", "1", "123", 123]) ➞ [1, 2, 123]
Notes
Zero is a non-negative integer.


*/




//#############################################################
//#                        MY SOLUTIONS                       #
//#############################################################





/*

Solution 1

*/
using System.Linq;

public class Program
    {
        public static int[] FilterArray(object[] arr)
        {
            return arr.OfType<int>().ToArray();
        }
    }



/*

Solution 2

*/



public class Program
{
	public static int[] FilterArray(object[] arr) => arr.OfType<int>().ToArray();
}

/*

Solution 3

*/
public class Program
    {
        public static int[] FilterArray(object[] arr)
          => arr.Where(i=>i is int).Cast<int>().ToArray();
    }


/*

Solution 4

*/


public class Program
    {
        public static int[] FilterArray(object[] arr)
        {
            var ints = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i] is Int32)
                {
                    ints.Add((int)arr[i]);
                }
            }
            return ints.ToArray();
        }
    }




    public class Program
    {
        public static int[] FilterArray(object[] arr)
        {
            int count = 0;
          	foreach(object current in arr)
              if(current is int)
                count++;
          	int[] result = new int[count];
          	count = 0;
          	foreach(object current in arr)
              if(current is int)
              	result[count++] = (int)current;
          	return result;
        }
    }



public class Program
    {
        public static int[] FilterArray(object[] arr)
        {
					return arr.Where(a => a.GetType() == typeof(int)).Cast<int>().ToArray();
        }
    }




    public class Program
    {
        public static int[] FilterArray(object[] arr)
        {
            return arr.OfType<int>().ToArray();
        }
    }




public class Program
    {
        public static int[] FilterArray(object[] arr)
        {
            var filteredList = new List<int>();
            int value = 0;
            foreach (var item in arr)
            {
                if (int.TryParse(item.ToString(), out value))
                {
                    filteredList.Add(value);
                }
            }

            return filteredList.Distinct().ToArray();
        }
    }
