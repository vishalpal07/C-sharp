class Multiply
{
	public void FourNumbers()
	{
		int num1, num2,num3,num4,prod; 
 		System.Console.Write("Enter number 1: "); 
 		num1 = System.Convert.ToInt32(System.Console.ReadLine()); 
 		System.Console.Write("Enter number 2: "); 
 		num2 = System.Convert.ToInt32(System.Console.ReadLine()); 
 		System.Console.Write("Enter number 3: "); 
 		num3 = System.Convert.ToInt32(System.Console.ReadLine()); 
 		System.Console.Write("Enter number 4: "); 
 		num4 = System.Convert.ToInt32(System.Console.ReadLine()); 
 		prod = num1 * num2 * num3 * num4; 
 		System.Console.WriteLine("Product is " + prod);

	}
}
class Practical1aconsole { 
 	public static void Main(string[] args) 
	{ 
 		 Multiply obj = new Multiply();
		 obj.FourNumbers();
 	} 
 }