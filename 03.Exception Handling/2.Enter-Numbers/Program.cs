using System;
using System.Text;

namespace _2.Enter_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNumber = 1;
            int endNumber = 100;
            int[] numbers = new int[10];
            int count = 0;
            int greatingByValue = count;
            while(count < 10)
            {               
                try
                {
                    int number = ReadNumber(startNumber, endNumber);
                    if (number < 1 || number > 100)
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                    if(number<=greatingByValue)
                    {
                        throw new IndexOutOfRangeException();
                    }
                    numbers[count++] = number;
                    greatingByValue = number;
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("The number must be greater than by last entered: " + greatingByValue);
                }   
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("The number must be greater than zero and less or equal than 100!");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid number!");
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine("Invalid number!");
                }
            }
            Console.WriteLine("You have successfuly entered ten integers!");
        }

        public static int ReadNumber(int start, int end)
        {
            Console.WriteLine("Please enter a number a range 1 to 100!");
            string input = Console.ReadLine();
            int number = int.Parse(input);
            return number;
        }
    }
}
