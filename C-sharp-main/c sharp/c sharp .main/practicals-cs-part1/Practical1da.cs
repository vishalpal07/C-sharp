using System;

class Fibonacci
{
    public void FiboSeries()
    {
        int num1 = 0, num2 = 1, num3, num, i; 
        
        Console.WriteLine("Enter Limit : ");
        num = int.Parse(Console.ReadLine());

        // Print the first two numbers (0 and 1) separately
        if (num >= 1)
            Console.Write(num1);

        if (num >= 2)
            Console.Write("\t" + num2);

        // Start calculating and printing from the 3rd number onwards
        for (i = 3; i <= num; i++)
        {
            num3 = num1 + num2;
            Console.Write("\t" + num3);
            num1 = num2;
            num2 = num3;
        }

        //Console.WriteLine(); // To move to the next line after printing the sequence
    }
}

class Practical1da
{
    public static void Main(string[] args)
    {
        Fibonacci obj = new Fibonacci();
        obj.FiboSeries();
    }
}
