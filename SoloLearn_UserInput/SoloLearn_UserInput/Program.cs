using System;

namespace SoloLearn_UserInput
{
    class Program
    {
        static void Main(string[] args)
        {
            string yourName;
            Console.WriteLine("what is your name?");

            yourName = Console.ReadLine();

            Console.WriteLine("Hello {0}", yourName);
        }
    }
}
