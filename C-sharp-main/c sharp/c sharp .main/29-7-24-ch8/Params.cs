class ParamsDemo
{
	public static void Parray(params int[] arr)
	{
		System.Console.Write("Array elements are : ");
		foreach (int i in arr)
			System.Console.Write(" " + i);
		System.Console.WriteLine();
	}
}

class Params
{
	public static void Main(string[] args)
	{
		int[] x = { 11, 22, 33 };
		ParamsDemo.Parray(x);
		ParamsDemo.Parray();
		ParamsDemo.Parray(100, 200);
	}
}


/*

D:\Vishalpal\29-7-24-ch8>Params.exe
Array elements are :  11 22 33
Array elements are :
Array elements are :  100 200


*/