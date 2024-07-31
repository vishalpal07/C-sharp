class ContinueBreak
{
    public static void Main(string[] args)
    {
        int n = 10;
        while(n < 200)
        {
            if(n < 50)
            {
                System.Console.Write(" "+n);
                n = n + 10;
                continue;

            }
            if(n == 50)
            {
                System.Console.WriteLine();
                n = n + 10;
                continue;

            }
            if(n > 90)
                break;
                System.Console.Write(" "+n);
                n = n + 10;
        }
        System.Console.WriteLine();
    }
}

/*

    D:\Vishalpal\CSHARP>ContinueBreak.exe
    10 20 30 40
    60 70 80 90

*/