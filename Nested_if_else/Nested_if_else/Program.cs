using System;

namespace Nested_if_else
{
    class Program
    {
        static void Main(string[] args)
        {
            /*lets add a for loop to check if the user input is a num*/

            //Informs user to enter age
            Console.WriteLine("Please enter your age");
            
            //Takes user input, then converts it to type int
            int age = Convert.ToInt32(Console.ReadLine()) ;


            //checks if num input is equal to or greater than 13, ruling out "Child"
            if (age >= 13)
            {
                //checks if num input is greater than or equal to 18, meaning "Adult"
                if(age>=18)
                {
                    Console.WriteLine("Adult");
                }
                // num input is not greater than 18, thus it must be "Teenager"
                else
                {
                    Console.WriteLine("Teenager");
                }
            }
            //num input is not greater than or equal to 13, thus it must be "Child"
            else
            {
                Console.WriteLine("Child");
            }
        }
    }
}
