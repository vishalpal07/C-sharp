class Dollar
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Convertion formula used is: 74.17\n");
            double value = 83.51;

            System.Console.WriteLine("Enter US dollar: ");
            for (int i=1; i<=5; i++)
            {
                double dollar = System.Convert.ToDouble(System.Console.ReadLine());
                System.Console.WriteLine("value of {0} Dollar in Rupees is: {1}", dollar, dollar * value);

            }
            System.Console.WriteLine("\n");
        }
    }