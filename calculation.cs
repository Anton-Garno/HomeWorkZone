
Console.WriteLine("input first number");
double a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("input second number");
double b = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("input one of this scene: +,-,*,/.");
string mat = Console.ReadLine();
switch (mat)
{
    case "+":
        Console.WriteLine($"Result is: {a + b}");
        break;
    case "-":
        Console.WriteLine($"Result is: {a - b}");
        break;
    case "*":
        Console.WriteLine($"Result is: {a * b}");
        break;
    case "/":
        if (b != 0)
            Console.WriteLine($"Result is: {a / b}");
        else
            Console.WriteLine("division by zero!");
        break;
    default:
        Console.WriteLine("invalid operator, try again");
        break;
}
