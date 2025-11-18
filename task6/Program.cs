class Program
{
    static void Main(string[] args)
    {
        int marks;
        int total;

        Console.Write("Enter marks: ");
        int.TryParse(Console.ReadLine(), out marks);

        Console.Write("Enter total: ");
        int.TryParse(Console.ReadLine(), out total);

      //i checked the values here during debugging.

        double percentage = ((double)marks / total) * 100;

        // Debugging showed the problem here.
        // marks and total are integers, so marks / total does INTEGER DIVISION.
        // This removes the decimal part. 
        // Because of this, the percentage becomes wrong 

        Console.WriteLine("Percentage: " + percentage);
    }
}