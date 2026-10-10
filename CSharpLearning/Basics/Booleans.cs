 using System;
namespace CSharpLearning.Basics
{
    internal class Booleans
    {         
    public static void Run()
        {
            
    bool iscsharpfun = true;
    bool isfishtasty = false;
    Console.WriteLine(iscsharpfun); //output True
    Console.WriteLine(isfishtasty); //Output false

    int x = 9;
    int y = 13;
    Console.WriteLine(x>y);
    Console.WriteLine(x<y);

    // Real Life Example

    int myage = 23;
    int votingage = 18;
     if(myage >= 18)
            {
                Console.WriteLine("Old enough to Vote!");
            }
            else
            {
                Console.WriteLine("not eligible for Vote!")
            }


}

}
}
