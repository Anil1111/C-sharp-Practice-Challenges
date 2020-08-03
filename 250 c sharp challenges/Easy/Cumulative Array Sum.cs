/*

Cumulative Array Sum
Create a function that takes an array of numbers and returns an array where each number is the sum of itself + all previous numbers in the array.

Examples
CumulativeSum([1, 2, 3]) ➞ [1, 3, 6]

CumulativeSum([1, -2, 3]) ➞ [1, -1, 2]

CumulativeSum([3, 3, -2, 408, 3, 3]) ➞ [3, 6, 4, 412, 415, 418]
Notes
Return an empty array if the input is an empty array.

*/








/*

Solution 1

*/
public class Program 
{
    public static double[] CumulativeSum(double[] arr) 
    {
			for (int i = 1; i < arr.Length; i++) {
				arr[i] = arr[i] + arr[i - 1];
			}
			
			return arr;
    }
}



/*

Solution 2

*/

//using System.Linq;
public class Program 
{
    public static double[] CumulativeSum(double[] arr)
      => Enumerable.Range(1, arr.Length).Select(i => arr.Take(i).Sum()).ToArray();
}



public class Program 
{
    public static double[] CumulativeSum(double[] arr) 
    {
	  for (int i = 1; i < arr.Length; i++)
	  {
		arr[i] += arr[i-1];
	  }
	  return arr;
    }
}


/*

Solution 3

*/


public class Program 
{
    public static double[] CumulativeSum(double[] arr) 
    {
			double sum = 0;
      return arr.Select(n => {sum +=n ; return sum;}).ToArray();
    }
}

/*

Solution 4

*/



public class Program 
{
        public static double[] CumulativeSum(double[] arr) => RealCumulativeSum(arr).ToArray();
        
  			private static IEnumerable<double> RealCumulativeSum(IEnumerable<double> numbers) {
            var d = default(double);
            foreach (var number in numbers){
                d += number;
                yield return d;
            }
        }
}



public class Program 
{
    public static double[] CumulativeSum(double[] arr) 
    {
      double sum=0;
      double[] result=new double[arr.Length];
      for (int i=0;i<arr.Length;i++)
      {
        sum+=arr[i];
        result[i]=sum;
      }
      
      return result;
    }
}





public class Program 
{
    public static double[] CumulativeSum(double[] arr) 
    {
        double sum = 0;
        List<double> newArr = new List<double>();
      
        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
            newArr.Add(sum);
        }
      
        return newArr.ToArray();
    }
}



public class Program 
{
    public static double[] CumulativeSum(double[] arr) 
    {
var ret = new double[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                double temp = 0d;
                for (int j = 0; j <= i; j++)
                {
                    temp += arr[j];
                }
                ret[i] = temp;
            }

            return ret;
    }
}



public class Program 
{
    public static double[] CumulativeSum(double[] arr) 
    {
      	var sums = new double[arr.Length];
				for(int i = 0; i < arr.Length; i++)
        {
          	var sum = 0.0;
    				for(int j = 0; j <= i; j++)
            {
              	sum += arr[j];
            }
          	sums[i] = sum;
        }
      
      	return sums;
    }
}



//using System.Linq;

public class Program 
{
    public static double[] CumulativeSum(double[] arr) =>
			arr.Select((x, i) => arr.Take(i+1).Sum()).ToArray();
}
