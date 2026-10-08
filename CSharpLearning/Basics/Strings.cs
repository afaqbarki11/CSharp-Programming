 using System;
namespace CSharpLearning.Basics
{
    internal class Strings
    {         
    public static void Run()
          {     

            string greeting = "Hello";
            string greeting2 = "Nice to meet you!";
            Console.WriteLine(greeting + " " + greeting2);

            string txt = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Console.WriteLine("The length of the txt string is: " + txt.Length);
            Console.WriteLine("The greeting is: " + greeting);
            Console.WriteLine("The second greeting is: " + greeting2);

            // to Uppercase // to Lowercase
            string txt2 = "Hello World";
            Console.WriteLine(txt2.ToUpper());
            Console.WriteLine(txt2.ToLower()); 
          }
    }
}