using System;

namespace CSharpExercises.Exercises.Basics
{
    class AddAndMultiplyTask
    {
        public static double AddAndMultiply(double a, double b, double c)
        {
            return (a + b) * c;
        }

        public static void Main()
        {
            Console.WriteLine(AddAndMultiply(3, 6, 35));        // 315
            Console.WriteLine(AddAndMultiply(-12, 5, 17));      // -119
            Console.WriteLine(AddAndMultiply(-40, 50, 60));     // 600
            Console.WriteLine(AddAndMultiply(1.7, 9.9, 0.01));  // 0.116
        }
    }
}
