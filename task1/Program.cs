class Student
{
    public string name;
    public int age;
    public string address;

    public static string collegeName = "Ithari International College";
}

class Program
{
    static void Main(string[] args)
    {
        //objects
        Student s1 = new Student();
        Student s2 = new Student();

        // assign values
        s1.name = "Mishan";
        s1.age = 20;
        s1.address = "Morang";

        s2.name = "Nigam";
        s2.age = 21;
        s2.address = "Dharan";

        // student information
        Console.WriteLine("Student 1:");
        Console.WriteLine(s1.name);
        Console.WriteLine(s1.age);
        Console.WriteLine(s1.address);

        Console.WriteLine("\nStudent 2:");
        Console.WriteLine(s2.name);
        Console.WriteLine(s2.age);
        Console.WriteLine(s2.address);

        // print college name
        Console.WriteLine("\nCollege Name: " + Student.collegeName);
    }
}
