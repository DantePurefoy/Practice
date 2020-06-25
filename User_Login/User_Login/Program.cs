using System;

namespace User_Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = "DDDDDante";
            string password = "123abc";

            string usInput;
            string psInput;

            Console.WriteLine("Please Enter your Username");
            usInput = Console.ReadLine();

            for (int login = 0; login <= 2; )
            {
                if (usInput == username)
                {
                    Console.WriteLine("Welcome {0} Please enter your password.", usInput);
                    psInput = Console.ReadLine();
                    

                    for (int attempts = 0; attempts <=2 ;)
                    {
                        if (psInput == password)
                        {
                            Console.WriteLine("Access Granted");
                            break;

                        }
                        if (psInput != password)
                        {
                            attempts++;
                            Console.WriteLine("Password Attempt failed, {0} tries. Please Try again.", attempts);
                            psInput = Console.ReadLine();
                        }
                        if (psInput != password && attempts == 2)
                        {
                            attempts++;
                            Console.WriteLine("Too Many Password Attempts, {0} tries. Closing Console.", attempts);
                            

                        }
                    }
                }
                if(usInput == username)
                {
                    break;
                }
                if (usInput != username)
                {
                    login++;
                    Console.WriteLine("Username Incorrect, {0} tries. Please try again.", login);
                    usInput = Console.ReadLine();
                }
                if (usInput != username && login == 2)
                {
                    login++;
                    Console.WriteLine("Too Many Login Attempts, {0} tries. Closing Console.", login);
                    
                }
                
            }
        }
    }
}
