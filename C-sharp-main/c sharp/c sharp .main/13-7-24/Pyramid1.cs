class Pyramid1
{
    public static void Main(string[] args)
    {
        int rows = 5;        
        for (int i = rows; i >= 1; i--)
        {
            for (int j = 1; j <= i; j++)
            {
                System.Console.Write("$"); 
            
            }
            System.Console.WriteLine();
        }
    }
}