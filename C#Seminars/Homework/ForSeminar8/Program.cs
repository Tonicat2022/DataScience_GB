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

int[] MembersOfRow (int[,] array, int row)
{
    int[] membersOfRow = new int[array.GetLength(1)];
    for(int j = 0; j < array.GetLength(1); j++)
    {
        membersOfRow[j] = array[row,j];
    }
    return membersOfRow;
}

int[] MembersOfColumn (int[,] array, int column)
{
    int[] membersOfColumn = new int[array.GetLength(0)];
    for(int i = 0; i < array.GetLength(0); i++)
    {
        membersOfColumn[i] = array[i,column];
    }
    return membersOfColumn;
}

int SumOfMultiplyingArray (int[] array, int[] array2)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(0);i++)
    {
        sum += array[i]*array2[i];
    }
    return sum;
}

void PrintMembers(int[] array)
{
    Console.Write($"Members : ");
    for( int i = 0; i < array.Length-1; i++)
    {
        Console.Write($"{array[i]}; ");
    }
    Console.Write($"{array[array.Length-1]}.");
    Console.WriteLine("");
}


bool CheckIfMayMyltiplyed (int[,] array, int[,] array2)
{
    return (array.GetLength(1) == array2.GetLength(0));
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
                result[i,j] = SumOfMultiplyingArray(MembersOfRow(array, i), MembersOfColumn(array2,j));
            }}
        return result;
    }
    else
    Console.WriteLine("Not possible to multuply");
    return array;
}

Console.WriteLine("Input please number of rows for first matrix");//for first matrix
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input please number of columns for first matrix");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input please number of rows for second matrix");//for second matrix
int rows2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input please number of columns for second matrix");
int columns2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input please min value of member");//for both matrices
int minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input please max value of member");
int maxValue = Convert.ToInt32(Console.ReadLine());


int[,] myArray1 = create2DRandomArray(rows, columns, minValue, maxValue);
int[,] myArray2 = create2DRandomArray(rows2, columns2, minValue, maxValue);

Console.WriteLine("");
print2DRandomArray(myArray1);
Console.WriteLine("");
print2DRandomArray(myArray2);
Console.WriteLine("");

int[,] multiArray = MultiplyiedArray(myArray1, myArray2);
print2DRandomArray(multiArray);
Console.WriteLine("");
