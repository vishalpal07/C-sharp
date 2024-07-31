class GotoLabel
{
    public static void Main(string[] args)
    {

        for (int i = 1; i < 100; i++)
        {
            System.Console.WriteLine(" ");
            if (i >= 10)
                break;
            for (int j = 1; j < 100; j++)
            {
                System.Console.Write(" * ");
                if (j == i)
                    goto loop1;
            }
            loopl:continue;
        }
        System.Console.WriteLine("Termination by BREAK");
    }
}

/*

GotoLabel.cs(15,21): error CS0159: No such label 'loop1' within the scope of the goto statement
GotoLabel.cs(17,13): warning CS0164: This label has not been referenced

*/