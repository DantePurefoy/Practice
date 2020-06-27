using System;

namespace _0to100to0to0
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;

            while (i < 100)
            {
                Console.WriteLine("{0} w", i);
                i++;
            }

            while (i >= 0)
            {
                
                Console.WriteLine("{0} w", i);
                i--;

            }

            for(i=1; i <= 100; i++)
            {
                Console.WriteLine("{0} f", i);
                
            }

            for (i = 99; i >= 0; i--)
            {
                Console.WriteLine("{0} f", i);

            }

        }
    }
}
