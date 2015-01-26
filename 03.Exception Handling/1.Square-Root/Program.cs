using System;

namespace _1.Square_Root
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter an integer!");           
            try
            {
                int number = int.Parse(Console.ReadLine());
                if(number <= 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                double squareRootNumber = Math.Sqrt(number);
                Console.WriteLine(Math.Round(squareRootNumber, 2));
            }
            catch(ArgumentOutOfRangeException)
            {
                Console.WriteLine("The number must be greater than zero!");
            }
            catch(FormatException)
            {
                Console.WriteLine("Invalid number!");
            }
            catch(ArgumentNullException)
            {
                Console.WriteLine("Invalid number!");
            }
            finally
            {
                Console.WriteLine("Good bye");
            }
        }
    }
}
