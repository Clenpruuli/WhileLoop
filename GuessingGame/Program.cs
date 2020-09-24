using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int randomNumber = rnd.Next(1, 11);
            Console.WriteLine("What is my number?");
            int UserGuess = Int32.Parse(Console.ReadLine());
            bool correctGuess = false;

            while(!correctGuess)
            {
                if(randomNumber == UserGuess)
                {
                    Console.WriteLine("You won!");
                    correctGuess = true;
                } else
                {
                    if (randomNumber > UserGuess)
                    { 

                        Console.WriteLine("My number is bigger.");
                        Console.WriteLine("What is my number?");
                        UserGuess = Int32.Parse(Console.ReadLine());
                    }
                    else
                    {
                        Console.WriteLine("My number is smaller.");
                        Console.WriteLine("What is my number?");
                        UserGuess = Int32.Parse(Console.ReadLine());
                    }


                }
            }
        }
    }
}
