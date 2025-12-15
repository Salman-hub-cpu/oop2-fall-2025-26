using System;

interface IStudent
{
    void Display();
}

class Student : IStudent
{
    private int[] marks = new int[3];
    public string Name { get; set; }

    
    public int this[int index]
    {
        get { return marks[index]; }
        set { marks[index] = value; }
    }

    public Student(string name)
    {
        Name = name;
    }

    public void Display()
    {
        Console.WriteLine("Student Name: " + Name);
        for (int i = 0; i < marks.Length; i++)
        {
            Console.WriteLine("Subject " + (i + 1) + " Marks: " + marks[i]);
        }
    }
}

class Program
{
    static void Main()
    {
        Student s = new Student("Azmir");
        s[0] = 80;
        s[1] = 85;
        s[2] = 90;
        s.Display();
    }
}
