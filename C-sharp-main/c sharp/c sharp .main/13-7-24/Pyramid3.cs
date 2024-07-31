
class Pyramid3
{
    public static void Main(string[] args)
    {
        int rows = 5;
        
        for (int i = 1; i <= rows; i++)
        {
            for (int j = 1; j <= rows - i; j++)
            {
                System.Console.WriteLine(" ");
            }

            for (int j = 1; j <= i; j++)
            {
                System.Console.WriteLine(i + " ");
            }

            System.Console.WriteLine();
        }
    }
}
