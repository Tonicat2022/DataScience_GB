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