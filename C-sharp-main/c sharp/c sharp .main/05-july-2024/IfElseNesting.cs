class IfElseNesting
{
    public static void Main(string[] args)
    { 
        int a = 325 , b = 712 , c = 478;

        System.Console.Write("Largest value is: ");
        
        if (a > b)
        {
            if (a > c)
            {
                System.Console.WriteLine(a);
            }
            else
            { 
                System.Console.WriteLine(c);
            }
        }
        else
        {
            if (c > b)
            {
                System.Console.WriteLine(c); 
            }
            else
            {
                System.Console.WriteLine(b);
            }
        }
    }
}

/*

D:\Vishalpal\CSHARP>IfElseNesting.exe
Largest value is: 712

*/