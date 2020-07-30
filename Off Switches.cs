/*
On/Off Switches
Create a function that returns how many possible outcomes can come from a certain number of switches (on / off).

Examples
PosCom(1) ➞ 2

PosCom(3) ➞ 8

PosCom(10) ➞ 1024



*/


public class Program {
	public static int PosCom(int n) => 1 << n;
}




public class Program {
	 
		  public static int PosCom(int n)
      {
        int result=2;
		    for(int i=1;i<n;i++)
        {
           result*=2;
        }
        return result;
	    } 
	 
}



using System;
public class Program {
	public static int PosCom(int n) {
		return (int)Math.Pow(2,n);
	}
}





