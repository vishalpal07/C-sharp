class ContinueBreakDemo
{
	public void Display()
	{
		int n = 10;
		while(n < 200)
		{
			if(n < 50)
			{
				System.Console.Write(" " + n);
				n = n + 10;
				continue;
			}
			if(n == 50)
			{
				System.Console.WriteLine();
				n = n + 10;
				continue;
			}
			if(n > 90)
			break;
			System.Console.Write(" "+n);
			n = n + 10;
		}
		System.Console.WriteLine();
	}
}

class ContinueBreak
{
	public static void Main(string[] args)
	{
		ContinueBreakDemo obj = new ContinueBreakDemo();
		obj.Display();
	}
}


/*

D:\CSharp\29-7-24-ch7>ContinueBreak.exe
 10 20 30 40
 60 70 80 90

*/