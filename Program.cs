using System;
    internal class Program
    {
        static void Main(string[] args)
        {
        string firstName = "Malkovskii";
        string secondName = "Ivan";
        Console.WriteLine(firstName + " " + secondName);
        string switchName = secondName;
        secondName = firstName;
        firstName = switchName;
        Console.WriteLine(firstName + " " + secondName);
        }
    }
