using System;
using System.Globalization;
using System.Net.NetworkInformation;
using System.Runtime.Intrinsics.X86;

namespace CSharpLearning.Basics
{
    internal class VariablesAndDataTypes
    {
        public static void Run()
        {
            // Variables
            string name = "Afaq Ahmad";
            int age = 23;
            age = 24;
            double height = 5.11;
            bool isStudent = true;
            char alphabet = 'a';

            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Height: " + height);
            Console.WriteLine("Student: " + isStudent);
            Console.WriteLine("Alphabet: " + alphabet);

            //Constants
            const double pai = 3.14;
            Console.WriteLine("pai: " + pai);

            //Display Variable
            string firstname = "afaq ";
            string lastname = "ahmad";
            String fullname = firstname + lastname;
            Console.WriteLine("full name is: " + fullname);

            // Mathemathical Operators
            float x = 10;
            float y = 23;
            Console.WriteLine($"Addition is: {x + y}");
            Console.WriteLine($"Subtraction is: {x - y}");
            Console.WriteLine($"Multiplication is: {x * y}");
            Console.WriteLine($"Division is: {x / y}");

            // Multiple Variables
            int a = 50, b = 50, c = 50;
            Console.WriteLine(a + b + c);

            int d; int e; int f;
            d = e = f = 50;
            Console.WriteLine(d + e + f);

            //DataTypes
            // static integer values
            int myNum = 10000;
            Console.WriteLine(myNum); // use "int" for short Numerical Value  

            long Num1 = 10000000000000000L;
            Console.WriteLine(Num1);  // use "Long" for large Numerical Value

            // For Decimal values
            float num2 = 14.34F;
            Console.WriteLine(num2);  // upto 6 or 7 floating numbers

            double num3 = 23.54D;
            Console.WriteLine(num3); // upto 15 floating numbers

            float f1 = 35e3F;
            double d1 = 12E4D;
            Console.WriteLine(f1);
            Console.WriteLine(d1);


        }
    }
}