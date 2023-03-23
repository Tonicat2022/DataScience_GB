// // to print numbers from N to 1
// void ShowNumbers (int n)
// {
//     if (n > 0)
//     {
//         Console.Write(n + " ");
//         ShowNumbers (n - 1);
//     }
// }
// Console.WriteLine("Enter up of numbers to be printed: ");
// int n = Convert.ToInt32(Console.ReadLine());
// ShowNumbers (n);

// // to print numbers from 1 to N.
// void ShowNumbers (int n)
// {
//     if (n > 0)
//     {
//         ShowNumbers (n - 1);
//         Console.Write(n + " ");
//     }
// }
// Console.WriteLine("Enter up of numbers to be printed: ");
// int n = Convert.ToInt32(Console.ReadLine());
// ShowNumbers (n);

// // to find sum of all digit in number
// int FindSumDigit (int n)
// {
//     if(n > 0)
//     {
//         return FindSumDigit (n/10) + n% 10;
//     }
//     else return n;
// }
// Console.WriteLine(FindSumDigit(456));


// // to print all numbers between N and M

// void ToPrintNumbersBetweenNM (int m, int n)
// {
//     if(m != n)
//     {
//         if(m<=n)
//         {
//             ToPrintNumbersBetweenNM(m, n-1);
//             Console.Write(n + " ");
//         }
//         else
//         {
//             ToPrintNumbersBetweenNM(m-1, n);
//             Console.Write(m + " ");
//         }
//     }
//     else Console.Write(n + " ");
// }

// Console.WriteLine("Enter low of numbers to be printed: ");
// int n = Conver;t.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter up of numbers to be printed: ");
// int m = Convert.ToInt32(Console.ReadLine());

// ToPrintNumbersBetweenNM(n, m);

// to Power A to B level 

int ToPowerNumber (int a, int b)
{
    if(b > 0)
    {
        return ToPowerNumber(a, b-1) * a;
    }
    else return 1;
}

Console.WriteLine("Enter number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter Power of number: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(ToPowerNumber(a, b));
