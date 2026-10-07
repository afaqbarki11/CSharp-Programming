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
        
    Console.Write("enter your age: ");
    int age = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Age is: " + age);

    Console.Write("Enter Your School name: ");
    string? school = Console.ReadLine();
    Console.WriteLine("The School Name is: " + school);

    Console.Write("Enter your city name: ");
    string? city = Console.ReadLine();
    Console.WriteLine("the city name is: " + city);
    
      }
       
      }
}

