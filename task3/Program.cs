using System;

class ParameterDemo
{
    // increases the number by 10
    public void Increase(ref int number)
    {
        number = number + 10;
    }

    // assigns full name to out parameter
    public void GetFullName(out string fullname)
    {
        fullname = "Mishan Katuwal";
    }

    // returns sum of all numbers
    public int SumAll(params int[] numbers)
    {
        int sum = 0;
        foreach (int n in numbers)
        {
            sum = sum + n;
        }
        return sum;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // object
        ParameterDemo p = new ParameterDemo();

        // calling Increase
        int num = 5;
        p.Increase(ref num);
        Console.WriteLine(num);

        // calling GetFullName
        string full;
        p.GetFullName(out full);
        Console.WriteLine(full);

        // calling SumAll
        int total = p.SumAll(1, 2, 3, 4);
        Console.WriteLine(total);
    }
}
