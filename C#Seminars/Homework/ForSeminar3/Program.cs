    // Check for Polyndrome
// int x = 0;
// bool CheckIf5Digit (int num)
// {
//     if (num > 9999 && num < 100000)
//     {
//         return true; // yes, it is 
//     }
//         return false;
// };

// void CheckPolindrom (int num)
// { 
//     if (CheckIf5Digit(x))
//     {
//         char [] xArray = Convert.ToString(num).ToArray();
//         // int index = 0; ///for display xArray
//         // while (index < 5)
//         // {
//         //     Console.Write($"{xArray[index]};");
//         //     index ++;
//         // };
//         if (xArray[0] == xArray[4] && xArray[1] == xArray[3])
//         {
//             Console.Write($"{num} is Polindrome");
//         }
//         else
//         {
//             Console.Write($"{num} is NOT Polindrome");
//         }
//     }
//     else
//     {
//         Console.Write($"{num} is not Five-MiddleDigit Number");
//     }
// }
// Console.WriteLine("Please input five-digit number");
// x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine();
// CheckPolindrom(x);

// Distance between two points in 3-way space
int x1, x2, y1, y2, z1, z2;
Console.WriteLine("Please input X coordinate of First point]");
x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please input Y coordinate of First point]");
y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please input Z coordinate of First point]");
z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please input X coordinate of Second point]");
x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please input Y coordinate of Second point]");
y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please input Z coordinate of Second point]");
z2 = Convert.ToInt32(Console.ReadLine());

void Distance (int x1, int x2, int y1, int y2, int z1, int z2)
{
    Console.WriteLine($"1-st point is {x1};{y1};{z1}");
    Console.WriteLine($"1-st point is {x2};{y2};{z2}");
    double result = Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2)+Math.Pow(z2-z1,2));
    Console.WriteLine($"Distance is {Convert.ToInt16(result)}");
};
Distance(x1, x2, y1, y2, z1, z2);