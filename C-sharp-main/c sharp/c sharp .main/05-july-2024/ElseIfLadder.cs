class ElseIfLadder
{
    public static void Main(string[] args)
    {
        int[] rollNumber = { 111, 222, 333, 444 }; 
        int[] marks = { 81, 75, 43, 58 };

        for (int i = 0; i < rollNumber.Length; i++)
        {
            if (marks[i] > 79) 
                System.Console.WriteLine(rollNumber[i] + " Honours");

            else if (marks [i] > 59) 
                System.Console.WriteLine(rollNumber[i] + " I Division");

                else if (marks [i] > 49) 
                    System.Console.WriteLine(rollNumber[i] + " II Division");

                    else 
                        System.Console.WriteLine(rollNumber[i] +" FAIL");
        }
    }
}

/*

D:\Vishalpal\CSHARP>ElseIfLadder.exe
111 Honours
222 I Division
333 FAIL
444 II Division

*/