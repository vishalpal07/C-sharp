class Vowel
{
	public void VowelTest()
	{
		char ch; 
		System.Console.WriteLine("Enter a character : ");
 		ch = char.Parse(System.Console.ReadLine());
		if(ch=='a'||ch=='e'||ch=='i'||ch=='o'||ch=='u'||ch=='A'||ch=='E'||ch=='I'||ch=='O'||ch=='U')
			System.Console.WriteLine("It is Vowel");
		else
			System.Console.WriteLine("It is not Vowel");
	}
}
class Practical1dc
 { 
 	public static void Main(string[] args) 
 	{ 
 		Vowel obj = new Vowel();
		obj.VowelTest();
 		  
 	} 
 }