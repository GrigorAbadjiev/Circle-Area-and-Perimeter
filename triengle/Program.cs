// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
{
    // read input 
    // a
    // h

    double side = double.Parse(Console.ReadLine());
    double hieght = double.Parse(Console.ReadLine());

    // calculate
    // a * h / 2
    double area = side * hieght / 2;
    // print output
    // f2
    Console.WriteLine($"{area:f2}");
}