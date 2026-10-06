 using System;
namespace CSharpLearning.Basics
{
    internal class TypeCasting
    {         
    public static void Run()
          {     
            
            
            
            //Type Casting 
            //Implicit Type Casting
            int myint = 9;
            double mydouble = myint;
            Console.WriteLine(mydouble);
            Console.WriteLine(myint);
            
            //Explicit type Casting
            double myDouble = 9.34;
            int myInt = (int) myDouble;
            Console.WriteLine(myInt);
            Console.WriteLine(myDouble);

            int first_Number = 20;
            double Second_Number = 40;
            bool mybool = true;
            Console.WriteLine(Convert.ToString(mybool));
            Console.WriteLine(Convert.ToString(first_Number));
            Console.WriteLine(Convert.ToInt32(Second_Number));
    }
}

}
