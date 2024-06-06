using System;

while (true)
{
    Console.Write("Enter value: ");
    string userInput = Console.ReadLine();
    int num = Convert.ToInt32(userInput);
    

    if (num <= 1)
    {
        Console.WriteLine($"{num} this number is neither complex nor prime");
    }
    else
    {
        bool prime = true;

        for (int i = 2; i <= num / 2; i++)
        {
            if (num % i == 0)
            {
                prime = false;
                break;
            }
        }

        if (prime)
        {
            Console.WriteLine($"{num} this number is prime!!!");

            int count = 0;
            int numTwo = num + 1;

            while (count < 3)
            {
                bool isPrime = true;

                for (int i = 2; i <= numTwo / 2; i++)
                {
                    if (numTwo % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {
                    Console.WriteLine($"next prime number: {numTwo}");
                    count++;
                }

                numTwo++;
            }
        }
        else
        {
            Console.WriteLine("This number is not prime.");
        }

        Console.WriteLine("Do you want to use the program again? y/n");
        string answer = Console.ReadLine();
        if (answer.ToLower() != "y")
        {
            break;
        }
    }
}