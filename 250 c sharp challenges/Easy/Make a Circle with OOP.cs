/*

Make a Circle with OOP
Your task is to create a Circle constructor that creates a circle with a radius provided by an argument. The circles constructed must have two getters GetArea() (PIr^2) and GetPerimeter() (2PI*r) which give both respective areas and perimeter (circumference).

For help with this class, I have provided you with a Rectangle constructor which you can use as a base example.

Examples
Circle circy = new Circle(11);
circy.GetArea();

// Should return 380.132711084365.

Circle circy = new Circle(4.44);
circy.GetPerimeter();

// Should return 27.897342763877365
Notes
Don't worry about floating point precision - I've factored in the chance that your answer may be more or less accurate than mine. This is more of a tutorial than a challenge so the topic covered may be considered advanced, yet the challenge is more simple - so if this challenge gets labelled as easy, don't worry too much.

*/








/*

Solution 1

*/

using System;
public class Circle {
  			private double _radius;
        public Circle(double radius){
          _radius = radius;
        }
        public double GetArea() => Math.PI * _radius * _radius;
        public double GetPerimeter() => 2 * Math.PI * _radius;
}


/*

Solution 2

*/

class Rectangle
{
    public double SideA;
    public double SideB;
    public Rectangle(double sideA, double sideB){
        SideA = sideA;
        SideB = sideB;
    }
    public double GetArea(){
        return SideA * SideB;
    }
    public double GetPerimeter(){
        return (SideA + SideB) * 2;
    }
}


public class Circle {
		double r;
  	public Circle (double r)
    {
      	this.r = r;
    }
  
  	public double GetArea() => r * r * Math.PI;
		public double GetPerimeter() => 2 * r * Math.PI;
}

//unquote and use run to test these cases
//public class Program{
//  public static void Main(int[] args){
//    var q = new Circle(4.44);
//    Console.WriteLine(q.GetArea());
//    Console.WriteLine(q.GetPerimeter());
//  }
//}



/*

Solution 3

*/

class Rectangle
    {
        public double SideA;
        public double SideB;
        public Rectangle(double sideA, double sideB){
            SideA = sideA;
            SideB = sideB;
        }
        public double GetArea(){
            return SideA * SideB;
        }
        public double GetPerimeter(){
            return (SideA + SideB) * 2;
        }
    }


	public class Circle
    {
      public double Radius {get; set;}

      public Circle(double radiusP)
      {
        Radius = radiusP;
      }

      public double GetArea()
      {
        return Math.PI*Math.Pow(Radius,2);
      }

      public double GetPerimeter()
      {
        return (2 * Math.PI) * Radius;
      }
    }

//unquote and use run to test these cases
public class Program{
  public static void Main(int[] args){
    var q = new Circle(4.44);
    Console.WriteLine(q.GetArea());
    Console.WriteLine(q.GetPerimeter());
  }
}


/*

Solution 4

*/



class Rectangle
    {
        public double SideA;
        public double SideB;
        public Rectangle(double sideA, double sideB){
            SideA = sideA;
            SideB = sideB;
        }
        public double GetArea(){
            return SideA * SideB;
        }
        public double GetPerimeter(){
            return (SideA + SideB) * 2;
        }
    }


public class Circle {
  public double _radius { get; set; }
  public Circle(double radius) {
    this._radius = radius;
  }
	public double GetArea() => Math.Pow(_radius, 2.0) * Math.PI;
  public double GetPerimeter() => Math.PI * 2 * _radius;
  
}

//UNQUOTE AND USE RUN TO TEST THESE CASES
//PUBLIC CLASS PROGRAM{
//  PUBLIC STATIC VOID MAIN(INT[] ARGS){
//    VAR Q = NEW CIRCLE(4.44);
//    CONSOLE.WRITELINE(Q.GETAREA());
//    CONSOLE.WRITELINE(Q.GETPERIMETER());
//  }
//}