using System;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        // Initialize an empty list to store numbers
        List<int> numbers = new List<int> { };

        // Create a variable with value less than the while loop condition to start the loop
        int choice = -1;

        // Create a variable to store the sum of the numbers
        int sum = 0;


        // Start the loop 
        while (choice != 0)
        {
            Console.Write("Type in a number and type in 0 to quit: ");
            choice = Convert.ToInt32(Console.ReadLine());

            // Add the number to the list if it's not 0
            if (choice != 0)
            {
                numbers.Add(choice);
            }

            // Break the loop if the user types in 0
            else
            {
                break;
            }
        }

        // (Optional) Print an exit message to the user
        Console.WriteLine("Thanks for playing!");

        // Loop through the list and calculate the sum
        foreach (int number in numbers)
        {
            sum += number;
        }

        // Print the sum of the numbers
        Console.WriteLine($"The sum is: {sum}");

        // Calculate the number of elements in the list 
        int count = numbers.Count;

        // Calculate the average of the numbers and typecast using (double) to get result with decimal points
        double average = (double)sum / count;

        // Print the average of the numbers
        Console.WriteLine($"The average is: {average}");

        // Initialize variables to store the first element in the list to be used as a comparison point
        int largestNumber = numbers[0];
        int smallestNumber = numbers[0];

        // Loop through the lis
        foreach (int number in numbers)
        {
            // Check if the current number is larger than the largest number and update if so
            if (number > largestNumber)
            {
                largestNumber = number;
            }

            // Check if the current number is smaller than the smallest number and greater than 0 and update if so
            if (number < smallestNumber && number! > 0)
            {
                smallestNumber = number;
            }
        }

        // Print the largest and smallest numbers
        Console.WriteLine($"The largest number is: {largestNumber}");
        Console.WriteLine($"The smallest positive number is: {smallestNumber}");

        // Sort the list in ascending order and print the sorted list
        numbers.Sort();
        Console.WriteLine("The sorted list is: ");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }


    }
}