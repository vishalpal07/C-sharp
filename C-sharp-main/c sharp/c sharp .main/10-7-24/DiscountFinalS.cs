    class DiscountFinalS
    {
        static void Main(string[] args)
        {
            System.Console.Write("Total amount spent on Mill Cloths: ");
            double mill = System.Convert.ToDouble(System.Console.ReadLine());
            System.Console.Write("Total amount spent on Handloom Cloths: "); 
	    double handloom = System.Convert.ToDouble(System.Console.ReadLine());
            double millDiscount = 0, handloomDiscount = 0;
            DiscountFinalS prog = new DiscountFinalS();
            if (mill >= 0 && mill <= 100)
            {
                millDiscount = 0;
            }
            else if (mill > 100 && mill <= 200)
            {
                millDiscount = 5;
            }
            else if (mill > 200 && mill <= 300)
            {
                millDiscount = 7.5;
            }
            else
            {
                millDiscount = 10;
            }
            if (handloom >= 0 && handloom <= 100)
            {
                handloomDiscount = 5;
            }
            else if (handloom > 100 && handloom <= 200)
            {
                handloomDiscount = 7.5;
            }
            else if (handloom > 200 && handloom <= 300)
            {
                handloomDiscount = 10;
            }
            else
            {
                handloomDiscount = 15;
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
