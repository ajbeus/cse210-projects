using System;
using System.Security.Cryptography.X509Certificates;

public class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        journal.Run();
    }
}