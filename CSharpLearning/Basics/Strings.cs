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

           //Concatenation
           string first_name = "Afaq";
           string last_name = " Ahmad";
           string full_name = first_name + last_name;
           Console.WriteLine("My name is: " + full_name);

            //Using Concat 
           string firstname = "Kashif";
           string lastname = " Iqbal";
           string fullname = string.Concat(firstname , lastname);
           Console.WriteLine("My Friend name is: " + fullname);

           //Interpolation
           string fname = "Kashif";
           string lname = " Iqbal";
           string fulname = $"My friend name is: {fname}{lname}";
           Console.WriteLine(fulname);
           
           // Access Strings
           string mystring = "hello";
           Console.WriteLine(mystring[0]);

          // Using (indexof) to find index of char
          string txt1 = "hello";
          Console.WriteLine(txt1.IndexOf('e'));
          
          //Substring
          string name = "Ahmad";
          int charpos = name.IndexOf("d");
          string endname = name.Substring(charpos);
          Console.WriteLine(endname);

          //Special Character
          string txt3 = "We are the so-called \"Vikings\" from the north.";
          Console.WriteLine(txt3);

          string txt4 = "It\'s alright.";
          Console.WriteLine(txt4);

          string txt5 = "The character \\ is called backslash.";
          Console.WriteLine(txt5);

          Console.WriteLine(" I Belongs to the city of \n flowers!");
          Console.WriteLine(" Its my Csharp learning\tJourney");
          Console.WriteLine(" Its my Csharp learning \bJourney");
          }
    }
}