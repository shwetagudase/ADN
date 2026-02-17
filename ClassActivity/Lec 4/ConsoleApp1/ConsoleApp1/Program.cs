using System;

class Program
{
    // Delegate declaration
    public delegate void NotifyDelegate();

    // Methods that match the delegate signature
    public static void Message1()
    {
        Console.WriteLine("Message 1 received");
    }

    public static void Message2()
    {
        Console.WriteLine("Message 2 received");
    }

    public static void Message3()
    {
        Console.WriteLine("Message 3 received");
    }

    static void Main(string[] args)
    {
        // Creating multicast delegate
        NotifyDelegate del = Message1;
        del += Message2;
        del += Message3;

        // Invoking delegate
        del();
    }
}
