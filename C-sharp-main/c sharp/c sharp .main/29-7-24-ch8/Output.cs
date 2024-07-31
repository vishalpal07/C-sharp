class OutputDemo
{
	public static void Square(int x, out int y)
	{
		y = x * x;
	}
}

class Output
{
	public static void Main(string[] args)
	{
		int m;
		OutputDemo.Square(10, out m);
		System.Console.WriteLine("m = " + m);
	}
}

/*

D:\CSharp\29-7-24-ch8>Output.exe
m = 100


*/