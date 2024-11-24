using System;
class ColorConverter
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Color Converter (8-Bit per channel)");
            Console.WriteLine("1. Convert Integer to RGB");
            Console.Write("Choose the option 1 to make sure: ");

            int choice = int.Parse(Console.ReadLine() ?? "1");
            if (choice == 1)
            {
                // integer to rgb
                Console.Write("Enter an integer (0-16777215): ");
                int colorInt = int.Parse(Console.ReadLine() ?? "0");

                (int red, int green, int blue) = IntegerToRGB(colorInt);
                Console.WriteLine($"Integer {colorInt} -> RGB: ({blue}, {green}, {red})"); // flipped cuz of GameMaker, example how it was before: (160, 104, 216)
                                                                                           // now its (216, 104, 160)
                Console.WriteLine(" ");
            }
            else
                Console.WriteLine("Invalid choice xvro.");
                Console.WriteLine(" ");
        }
    }

    // convert a single integer to rgb components
    static (int red, int green, int blue) IntegerToRGB(int colorInt)
    {
        int red = (colorInt >> 16) & 0xFF;
        int green = (colorInt >> 8) & 0xFF;
        int blue = colorInt & 0xFF;
        return (red, green, blue);
    }
}