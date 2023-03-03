//     // Task1 

// int[,] create2DRandomArray(int rows, int columns, int minValue, int maxValue)
// {
//     int[,] new2DArray = new int[rows,columns];
//     for(int i = 0; i < rows; i++)
//     {
//         for( int j = 0; j < columns; j++)
//         {
//             new2DArray[i,j] = new Random().Next(minValue, maxValue+1);
//         }
//     }
//     return new2DArray;
// }

// void print2DRandomArray(int[,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for( int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i,j]} ");
//         }
//         Console.WriteLine("");

//     }
// }

// Console.WriteLine("Input please rows quantity of 2way array");
//  int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input please columns quantity of 2way array");
//  int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input please minimum number of 2way array");
//  int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input please maximum number of 2way array");
//  int max = Convert.ToInt32(Console.ReadLine());

//  int[,] arrayFilled = create2DRandomArray(n, m, min, max);
//  print2DRandomArray(arrayFilled);

    // Task2

int[,] create2nmArray(int rows, int columns)
{
    int[,] new2DArray = new int[rows,columns];
    for(int i = 0; i < rows; i++)
    {
        for( int j = 0; j < columns; j++)
        {
            new2DArray[i,j] = i + j;
        }
    }
    return new2DArray;
}

void print2DRandomArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for( int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine("");

    }
}

Console.WriteLine("Input please rows quantity of 2way array");
 int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input please columns quantity of 2way array");
 int m = Convert.ToInt32(Console.ReadLine());

 int[,] arrayFilled = create2nmArray(n, m);
 print2DRandomArray(arrayFilled);