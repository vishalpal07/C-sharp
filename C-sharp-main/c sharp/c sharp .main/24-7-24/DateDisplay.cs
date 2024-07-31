
class Date
{
    private int day, month, year;
    public Date(int d, int m, int y)
    {
        this.day = d;
        this.month = m;
        this.year = y;
    }
    public void display()
    {
        System.Console.WriteLine("Date: " + day + "/" + month + "/" + year);
    }
}
class DateDisplay
{
    public static void Main(string[] args)
    {
        Date obj = new Date(24, 7, 2024);
        obj.display();
    }
}


/*


D:\Vishalpal\CSHARP>DateDisplay.exe
Date: 24/7/2024


*/