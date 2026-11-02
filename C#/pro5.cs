using System;
class Student
{
    public int RollNo { get; set; }
    public string Name { get; set; }
    public Student(int r, string n)
    {
        RollNo = r;
        Name = n;
    }
    public void Display()
    {
        Console.WriteLine("Roll No: " + RollNo + ", Name: " + Name);
    }
}
class Program
{
    static void Main()
    {
        Student s1 = new Student(101, "Rahul");
        Student s2 = new Student(102, "Sneha");
        s1.Display();
        s2.Display();
    }
}
    

using System;
class Student
{
    public int RollNo { get; set; }
    public string Name { get; set; }
    public Student(int r, string n)
    {
        RollNo = r;
        Name = n;
    }
    public void Display()
    {
        Console.WriteLine("Roll No: " + RollNo + ", Name: " + Name);
    }
}
class Program
{using System;
class Student
{
    public int RollNo { get; set; }
    public string Name { get; set; }
    public Student(int r, string n)
    {
        RollNo = r;
        Name = n;
    }
    public void Display()
    {
        Console.WriteLine("Roll No: " + RollNo + ", Name: " + Name);
    }
}
class Program
{
    static void Main()
    {
        Student s1 = new Student(101, "Rahul");
        Student s2 = new Student(102, "Sneha");
        s1.Display();
        s2.Display();
    }
}



static void Main()
    {
        Student s1 = new Student(101, "Rahul");
        Student s2 = new Student(102, "Sneha");
        s1.Display();
        s2.Display();
    }
}
    

using System;
class Animal
{
    public virtual void Speak()
    {
        Console.WriteLine("Animal makes a sound");
    }
}
class Dog : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Dog barks");
    }
}
class Program
{
    static void Main()
    {
        Animal a1 = new Animal();
        Animal a2 = new Dog();
        a1.Speak();
        a2.Speak();
    }
}


         
            
            
    
