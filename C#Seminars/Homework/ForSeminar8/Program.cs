//     // Task 54 Sorting in rows by descending

// int[,] create2DRandomArray(int rows, int columns, int minValue, int maxValue)
// {
//     int[,] new2DArray = new int[rows,columns];
//     for(int i = 0; i < rows; i++)
//     {
//         for( int j = 0; j < columns; j++)
//         {
//             new2DArray[i,j] =  new Random().Next(minValue, maxValue);
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

// void SelectionSort (int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for ( int j = 0; j < array.GetLength(1)-1; j++)
//         {
//             int MinPostition = j;
//             for ( int z = j +1; z < array.GetLength(1); z++)  
//             {
//                 if (array[i, z] > array[i, MinPostition]) MinPostition = z;
//             }
//             int temp = array[i,j];
//             array[i, j] = array[i, MinPostition];
//             array[i, MinPostition] = temp;
//         }
//     }
// }


// Console.WriteLine("Input please number of rows");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input please number of columns");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input please min value of member");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input please max value of member");
// int maxValue = Convert.ToInt32(Console.ReadLine());


// int[,] myArray = create2DRandomArray(rows, columns, minValue, maxValue);
// print2DRandomArray(myArray);
// SelectionSort(myArray);
// Console.WriteLine("");
// print2DRandomArray(myArray);

    // Task 56 finding row with minimum sum of all members, print number of row and sum of members

int[,] create2DRandomArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] new2DArray = new int[rows,columns];
    for(int i = 0; i < rows; i++)
    {
        for( int j = 0; j < columns; j++)
        {
            new2DArray[i,j] =  new Random().Next(minValue, maxValue);
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

int SumOfRowInArray (int[,] array, int row)
{
    int sumOfRow = 0;
    for(int j = 0; j < array.GetLength(1); j++)
    {
        sumOfRow += array[row,j];
    }
    return sumOfRow;
}

void MinimumSumOfRowInArray (int[,] array)
{
    int minRow = 0;
    int minimumSumInRow = SumOfRowInArray(array, 0);
    for(int i = 1; i <array.GetLength(0); i++)
    {
        int sum = SumOfRowInArray(array, i);
        if (sum <minimumSumInRow)
        {
            minimumSumInRow = sum;
            minRow = i;
        }
    }
    Console.WriteLine($"Row with index {minRow} with minimum sum: {minimumSumInRow} of all members");
}

Console.WriteLine("Input please number of rows");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input please number of columns");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input please min value of member");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input please max value of member");
int maxValue = Convert.ToInt32(Console.ReadLine());


int[,] myArray = create2DRandomArray(rows, columns, minValue, maxValue);

Console.WriteLine("");
print2DRandomArray(myArray);
Console.WriteLine("");
MinimumSumOfRowInArray(myArray);

