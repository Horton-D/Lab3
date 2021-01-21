using System;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            string tryAgain;

                Console.WriteLine("Welcome to number Analyzer! Whats your name?");

                var userName = Console.ReadLine();

                do { 

                Console.WriteLine("{0}, enter a number between 1 and 100.", userName);

                var userInput = int.Parse(Console.ReadLine());

                if(userInput <= 0)
                {
                    Console.WriteLine("Please enter a positive number");
                    
                }

                else if (userInput % 2 == 0 && userInput < 25)
                {
                    Console.WriteLine("{0} Is even and less than 25", userInput);
                }
                else if(userInput % 2 == 0 && userInput >= 60)
                {
                    Console.WriteLine("{0} Even",userInput);
                }
                else if(userInput % 2 == 0 && userInput > 26 )
                {
                    Console.WriteLine("Even");
                }
                else if(userInput % 2 == 0 && userInput >= 60)
                {
                    Console.WriteLine("Even");
                }
                else { 
                    Console.WriteLine("{0} Is odd", userInput);
                }
                Console.WriteLine("Continue? [Y]es or [N]o");
                tryAgain = Console.ReadLine().ToUpper();

                if(tryAgain == "N")
                {
                    Console.WriteLine("BYE!");
                }

            } while (tryAgain == "Y") ;

            }
        }
    }


