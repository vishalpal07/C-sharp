class Celsius
{
    public void TempConvert()  
    {
        System.Console.WriteLine("Enter Temperature in Fahrenheit : ");
        int Fahrenheit = System.Convert.ToInt32(System.Console.ReadLine());
        double c = (Fahrenheit - 32) / 1.8;
        System.Console.WriteLine(c+" Celsius");
    }
}
class Practical2ad
{
    public static void Main(string[] args)
    {
        Celsius obj = new Celsius();
        obj.TempConvert();
    }
}