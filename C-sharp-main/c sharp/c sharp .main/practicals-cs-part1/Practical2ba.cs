class Practical2ba
{
 
    public void Add(int a, int b)
    {
        int sum = a + b;
        System.Console.WriteLine(sum);
    }
 
    public void Add(int a, int b, int c)
    {
        int sum = a + b + c;
        System.Console.WriteLine(sum);
    }
 
    public static void Main(string[] args)
    {
 
        Practical2ba obj = new Practical2ba();

	obj.Add(1, 2);
 
        obj.Add(1, 2, 3);
    }
}