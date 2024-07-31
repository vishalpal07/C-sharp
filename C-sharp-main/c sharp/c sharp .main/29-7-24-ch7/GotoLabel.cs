class GotoLabelDemo
{
	public void Display()
	{
		for(int i = 1; i < 100; i++)
		{
			System.Console.WriteLine(" ");
			if(i >= 10)
				break;
			for(int j = 1; j < 100; j++)
			{
				System.Console.Write(" * ");
				if(j == i)
					goto loop1;
			}
			loop1:continue;
		}
		System.Console.WriteLine("Termination by BREAK");
	}
}

class GotoLabel
{
	public static void Main(string[] args)
	{
		GotoLabelDemo obj = new GotoLabelDemo();
		obj.Display();
	}
}


/*

D:\CSharp\29-7-24-ch7>GotoLabel.exe

 *
 *  *
 *  *  *
 *  *  *  *
 *  *  *  *  *
 *  *  *  *  *  *
 *  *  *  *  *  *  *
 *  *  *  *  *  *  *  *
 *  *  *  *  *  *  *  *  *
Termination by BREAK


*/