// See https://aka.ms/new-console-template for more information
Console.Write("Enter side 1: ");
string input1 = Console.ReadLine();
Console.Write("Enter side 2: ");
string input2 = Console.ReadLine();
Console.Write("Enter side 3: ");
string input3 = Console.ReadLine();

if (double.TryParse(input1, out double side1) &&
    double.TryParse(input2, out double side2) &&
    double.TryParse(input3, out double side3) &&
    side1 > 0 && side2 > 0 && side3 > 0)
{
    if (side1 == side2 && side2 == side3)
        Console.WriteLine("Equilateral triangle.");
    else if (side1 == side2 || side2 == side3 || side1 == side3)
        Console.WriteLine("Isosceles triangle.");
    else
        Console.WriteLine("Scalene triangle.");
}
else
{
    Console.WriteLine("Invalid input. Please enter positive numbers for all sides.");
}