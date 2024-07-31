class CSharp
{
    public string Text = "C#";

    public void PrintText()
    {
        System.Console.WriteLine(Text);
    }
}

class Programming
{
    public string Text = "programming";

    public void PrintText()
    {
        System.Console.WriteLine(Text);
    }
}

class MainClass
{
    public static void Main(string[] args)
    {
        CSharp cObject = new CSharp();
        Programming pObject = new Programming();

        Object.PrintText(); 
        pObject.PrintText();  

       
        System.Console.WriteLine("{0} {1}",Object.Text,pObject.Text);  //  "C# programming"
    }
}
