
//   //  A in power B
// double Power ( int first, int second)
// {
//     double result = first;
//     for (int i = 1; i < second; i++)
//     {
//         result *= first;
//     }
//     return result;
// }


// Console.WriteLine("Input first number - A");
// int A = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input second number - B");
// int B = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"{A} in power {B} = {Power(A,B)}");


double X =0;
int NumberOfDigit (double x)
{
    int power =0;
    while (x>0) {x /= 10; power ++;}
    return power;
}

int SumOfDigit (double y)
{
    int sum = 0;
    int nValue = 0;
    int power = NumberOfDigit(X);
    while ( power >= 0)
    {
        nValue = Convert.ToInt32(y / Math.Pow(10,power));
        sum = sum + nValue;
        // Console.Write($"{nValue};");
        y = y % Math.Pow(10,power);
        power = power -1;
    }
    return sum;
}

// 1234 / 1000 = 1; 1234 % 1000 = 234;
// 234 /100 = 2; 234 % 100 = 34;
// 34 / 10 = 3; 34 % 10 = 4;


Console.WriteLine("Input X");
X = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"{SumOfDigit(X)}");

