using System;
class CityGuide
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Select your choice");
        System.Console.WriteLine ("London");
        System.Console.WriteLine("Bombay");
        System.Console.WriteLine("Paris");
        System.Console.WriteLine("Type your choice");
        String name = System.Console.ReadLine();

        switch (name)
        {
            case "Bombay":
                System.Console.WriteLine("Bombay: Guide 5");
                break;
            case "London":
                System.Console.WriteLine("London: Guide 10");
                break;
            case "Paris":
                System.Console.WriteLine("Paris: Guide 15");
                break;
            default:
                System.Console.WriteLine ("Invalid choice");
                break;
        }
    }
}

/*

D:\Vishalpal\CSHARP>CityGuide.exe
Select your choice
London
Bombay
Paris
Type your choice
London
London: Guide 10

*/