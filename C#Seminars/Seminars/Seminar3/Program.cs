//     // Input x,y coordinate, output number of quater
// Console.WriteLine("Hello, World!");

// int quater (double x, double y)
// {
//     if( x > 0 && y > 0) return 1;
//     if( x < 0 && y > 0) return 2;
//     if( x < 0 && y < 0) return 3;
//     if( x > 0 && y < 0) return 4;
//     return 0;
// };
// Console.WriteLine("Input x");
// double x = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("Input y");
// double y = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine($"quater number {quater(x,y)}");

    // Distance between two points in 2-way space
double x1, x2, y1, y2;
Console.WriteLine("Please input X coordinate of First point]");
x1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Please input Y coordinate of First point]");
y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Please input Z coordinate of First point]");
x2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Please input X coordinate of Second point]");
y2 = Convert.ToDouble(Console.ReadLine());

void Distance (double x1, double x2, double y1, double y2)
{
    Console.WriteLine($"1-st point is {x1};{y1}");
    Console.WriteLine($"1-st point is {x2};{y2}");
    double result = Math.Round(Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2)),3);
    Console.WriteLine($"Distance is {result}");
};
Distance(x1, x2, y1, y2);