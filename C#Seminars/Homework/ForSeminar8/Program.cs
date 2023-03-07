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

//     // Task 56 finding row with minimum sum of all members, print number of row and sum of members

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

// int SumOfRowInArray (int[,] array, int row)
// {
//     int sumOfRow = 0;
//     for(int j = 0; j < array.GetLength(1); j++)
//     {
//         sumOfRow += array[row,j];
//     }
//     return sumOfRow;
// }

// void MinimumSumOfRowInArray (int[,] array)
// {
//     int minRow = 0;
//     int minimumSumInRow = SumOfRowInArray(array, 0);
//     for(int i = 1; i <array.GetLength(0); i++)
//     {
//         int sum = SumOfRowInArray(array, i);
//         if (sum <minimumSumInRow)
//         {
//             minimumSumInRow = sum;
//             minRow = i;
//         }
//     }
//     Console.WriteLine($"Row with index {minRow} with minimum sum: {minimumSumInRow} of all members");
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

// Console.WriteLine("");
// print2DRandomArray(myArray);
// Console.WriteLine("");
// MinimumSumOfRowInArray(myArray);

    // Task 56 Multiplying of two matix

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

bool CheckIfMayMyltiplyed (int[,] array, int[,] array2)
{
    array.GetLength(1) == array2.GetLength(0);
}

int[,] MultiplyiedArray (int[,] array, int[,] array2)
{
    if (CheckIfMayMyltiplyed(array, array2))
    {
        int[,] result = new int[array.GetLength(0), array2.GetLength(1)];
        for(int i = 0; i < result.GetLength(0); i++)
        {
            for( int j = 0; j < result.GetLength(1); j++)
            {
                result[i,j] = array[i,j] * array2[i,j];
            }}
    }
    else
    return null;
}

Console.WriteLine("Input please number of rows for first matrix");//for first matrix
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input please number of columns for first matrix");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input please number of rows for second matrix");//for second matrix
int rows1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input please number of columns for second matrix");
int columns1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input please min value of member");//for both matrices
int minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input please max value of member");
int maxValue = Convert.ToInt32(Console.ReadLine());


int[,] myArray1 = create2DRandomArray(rows, columns, minValue, maxValue);
int[,] myArray2 = create2DRandomArray(rows2, columns2, minValue, maxValue);

Console.WriteLine("");
print2DRandomArray(myArray);
Console.WriteLine("");
print2DRandomArray(myArray2);
Console.WriteLine("");
MinimumSumOfRowInArray(myArray);

