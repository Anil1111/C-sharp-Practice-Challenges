/*


Hamming Distance
Hamming distance is the number of characters that differ between two strings.

To illustrate:

String1: "abcbba"
String2: "abcbda"

Hamming Distance: 1 - "b" vs. "d" is the only difference.
Create a function that computes the hamming distance between two strings.

Examples
HammingDistance("abcde", "bcdef") ➞ 5

HammingDistance("abcde", "abcde") ➞ 0

HammingDistance("strong", "strung") ➞ 1
Notes
Both strings will have the same length.

*/








/*

Solution 1

*/


using System.Linq;

public class Program
{
    public static int HammingDistance(string str1, string str2)
    {
				return str1.Where((t, x) => t != str2[x]).Count();
    }
}

/*

Solution 2

*/

public class Program
{
    public static int HammingDistance(string str1, string str2)
    {
			int d = 0;
			for(int i = 0; i < str1.Length; i++){
				if(str1[i] != str2[i]) d++;
			}
			return d;
    }
}



public class Program
{
    public static int HammingDistance(string str1, string str2)
    {
			int numOfChrMissing = 0;
			for (int i = 0; i < str1.Length; i++)
			{
				if (str1[i] != str2[i])
				{
					numOfChrMissing++;
				}
			}
			return numOfChrMissing;
    }
}




public class Program
{
    public static int HammingDistance(string str1, string str2)
    {
	  int count = 0;
    for (int i = 0; i < str1.Length; i++)
    {
        if (str1[i] != str2[i])
            count++;        
    }
    return count;
    }
}

/*

Solution 3

*/

public class Program
{
    public static int HammingDistance(string str1, string str2)
    {
			int count = 0;
			
			for(int c=0; c<str1.Length; c++){
				if(str1[c]!= str2[c]){
					count++;
				}
			}
			
			return count;
    }
}

/*

Solution 4

*/



public class Program
{
    public static int HammingDistance(string str1, string str2)
    {
			if (str1.Equals(str2)) return 0;
			
			var charStr1 = str1.ToCharArray();
			var charStr2 = str2.ToCharArray();
			int result= 0;
			
			for(int i =0; i< str1.Length; i++)
			{
				if(charStr1[i].Equals(charStr2[i])) continue;
				result++;
			}
			return result;
    }
}