class Reverse
    {
        public static void Main(string[] args)
        {
            System.Console.Write("Enter the number to reverse: ");
            int num = System.Convert.ToInt32(System.Console.ReadLine());
            int rev = 0;
            while (num > 0)
            {
                rev = rev * 10 + (num % 10);
                num /= 10;
            }
            System.Console.WriteLine("Reversed number is: {0}", rev);
            System.Console.WriteLine();
        }
    }