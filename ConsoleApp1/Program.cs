using System;

interface IPrintable
{
    void Print();
}

interface ISerializable
{
    void Save();
}

class Report : IPrintable, ISerializable
{
    public void Print()
    {
        Console.WriteLine("Report Printed");
    }

    public void Save()
    {
        Console.WriteLine("Report Saved");
    }
}

class Program
{
    static void Main()
    {
        Report r = new Report();
        r.Print();
        r.Save();
    }
}
