using System;

namespace ClassMethods
{
    class Program
    { 
        static void Main()
        {
            var playKey = ConsoleKey.Y;

            do
            {
                try
                {

                    Console.Write("Let's do some math. Enter a whole number. I recommend keeping it small:  ");

                    var input = Console.ReadLine();

                    try
                    {
                        if (MathOps.IsDigitsOnly(input) == true)
                        {

                            var number = Convert.ToInt32(input);

                            Console.WriteLine($"2^{number} (exponentiation) is: {MathOps.TwoToPowerOf(number)}.");

                            Console.WriteLine($"{number}! factorial is: {MathOps.Factorial(number)}.");

                            Console.WriteLine($"{number}^{number} exponentiation is: {MathOps.RaiseToPowerOfSelf(number)}.");

                            Console.WriteLine("See, these mathematical operations grow quickly!");

                            Console.WriteLine("Wanna go again? y/n:  ");

                            playKey = Console.ReadKey(true).Key;

                            if (playKey == ConsoleKey.N)
                            {
                                Console.WriteLine("Goodbye!");

                                Environment.Exit(0);
                            }

                        }
                    }

                    catch (ArgumentException argEx)
                    {
                        Console.WriteLine($"{argEx.Message}");
                    }

                }

                catch (OverflowException)
                {
                    Console.WriteLine("Sorry, the number was too big to complete the calculation!");
                }

                catch (FormatException)
                {
                    Console.WriteLine("Sorry, the input was not a whole number.");
                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }

            while (playKey != ConsoleKey.N);
        }
    }
}
