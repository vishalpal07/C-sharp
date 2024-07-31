class Factorial
{
    public void FindFactorial()
    {
        int fact=1,num;
        System.Console.WriteLine("Enter a number : ");
            num = System.Convert.ToInt32(System.Console.ReadLine());
	
            for (int i = 2; i <= num; i++)
            {
                fact *= i;
            }
            System.Console.WriteLine(fact);
    }
}
class Practical2aa
{
    public static void Main(string[] args)
    {
        Factorial obj = new Factorial();
        obj.FindFactorial();
    }
}
            