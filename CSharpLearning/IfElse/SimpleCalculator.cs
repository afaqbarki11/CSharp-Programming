using System;

namespace CSharpLearning.IfElse
{
    internal class SimpleCalculator
    {
        public static void Run()
        {
            
        Console.WriteLine("Enter your First Number: ");   
        float num1 = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Enter your second Number: ");
        float num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the operator(+,-,*,/)");
        string? op = Console.ReadLine();

        if (op == "+"){
            Console.WriteLine($"Addition is: {num1 + num2}");
            }

         else if (op == "-"){
                Console.WriteLine($"Subtraction is: {num1 - num2}");
            }

        else if(op == "*"){
                Console.WriteLine($"Multiplication is: {num1 * num2}");
            }

        else if(op == "/"){
                if(num2 != 0){
                Console.WriteLine($"Divsion is: {num1 / num2}");
                }

                else{
                Console.WriteLine("Error! Cannot Divide by zero.");
                }
            }

        else{
                Console.WriteLine("invalid Operator!");
                }
        }
    }
}