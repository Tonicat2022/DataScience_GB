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

// // task 66 - Summ from N to M 

// int SumFromNToM (int a, int b)
// {
//     if(a < b)
//     {
//         return SumFromNToM(a+1, b) + a;
//     }
//     else return a;
// }

// Console.WriteLine("Enter low of numbers to sum: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter up of numbers to sum: ");
// int b = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(SumFromNToM(a, b));

// task 68 - Summ from N to M 

int Akkerman (int m, int n)
{
    if(m == 0)
    {
        return n+1;
    }
    if (m > 0 && n == 0)
    {
        return Akkerman (m-1, 1);
    }
    if (m > 0 && n > 0)
    {
        return Akkerman (m-1, Akkerman(m, n-1));
    }
    else return 0;
}

Console.WriteLine("Enter M of numbers to sum: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter N of numbers to sum: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Akkerman(m, n));