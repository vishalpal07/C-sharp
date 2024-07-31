
using System;

class Program2
{
    static void Main()
    {
        int rows = 5; // Number of rows in the pyramid
        
        for (int i = 1; i <= rows; i++)
        {
            // Print leading spaces
            for (int j = 1; j <= rows - i; j++)
            {
                Console.Write(" ");
            }

            // Print numbers for the current row
            for (int j = 1; j <= i; j++)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine(); // Move to the next line after each row
        }
    }
}
