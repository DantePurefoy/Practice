using System;

namespace SoloLearn_ConvertStringToInt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your age.");

            int age =
            Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("You are {0} years old", age);
        }
    }
}
// I suppose that this is handy for when recieving user data and converting it to a number that can be used. 
// I wonder if there is a sort of "Console.ReadNum" that could skip this,
// Though I imagine theres the potential for an error coming up if the user were to enter a letter.