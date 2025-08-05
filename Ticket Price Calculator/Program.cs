// See https://aka.ms/new-console-template for more information
Console.Write("Enter your age: ");
string input = Console.ReadLine();

if (int.TryParse(input, out int age) && age > 0)
{
    int price = (age <= 12 || age >= 65) ? 7 : 10;
    Console.WriteLine($"Your ticket price is GHC{price}.");
}
else
{
    Console.WriteLine("Invalid input. Please enter a valid age.");
}