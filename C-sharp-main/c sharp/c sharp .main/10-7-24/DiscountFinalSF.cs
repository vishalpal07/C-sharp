class DiscountFinalSF
{
    static void Main(string[] args)
    {
        System.Console.Write("Total amount spent on Mill Cloths: ");
        double mill = System.Convert.ToDouble(System.Console.ReadLine());
        System.Console.Write("Total amount spent on Handloom Cloths: "); 
        double handloom = System.Convert.ToDouble(System.Console.ReadLine());
        double millDiscount = 0, handloomDiscount = 0;
        DiscountFinalSF prog = new DiscountFinalSF();

        switch ((int)(mill / 100))
        {
            case 0:
                millDiscount = 0;
                break;
            case 1:
                millDiscount = 5;
                break;
            case 2:
                millDiscount = 7.5;
                break;
            default:
                millDiscount = 10;
                break;
        }

        switch ((int)(handloom / 100))
        {
            case 0:
                handloomDiscount = 5;
                break;
            case 1:
                handloomDiscount = 7.5;
                break;
            case 2:
                handloomDiscount = 10;
                break;
            default:
                handloomDiscount = 15;
                break;
        }

        double amount = System.Convert.ToDouble(
            prog.calculate(mill, millDiscount) +
            prog.calculate(handloom, handloomDiscount));

        System.Console.WriteLine();
        System.Console.WriteLine("Total Cost: {0}", mill + handloom);
        System.Console.WriteLine("Mill discount: {0}%, Handloom discount: {1}%",
            millDiscount, handloomDiscount);
        System.Console.WriteLine("Total Payable amount: {0}", amount);
        System.Console.WriteLine();
    }

    public double calculate(double total_amount, double discount)
    {
        return (total_amount - (discount / 100) * total_amount);
    }
}
