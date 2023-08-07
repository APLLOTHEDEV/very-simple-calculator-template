using System;


namespace VerySimpleCalculatorTemplate
{
    //this is the main class of the app
    class Program
    {
        static void Main(string[] args)
        {
          //these are the variable that holds the 2 numbers you input (whole numbers)
          int1;
          int2;
          
        
          //this is the console title which you can change to whatever you want
          Console.Title = "very simple calculator template";

          //random text 
          Console.WriteLine("welcome to the very simple calculator template");


          // this waits for you to enter a number
          Console.Write("enter the first number: ");
          //converts the string to an integer
          int1 = Convert.ToInt32(Console.ReadLine());

          // this waits for you to enter a second number
          Console.Write("enter the second number: ");
          //converts the string to an integer
          int2 = Convert.ToInt32(Console.ReadLine());





          //waits for you to enter a random key so the console does not shut down
          Console.Readkey();


        }
        
    }
}