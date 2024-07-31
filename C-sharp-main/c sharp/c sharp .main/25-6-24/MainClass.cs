
public class CSharp
{
    string private Text;

    public CSharp()
    {
        Text = "C#";
    }

    public void PrintText()
    {
        System.Console.WriteLine(Text);
    }
}

public class Programming
{
    string private Text;
    public Programming()
    {
       Text = "programming";
    }

    public void PrintText()
    {
        System.Console.WriteLine(Text);
    }
}

public class MainClass
{
    public static void Main(string[] args)
    {
        CSharp Object = new CSharp();
        Programming pObject = new Programming();

        Object.PrintText();        
        pObject.PrintText();   

        string result = Object.Text + " " + pObject.Text;
        System.Console.WriteLine(result);  // "C# programming"
    }
}
