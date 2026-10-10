using System;

namespace CSharpLearning.IfElse
{
    internal class NumberChecker
    {
        public static void Run()
        {
        
         Console.WriteLine("enter your number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        if(num % 2 == 0)
        {
            Console.WriteLine("The Number you entered is Even.");
        }

        else
        {
            Console.WriteLine("The number you entered is Odd.");
        }
        }

    }
}