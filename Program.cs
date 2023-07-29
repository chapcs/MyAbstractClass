abstract class MyAbstractClass { }

class Program
{
    MyAbstractClass myInstance = new MyAbstractClass();//intentional error to show it cannot be instantiated
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}

