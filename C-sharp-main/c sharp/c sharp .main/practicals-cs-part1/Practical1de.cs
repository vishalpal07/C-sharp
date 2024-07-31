class Reverse
{
	public void RevNumber()
	{
		int num,org,rev=0,rem,sum=0; 
		System.Console.WriteLine("Enter a number : ");
 		num = int.Parse(System.Console.ReadLine()); 
 		org = num; 
 		while (num > 0) 
 		{ 
 			rem = num % 10; 
 			rev = rev * 10 + rem; 
 			sum=sum+rem; 
 			num = num / 10; 
 		} 
 		System.Console.WriteLine(rev); 
 		System.Console.WriteLine("Sum:" + sum); 

	}
} 
 class Practical1de
 { 
 	public static void Main(string[] args) 
 	{ 		
		Reverse obj = new Reverse();
		obj.RevNumber();
	} 
 }