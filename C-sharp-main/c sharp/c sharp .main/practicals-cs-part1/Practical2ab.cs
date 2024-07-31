class Paise
{
    public void MoneyConvert()
    {
            double rupees;
            System.Console.WriteLine("Enter Money in rupees : ")
            rupees = System.Convert.ToDouble(System.Console.ReadLine());

                        int paise = (int)(rupees * 100);

                        System.Console.WriteLine(paise+" paise");
    }
}
class Practical2ab
{
	public static void Main(string[] args)
        {
            Paise obj = new Paise();
            obj.MoneyConvert();
        }
}