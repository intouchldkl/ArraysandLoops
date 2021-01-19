using System;

namespace ArraysandLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            
            question1()
        }
        static void question1()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }
        static void question2()
        {
            for(int i = 100;i >= 1; i -=1 )
            {
                Console.WriteLine(i);
            }
        }
        //Print the first and last ints in an array
        static void PrintFirstAndLast(int[] numbers)
        {
            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[numbers.Length-1]);
        }
        static void PrintAllNumbers(int[] numbers)
        {
            
            for(int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
        static void PrintAverage(int[] numbers)
        {
            
            int total = 0;
            double average = 0.0;
            for(int i = 0; i < numbers.Length; i++)
            {
                total = total + numbers[i];

            }
            average = total / numbers.Length;
        }
        static void printHighestAndLowest(int[] numbers )
        {
            
            int highest = numbers[0];
            int lowest = numbers[0];
            for (int i = 0;i < numbers.Length; i++)
            {
                if (numbers[i] > highest)
                {
                    highest = numbers[i];
                }
                else if (numbers[i] > lowest) ;
                {
                    lowest = numbers[i];
                }
            }
            Console.WriteLine(highest);
            Console.WriteLine(lowest);
        }

        static void getRandomNumbers()
        {
            int[] numbers = new int[50];
            Random ro = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                int randomNumber = ro.Next(100);
                numbers[i] = randomNumber;
            }
            int highest = numbers[0];
            int lowest = numbers[0];
        }
    }
}
