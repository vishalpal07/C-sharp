class Practical1
{
	public static void Main(string[] args)
	{
		int num1, num2, num3, num4, product;
		num1 = System.Convert.ToInt32(args[0]);
		num2 = System.Convert.ToInt32(args[1]);
		num3 = System.Convert.ToInt32(args[2]);
		num4 = System.Convert.ToInt32(args[3]);
		product = (num1 * num2 * num3 * num4);

		System.Console.WriteLine("Product of four integers =" + product);

	}
}
