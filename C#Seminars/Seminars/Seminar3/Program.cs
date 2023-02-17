    // Input x,y coordinate, output number of quater
Console.WriteLine("Hello, World!");

int quater (double x, double y)
{
    if( x > 0 && y > 0) return 1;
    if( x < 0 && y > 0) return 2;
    if( x < 0 && y < 0) return 3;
    if( x > 0 && y < 0) return 4;
    return 0;
};
Console.WriteLine("Input x");
double x = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Input y");
double y = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"quater number {quater(x,y)}");
