class OverloadingDemo
{
	
	public static int volume(int x)
	{
		return (x*x*x);
	}
	public static double volume(float r, int h)
	{
		return (3.14519*r*r*h);
	}
	public static long volume(long l, int b, int h)
	{
		return (l*b*h);
	}
}

class Overloading
{
	public static void Main(string[] args)
	{
		
		System.Console.WriteLine(OverloadingDemo.volume(10));
		System.Console.WriteLine(OverloadingDemo.volume(2.5F, 8));
		System.Console.WriteLine(OverloadingDemo.volume(100L,75,15));
	}
}


/*



D:\Vishalpal\29-7-24-ch8>Overloading.exe
1000
157.2595
112500



*/