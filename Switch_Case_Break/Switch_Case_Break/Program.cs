using System;

namespace Switch_Case_Break
{
    class Program
    {
        static void Main(string[] args)
        {
            int num; /*value we want to match*/;

            Console.WriteLine("Please enter a number between 1-10");
            num = Convert.ToInt32(Console.ReadLine());

            switch (num)
            {
                case 1 /*potential value*/:
                    Console.WriteLine("You have entered, {0}", num);
                    break;

                case 2 /*potential value*/:
                    Console.WriteLine("You have entered, {0}", num);
                    break;

                case 3 /*potential value*/:
                    Console.WriteLine("You have entered, {0}", num);
                    break;

                case 4 /*potential value*/:
                    Console.WriteLine("You have entered, {0}", num);
                    break;

                case 5 /*potential value*/:
                    Console.WriteLine("You have entered, {0}", num);
                    break;

                case 6 /*potential value*/:
                    Console.WriteLine("You have entered, {0}", num);
                    break;

                case 7 /*potential value*/:
                    Console.WriteLine("You have entered, {0}", num);
                    break;

                case 8 /*potential value*/:
                    Console.WriteLine("You have entered, {0}", num);
                    break;

                case 9 /*potential value*/:
                    Console.WriteLine("You have entered, {0}", num);
                    break;

                case 10 /*potential value*/:
                    Console.WriteLine("You have entered, {0}", num);
                    break;

                default /*potential value*/:
                    Console.WriteLine("You have entered an invalid number");
                    break;
            }
        }
    }
}
