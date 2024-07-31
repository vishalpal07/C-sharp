class ForTest
{
    public static void Main(string[] args)
    {
        long p;
        int n;
        double q;
        System.Console.WriteLine("2 to power -n    n     2 to power n");
        p = 1L;
        for (n = 0; n < 10; ++n)
        {
            if(n == 0)
                p = 1L;
            else
                p = p * 2;
            q = 1.0 / (double)p;

            System.Console.WriteLine("{0:F6}  {1:D}  {2:D}  ",q,n,p);
        }
    }
}

/*

D:\Vishalpal\CSHARP>ForTest.exe
2 to power -n    n     2 to power n
1.000000  0  1
0.500000  1  2
0.250000  2  4
0.125000  3  8
0.062500  4  16
0.031250  5  32
0.015625  6  64
0.007813  7  128
0.003906  8  256
0.001953  9  512

*/
