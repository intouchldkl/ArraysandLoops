using System;

namespace ArraysandLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] duplicates = Question8();
            for(int i = 0;i < duplicates.Length;i++)
            {
                Console.WriteLine(duplicates[i]);
            }
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
        static bool Question7(string SearchName)
        {
            string[] name = new string[] { "Intouch", "David", "Toy", "Prem" };


            for (int i = 0; i < name.Length; i++)
            {
                if (name[i] == SearchName)
                {
                    return true;
                }
            }
            return false;
        }

        static string[] Question8()
        {
            int temp = 0;
             int count = 0;
            string[] places = new string[] { "Bangkok", "London", "Paris","London", "Berlin", "New York" ,"Bangkok"};

            for (int i = 0; i < places.Length; i++)
            {
                string test = places[i];
                
                for (int z = i+1; z < places.Length; z++)
                {
                   
                        if (test == places[z] )
                        {

                            count = count + 1;
                        }
                    

                }
            }
            string[] duplicates = new string[count];
            for (int i = 0; i < places.Length; i++)
            {
                string test1 = places[i];
                
                for (int z = i+1; z < places.Length; z++ )
                {

                   
                        if (test1 == places[z] )
                        {
                            duplicates[i] = test1;
                        }
                    
                    
                }
                
            }
            
            return duplicates;
        }
    }

}
