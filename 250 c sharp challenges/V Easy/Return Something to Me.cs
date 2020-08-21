/*

Return Something to Me!
Write a function that returns the string "something" joined with a space and the given parameter a.

Examples
GiveMeSomething("is better than nothing") ➞ "something is better than nothing"

GiveMeSomething("Bob Jane") ➞ "something Bob Jane"

GiveMeSomething("something") ➞ "something something"
Notes
Assume an input is given.

*/





//#############################################################
//#                        MY SOLUTIONS                       #
//#############################################################



/*

Solution 1

*/

public class Program {
    public static string GiveMeSomething(string a) {
        return $"something {a}";
    }
}



/*

Solution 2

*/


public class Program {
    public static string GiveMeSomething(string a) => "something "+a;
}


/*

Solution 3

*/

public class Program {
    public static string GiveMeSomething(string a) {
        return "something "+a;
    }
}

/*

Solution 4

*/