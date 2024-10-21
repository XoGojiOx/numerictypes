using System;

class Program
{
    static void Main()
    {
        // Prompt user for the length of the rectangle
        Console.WriteLine("Enter the length of the rectangle:");
        string lengthInput = Console.ReadLine();
        double length = Convert.ToDouble(lengthInput);

        // Prompt user for the width of the rectangle
        Console.WriteLine("Enter the width of the rectangle:");
        string widthInput = Console.ReadLine();
        double width = Convert.ToDouble(widthInput);

        // Calculate the area
        double area = length * width;

        // Print the result
        Console.WriteLine("The area of the rectangle is: " + area);
    }
}

