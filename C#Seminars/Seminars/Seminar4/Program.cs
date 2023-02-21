// int FindSum (int x)
// {
//     int sum = 0;
//     for ( int current = 1; current <= x; current++)
//     {
//         sum = sum + current; // sum += current
//     }
//     return sum;    
// };
// Console.WriteLine("Input X");
// int X = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"{FindSum(X)}");


//Задача 4. Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.

// [1,0,1,1,0,1,0,0]

// int[] CreateRandomArray (int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue + 1); // high limit not included 
//     }
//     return array;
// }

// void Showarray ( int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]}; ");
//     }
//     Console.WriteLine();
// }
// Console.WriteLine("Input array size");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input minimal value of array");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input maximum value of array");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(size, minValue, maxValue);

// Showarray(myArray);

//     Factorial
// int FindMulti (int x)
// {
//     int multi = 1;
//     for ( int current = 1; current <= x; current++)
//     {
//         multi = multi * current; 
//     }
//     return multi;    
// };
// Console.WriteLine("Input X");
// int X = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"{FindMulti(X)}");

//Number of Digit in Number

// int NumberOfDigit (int x)
// {
//     int count = 0;
//     while (x>0) {x /= 10; count ++;}
//     return count;
// }
// Console.WriteLine("Input X");
// int X = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"{NumberOfDigit(X)}");
