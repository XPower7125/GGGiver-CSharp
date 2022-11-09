using System.Runtime.InteropServices;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("wanna get a GG?");
        string gg = Console.ReadLine();
        if (gg == "yes") { Console.WriteLine("gg"); }
        else if (gg == "y") { Console.WriteLine("gg"); }
        else { Console.WriteLine("lol you are not getting your GG, restart the program and try again :)"); }
    }
}