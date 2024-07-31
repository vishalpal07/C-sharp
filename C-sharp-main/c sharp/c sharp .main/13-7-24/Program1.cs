using System;

class Program1
{
    static void Main()
    {
        int rows = 5; // Number of rows in the pyramid
        
        // Outer loop for rows
        for (int i = 1; i <= rows; i++)
        {
            // Inner loop for spaces
            for (int j = 1; j <= rows - i; j++)
            {
                Console.Write(" "); // Print spaces
            }
            
            // Inner loop for stars
            for (int k = 1; k <= 2 * i - 1; k++)
            {
                Console.Write(i); // Print stars (or any character)
            }
            
            Console.WriteLine(); // Move to the next line after completing the row
        }
    }
}
