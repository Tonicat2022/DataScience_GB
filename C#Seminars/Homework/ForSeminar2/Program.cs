    // Task10
// Console.Clear();

// Console.WriteLine("Please input three-digit number");
// int n = Convert.ToInt32(Console.ReadLine());

// int LengthOfDigit (int num)
// {
//     int index = 0;
//         while (num % 10 >=1)
//     {
//         num = num /10;
//         index++;
//     }
//     return index;
// }
// int Length = LengthOfDigit(n);

// void MiddleDigit (int num)
// {
//     if (Length != 3)
//     {
//     Console.WriteLine($"{num} is NOT three-digit number");
//     }
//     else
//     {
//     Console.WriteLine($"{num % 100 / 10} is the middle digit");
//     };
// };

// Console.WriteLine(LengthOfDigit(n));
// MiddleDigit(n);

    // Task13
// Console.Clear();

// Console.WriteLine("Please input any number");
// int n = Convert.ToInt32(Console.ReadLine());

// int LengthOfDigit (int num)
// {
//     int index = 0;
//         while (num % 10 >=1)
//     {
//         num = num /10;
//         index++;
//     }
//     return index;
// }
// int Length = LengthOfDigit(n);

// void ThirdNumberFormRight (int num)
// {
//     if (Length < 3)
//     {
//         Console.WriteLine($"There is NOT third digit in {num}");
//     }
//     else
//     {
//         Console.WriteLine($"{num % 1000 / 100} is third digit from right");
//     };
// };
// Console.WriteLine($"{n} is {LengthOfDigit(n)} digit number");
// ThirdNumberFormRight(n);

 // Task15
// Console.Clear();

// void IfWeekend ( int num)
// {
//     if (num <8 && num >0) // checking for appropriate number
//     {
//         if( num == 6 || num == 7)
//         {
//             Console.WriteLine($"Great!!! it is WEEKEND");
//         }
//         else
//         {
//             Console.WriteLine($"Unfortunatelly it is working day ((((");
//         }
//     }
//     else
//     {
//         Console.WriteLine($"{num} is not a appropriate number");
//     }
// }

// Console.WriteLine("Please input number day of the week");
// int n = Convert.ToInt32(Console.ReadLine());
// IfWeekend(n);
    // Test 1 Degree of the Value
Console.Clear();
double Degree ( double xDegree, double DegreeLevel)
{
    double index = 0;
    double result = 1;
    while (index<DegreeLevel)
    {
    result = result * xDegree;
    index ++;
    };
    return result;
};

Console.WriteLine("Please input Value to Degree");
double x = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Please input degree level");
double n = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(Degree(x, n));