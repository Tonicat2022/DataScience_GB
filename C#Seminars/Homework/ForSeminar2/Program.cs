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
// Console.Clear();
// double Degree ( double xDegree, double DegreeLevel)
// {
//     double index = 0;
//     double result = 1;
//     while (index<DegreeLevel)
//     {
//     result = result * xDegree;
//     index ++;
//     };
//     return result;
// };

// Console.WriteLine("Please input Value to Degree");
// double x = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Please input degree level");
// double n = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine(Degree(x, n));

    // Method for find Length Of Number
// int LengthOfNumber (double num)
// {
//     if( num < 0) {num = - num;};
//     int index = 0;
//     while (num % 10 >=1)
//     {
//         num = num /10;
//         index++;
//     }
//     return index;
// }

// Console.WriteLine("Please input any Number to findout length of Number");
// double x = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine(LengthOfNumber(x));
 // Middle of the three-digit number
// int x = 0;
// bool CheckIf3Digit (int num)
// {
//     if (num > 99 && num < 1000)
//     {
//         return true; // yes, num is three-digit
//     }
//         return false;
// };

// void MiddleDigit (int number)
// {
//     if(CheckIf3Digit(x))
//     {
//         Console.Write($"{(number / 10 ) % 10} is the middle digit in {number}");
//     }
//     else
//     {
//         Console.Write($"{number} is not Three-MiddleDigit Number");
//     }
// };
// Console.WriteLine("Please input three-digit number");
// x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine();
// MiddleDigit(x);

    // Check for Polyndrome
int x = 0;
bool CheckIf5Digit (int num)
{
    if (num > 9999 && num < 100000)
    {
        return true; // yes, it is 
    }
        return false;
};

void CheckPolindrom (int num)
{ 
    if (CheckIf5Digit(x))
    {
        char [] xArray = Convert.ToString(num).ToArray();
        // int index = 0; ///for display xArray
        // while (index < 5)
        // {
        //     Console.Write($"{xArray[index]};");
        //     index ++;
        // };
        if (xArray[0] == xArray[4] && xArray[1] == xArray[3])
        {
            Console.Write($"{num} is Polindrome");
        }
        else
        {
            Console.Write($"{num} is NOT Polindrome");
        }
    }
    else
    {
        Console.Write($"{num} is not Five-MiddleDigit Number");
    }
}
Console.WriteLine("Please input five-digit number");
x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
CheckPolindrom(x);