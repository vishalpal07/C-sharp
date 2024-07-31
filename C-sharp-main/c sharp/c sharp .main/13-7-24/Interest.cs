class Interest
    {
        public static void Main(string[] args)
        {
            System.Console.Write("Enter the Principal Amount: ");
            double p = System.Convert.ToDouble(System.Console.ReadLine());
            System.Console.Write("Enter the rate of interest: ");
            double r = System.Convert.ToDouble(System.Console.ReadLine());
            System.Console.Write("Enter no of year: ");
            int n = System.Convert.ToInt32(System.Console.ReadLine());

            while (n > 0)
            {
                double v = p * (1 + r);
                p = v;
                n--;
            }
            System.Console.WriteLine("Value of money is: "+ p);
        }
    }
