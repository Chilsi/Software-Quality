using System;

class Program
{
    static void Main(string[] args)
    {

        Rectangle rect1 = new Rectangle();
        Console.Clear();
        Console.WriteLine("Choose an option:");
        Console.WriteLine("1. Get Rectangle Length");
        Console.WriteLine("2. Change Rectangle Length");
        Console.WriteLine("3. Get Rectangle Width");
        Console.WriteLine("4. Change Rectangle Width");
        Console.WriteLine("5. Get Rectangle Perimeter");
        Console.WriteLine("6. Get Rectangle Area");
        Console.WriteLine("7. Exit");
        Console.Write("\r\nSelect an option: ");
        switch (Console.ReadLine())
        {
            case "1":
                Console.WriteLine("Width = " + rect1.Length.ToString());
                break;
            case "2":
                Console.WriteLine("Enter new length:");
                Console.ReadLine();
                break;
            case "3":
                Console.WriteLine("Length = " + rect1.Width.ToString());
                break;
            case "4":
                Console.WriteLine("Enter new width:");
                Console.ReadLine();
                break;
            case "5":
                Console.WriteLine("Perimeter = "+ rect1.Perimeter);
                break;
            case "6":
                Console.WriteLine("Area = "+ rect1.Area);
                break;
            case "7":
                Console.WriteLine("Exit");
                break;
            default:
                Console.WriteLine("Invalid option");
                break;
                
        }
    }
}
