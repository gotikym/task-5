using System;
    internal class Program
    {
        static void Main(string[] args)
        {
        var firstName = "Malkovskii";
        var secondName = "Ivan";
        Console.WriteLine(firstName + " " + secondName);
        var switchName = secondName;
        secondName = firstName;
        firstName = switchName;
        Console.WriteLine(firstName + " " + secondName);
        }
    }