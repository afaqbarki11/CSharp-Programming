 using System;
using System.Globalization;

namespace CSharpLearning.Basics
{
    internal class Operators
    {         
    public static void Run()
          {
            //Arithmetic Operators

            int num1 = 20;
            int num2 = 10;
            Console.WriteLine("addition is: " + (num1 + num2));
            Console.WriteLine("subtraction is: " + (num1 - num2));
            Console.WriteLine("multiplication is: " + (num1 * num2));
            Console.WriteLine("division is: " + (num1 / num2));
            Console.WriteLine("remainder is: " + (num1 % num2));

            int sum1 = 100 + 50;        // 150 (100 + 50)
            int sum2 = sum1 + 250;      // 400 (150 + 250)
            int sum3 = sum2 + sum2;     // 800 (400 + 400)
          
           // Comaparison Operator
           int x = 5;
           int y = 3;
           Console.WriteLine(x > y); // returns True because 5 is greater than 3
          
          // Logical Operators

          int first_num = 32;
          int second_num = 22;
          if(first_num > 20 && second_num > 20){
        Console.WriteLine("both numbers are greater than 20.");
      }

          }
    }
}