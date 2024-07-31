class DoWhileTest
{
    public static void Main(string[] args)
    {
        int row, column, y;
        row = 1;
        System.Console.WriteLine("Multiplication Table \n");
        do
        {
            column = 1;
            do
            {
                y = row * column; 
                System.Console.Write(" "+y);
                column = column + 1;
            }
            while (column <= 3);

            System.Console.WriteLine("\n"); 
            row = row + 1;
        }
        while (row <= 3);
    }
        
}

/*

D:\Vishalpal\CSHARP>DoWhileTest.exe
Multiplication Table

 1 2 3

 2 4 6

 3 6 9


*/