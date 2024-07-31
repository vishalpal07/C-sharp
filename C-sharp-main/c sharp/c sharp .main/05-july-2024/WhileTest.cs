class WhileTest
{
    public static void Main(string[] args)
    {
        int n = 1 ;
        while (n <= 10)
        {
            if ( n % 2 ==0)
            {
                n ++ ;
            }
            else
            {
                System.Console.Write(" "+n);
                n++;
            }
        }
    }
}

/*

    D:\Vishalpal\CSHARP>WhileTest.exe
    1 3 5 7 9

*/
