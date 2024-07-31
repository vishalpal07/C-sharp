class ForeachTestDemo
{
	public void Display()
	{
		int[] arrayInt = { 11, 22, 33, 44 };
		foreach (int m in arrayInt)
		{
			System.Console.WriteLine(" " + m);
		}
		System.Console.WriteLine();
	}
}

class ForeachTest
{
	public static void Main(string[] args)
	{	
		ForeachTestDemo obj = new ForeachTestDemo();
		obj.Display();
	}
}


/*


D:\CSharp\29-7-24-ch7>ForeachTest.exe

 11
 22
 33
 44

*/