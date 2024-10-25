using System;

namespace TAZASTICH.Utils
{
    public class Converters
    {
        public static void ConvertMilimeters()
        {
            try
            {
                Console.WriteLine("How many millimeters do you want to convert?");

                bool Option = true; // Declare the variable here locally

                do
                {
                    Console.WriteLine("Enter the number of millimeters:");

                    // Parse user input to a double (number of millimeters)
                    if (double.TryParse(Console.ReadLine(), out double milimeters))
                    {
                        // Ask the user which unit they want to convert to
                        Console.WriteLine("Which unit do you need? (meters, centimeters, miles)");
                        string unit = Console.ReadLine().ToLower(); // Capture the unit input

                        // Perform conversions based on the user's choice
                        double meters = milimeters / 1000.0;
                        double centimeters = milimeters / 10.0;
                        double miles = milimeters / 1609344.0;

                        // Display the appropriate result based on the chosen unit
                        if (unit == "meters")
                        {
                            Console.WriteLine($"Meters: {meters}");
                        }
                        else if (unit == "centimeters")
                        {
                            Console.WriteLine($"Centimeters: {centimeters}");
                        }
                        else if (unit == "miles")
                        {
                            Console.WriteLine($"Miles: {miles}");
                        }
                        else
                        {
                            Console.WriteLine("Invalid unit.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number for millimeters.");
                    }

                    // Ask if the user wants to convert again
                    Console.WriteLine("Do you want me to convert again? y/n");
                    Option = Console.ReadLine().ToLower() == "y"; // Check if user input is 'y'

                } while (Option); // End of the do-while loop
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }
    }
}
