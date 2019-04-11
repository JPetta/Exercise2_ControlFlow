using System;

namespace Exercise2_ConditionalFlow
{
    class Program
    {

        //exercise 1

        //static void Main(string[] args)
        //{
        //    for (var i = 0; i <= 100; i++){
        //        if( i % 3 == 0)
        //        Console.WriteLine(i);
        //    }
        //}

        //exercise 2

        //static void Main(string[] args)
        //{
        //    int number = 0;

        //    while (true) { 
        //    Console.Write("\nInput Number? (y/n) ");

        //    var answer = Console.ReadLine();
        //    if (answer == "y")
        //    {
        //            Console.Write("\nEnter number : ");
        //            var numberEntered = Console.ReadLine();
        //            if (!String.IsNullOrWhiteSpace(numberEntered))
        //            {
        //                int intNumberEntered = Convert.ToInt32(numberEntered);
        //                number = number + intNumberEntered;
        //                continue;
        //            }
        //            continue;
        //        }

        //        else
        //        {
        //            Console.WriteLine(number);
        //        }

        //    }
        //}

        //exercise 3

        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Factorial : ");
        //    var number = Convert.ToInt32(Console.ReadLine());
        //    var factorial = 1;
        //    for (var i = 1; i <= number; i++)
        //    {
        //        factorial *= i;
        //    }

        //    Console.WriteLine("{0}! = {1}",number, factorial);
        //}

        //exercise 4

        //static void Main(string[] args)
        //{
        //    var random = new Random().Next(1, 10);

        //    Console.WriteLine("Guess the number!");

        //    for (var i= 0; i <= 4; i++)
        //    {
        //        var answer = Convert.ToInt32(Console.ReadLine());

        //        if (answer == random)
        //        {
        //            Console.WriteLine("\nYou Won!");
        //            return;
        //        }

        //        else
        //            Console.WriteLine("Try again!");

        //    }

        //    Console.WriteLine("You Lost!");
        //}

        //exercise 5

        static void Main(string[] args)
        {
            Console.Write("Enter commoa separated numbers: ");
            var input = Console.ReadLine();

            var numbers = input.Split(',');

            // Assume the first number is the max 
            var max = Convert.ToInt32(numbers[0]);

            foreach (var str in numbers)
            {
                var number = Convert.ToInt32(str);
                if (number > max)
                    max = number;
            }

            Console.WriteLine("Max is " + max);
        }
    }
}