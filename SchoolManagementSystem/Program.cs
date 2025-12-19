public class Program1
{
    public static void Main(string[] args)
    {
        Student s1 = new Student(23, "Bhanu", "India");
        Student s2 = new Student(24, "Rahul", "USA");

        Console.WriteLine(s1.name);
        Console.WriteLine(s2.name);
    }
}

