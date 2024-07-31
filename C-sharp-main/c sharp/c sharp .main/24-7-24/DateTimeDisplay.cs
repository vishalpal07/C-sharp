
class DateTime
{
    private int minutes, hours;
    public DateTime(int hrs, int min)
    {
        hours = hrs;
        minutes = min;
    }
    public DateTime(int min)
    {
        hours = min / 60;
        minutes = min % 60;
    }
    public void display()
    {
        System.Console.WriteLine("Time: " + hours + ":" + minutes);
    }
}
class DateTimeDisplay
{
    public static void Main(string[] args)
    {
        int num = System.Convert.ToInt32(System.Console.ReadLine());
        DateTime t1 = new DateTime(num);
        t1.display();
        DateTime t2 = new DateTime(12, 35);
        t2.display();
    }
}



/*


D:\Vishalpal\CSHARP>DateTimeDisplay.exe
128
Time: 2:8
Time: 12:35



*/