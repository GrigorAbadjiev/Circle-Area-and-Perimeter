// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// read
double r = Double.Parse(Console.ReadLine());
// calculate
Double area = Math.PI * r * r;
Double perimeter = 2 * Math.PI * r;

// print
Console.WriteLine($"{perimeter:f2}");
Console.WriteLine($"{area:f2}");

