    // Task10
Console.Clear();

// void MiddleDigit (int num)
// {
//     if (Check3Digit(num) == Convert.ToInt32(3);
//     Console.WriteLine("{num} is NOT three-digit number");
//     break;
// }

// void numDiv10 (int num)
// {
// int result = num % 10;
// };

Console.WriteLine("Please input three-digit number");
int n = Convert.ToInt32(Console.ReadLine());

int LengthOfDigit (int num)
{
    int index = 0;
        while (num % 10 >=1)
    {
        num = num /10;
        index++;
    }
    return index;
}
int Length = LengthOfDigit(n);

void MiddleDigit (int num)
{
    if (Length != 3)
    {
    Console.WriteLine($"{num} is NOT three-digit number");
    }
    else
    {
    Console.WriteLine($"{num % 100 / 10} is the middle digit");
    };
};

Console.WriteLine(LengthOfDigit(n));
MiddleDigit(n);
