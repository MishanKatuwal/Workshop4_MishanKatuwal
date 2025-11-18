class Calculator
{
    // prints welcome message
    public void PrintWelcome()
    {
        Console.WriteLine("Welcome to the Calculator");
    }

    // returns addition
    public int Add(int num1, int num2)
    {
        return num1 + num2;
    }

    // optional parameter for num2, default 1
    public int Multiply(int num1, int num2 = 1)
    {
        return num1 * num2;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // creating object
        Calculator c = new Calculator();

        // calling methods
        c.PrintWelcome();
        int sum = c.Add(5, 3);
        int mul = c.Multiply(4);

        // printing results
        Console.WriteLine(sum);
        Console.WriteLine(mul);
    }
}
