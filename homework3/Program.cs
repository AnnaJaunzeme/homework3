using System;

namespace homework3
{
    class Program
    {
        static void Main(string[] args)
        {
                                  
            Console.WriteLine("Enter your number here: ");
              
            
            decimal number = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("The absolute value of your number is " + Math.Abs(number) + "!");
            Console.ReadLine();

           

        }
    }
}
