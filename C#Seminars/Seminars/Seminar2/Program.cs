// Task 1
// Console.Clear;
// void Max (int num)
// {
//     int ed = num % 10;
//     int dec = num /10;
//     if(ed>dec)
//     {
//         Console.WriteLine($" Biggest digit of {num} is {ed}");    
//     }
//     else
//     {
//         Console.WriteLine($" Biggest digit of {num} is {dec}");    
//     }
// }

// int Random_number = new Random().Next(10,100);
// Max(Random_number);

// Task 2
// Console.Clear();
// int DeleteDecimal (int num)
// {
//     int sot = num / 100;
//     int ed = num % 10;
//     return sot * 10 + ed;
// };

// int Random_number = new Random().Next(100,1000);
// Console.WriteLine(Random_number);
// Console.WriteLine(DeleteDecimal(Random_number));

// Task 4
Console.Clear();
void Divided_7and23 (int num)
{
    if (num % 7 == 0 && num % 23 == 0)
    {
        Console.WriteLine($"Yes, {num} divided by 7 and 23 without any rest");
    }
    else
    {
        int TheRest7 = num % 7; int TheRest23 = num % 3;
        Console.WriteLine($"No, {num} the rest of 7 is {TheRest7} and the rest of 23 is {TheRest23}");
    };

};

Console.WriteLine("Please input number");
int num = Convert.ToInt32(Console.ReadLine());

Divided_7and23(num);

// Task 3
// Console.Clear();
// int ifDividedWithZero (int num, int num2)
// {
//     if (num % num2 == 0)
//     {
//         return  
//     };
// };

// Console.WriteLine("Please inter first number");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Please inter second number");
// int b = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"First number is {a}; Second  number is {b}");
// Console.WriteLine(DeleteDecimal(Random_number));



