 using System;
namespace CSharpLearning.Basics
{
    internal class UserInput
    {         
    public static void Run()
          { 

    Console.Write("Enter your name: ");
    string? name = Console.ReadLine();
    Console.WriteLine("Hello " + name);
        
          }
    }

}