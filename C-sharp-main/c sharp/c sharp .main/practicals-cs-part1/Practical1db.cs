class Prime
{
	public void PrimeNumbers()
	{
		int num, i; 
		System.Console.WriteLine("Enter a number :");
 		num = int.Parse(System.Console.ReadLine()); 
 		for (i = 2; i <= num / 2; i++) 
 		{ 
 			if ((num % i) == 0) 
 			break; 
 		} 
 		if (num == 1) 
 		System.Console.WriteLine("It is neither prime nor composite"); 
 		else if(i<(num/2)) 
 		System.Console.WriteLine("It is not prime number"); 
 		else
 		System.Console.WriteLine("It is prime number");
	}
}
class Practical1db
 { 
 	public static void Main(string[] args) 
 	{ 
		Prime obj = new Prime();
		obj.PrimeNumbers();
 		 
 	} 
 }