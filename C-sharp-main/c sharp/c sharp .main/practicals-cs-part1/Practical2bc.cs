class Practical2bc
{
    public void Practical2ba(int a, int b)
    {
        int sum = a + b;
        System.Console.WriteLine(sum);
    }

    public Practical2ba(int a, int b, int c)
    {
        int sum = a + b + c;
        System.Console.WriteLine(sum);
    }

    public static void Main(string[] args)
    {
        Practical2ba obj1 = new Practical2ba(1, 2);
        Practical2ba obj2 = new Practical2ba(1, 2, 3);
    }
}
