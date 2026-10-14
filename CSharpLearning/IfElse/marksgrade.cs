using System;
namespace CSharpLearning.IfElse
{
    internal class marksgrade
    {
        public static void Run()
        {

            Console.WriteLine("Enter your Numbers:");
            int num = Convert.ToInt32(Console.ReadLine());

            if(num < 50)
            {
                Console.WriteLine("Fail");
            }
            
            else if(num < 60)
            {
                Console.WriteLine("Grade D");
            }

            else if (num < 70)
            {
                Console.WriteLine("Grade C");
            }

            else if(num < 80)
            {
                Console.WriteLine("Grade B");
            }

            else
            {
                Console.WriteLine("Grade A");
            }
        }
    }
        }