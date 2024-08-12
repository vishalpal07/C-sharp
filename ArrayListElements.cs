
using System.Collections;

class ListElements
{
    ArrayList data = new ArrayList();
    public void Display()
    {
        System.Console.WriteLine("Array List Operations:");
        System.Console.WriteLine("1: Add");
        System.Console.WriteLine("2: Add at Index");
        System.Console.WriteLine("3: Reverse");
        System.Console.WriteLine("4: Sort");
        System.Console.WriteLine("5: Count");
        System.Console.WriteLine("6: Remove");
        System.Console.WriteLine("7: Remove at Index");
        System.Console.WriteLine("8: Display List");
        
        
        int number = System.Convert.ToInt32(System.Console.ReadLine());
        
        switch(number)
        {
            case 1: 
                System.Console.WriteLine("Enter the item to add:");
                string add = System.Console.ReadLine();
                data.Add(add);
                break;
                
            case 2:
                System.Console.WriteLine("Enter index :");
                int index = System.Convert.ToInt32(System.Console.ReadLine());
                System.Console.WriteLine("Enter item :");
                string atIndex = System.Console.ReadLine();
                data.Insert(index, atIndex);
                break;
                
            case 3:
                data.Reverse();
                System.Console.WriteLine("Reversed ");
                break;
                
            case 4:
                data.Sort();
                System.Console.WriteLine("Sorted ");
                break;
                
            case 5:
                System.Console.WriteLine("List count: "+data.Count);
                break;
                
            case 6:
                System.Console.WriteLine("Enter to remove:");
                string remove = System.Console.ReadLine();
                if (data.Contains(remove))
                {
                    data.Remove(remove);
                    System.Console.WriteLine("Removed.");
                }
                else
                {
                    System.Console.WriteLine("Not found.");
                }
                break;
                
            case 7:
                System.Console.WriteLine("Enter index : ");
                int remIndex = System.Convert.ToInt32(System.Console.ReadLine());
                if (remIndex >= 0 && remIndex < data.Count)
                {
                    data.RemoveAt(remIndex);
                    System.Console.WriteLine("Item removed");
                }
                else
                {
                    System.Console.WriteLine("Not Found");
                }
                break;
                
            case 8:
                System.Console.WriteLine("ArrayList:");
                foreach(string element in data)
                {
                    System.Console.WriteLine(element);
                }
                break;
                
            default:
                System.Console.WriteLine("Invalid");
                break;
        }
     
        Display();
    }
}

class ArrayListElements
{
    public static void Main(string[] args)
    {
        ListElements obj = new ListElements();
        obj.Display();
    }
}

