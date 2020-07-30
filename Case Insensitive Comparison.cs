/*
Case Insensitive Comparison
Write a function that validates whether two strings are identical. Make it case insensitive.

Examples
match("hello", "hELLo") ➞ true

match("motive", "emotive") ➞ false

match("venom", "VENOM") ➞ true

match("mask", "mAskinG") ➞ false
*/




public class Program
{
    public static bool match(string s1, string s2)
    {
			return s1.ToLower() == s2.ToLower();
    }
}


public class Program
{
    public static bool match(string s1, string s2)
    {
			return s1.ToLower() == s2.ToLower() ? true : false;
    }
}


public class Program
{
    public static bool match(string s1, string s2)
    {
			return (s1.ToLower() == s2.ToLower());
    }
}