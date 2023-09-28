using System;
using System.Diagnostics;

public delegate void SampleDelegate(int a, int b);
class MathOperations
{
    public void Add(int a, int b)
    {
        Console.WriteLine("Add Result: {0}", a + b);
    }
    public void Subtract(int x, int y)
    {
        Console.WriteLine("Subtract Result: {0}", x - y);
    }
    public void Multiply(int x, int y)
    {
        Console.WriteLine("Multiply Result: {0}", x * y);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("****Delegate Calculator****");
        MathOperations m = new MathOperations();
        SampleDelegate dlgt = m.Add;
        dlgt += m.Subtract;
        dlgt += m.Multiply;
        Console.Write("Enter the first number: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        int num2 = int.Parse(Console.ReadLine());
        dlgt(num1, num2);
        Console.ReadLine();
    }
}
