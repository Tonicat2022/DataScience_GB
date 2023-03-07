//     // task 1
// int[,] create2DRandomArray(int rows, int columns)
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

// int[,] ChangeRows (int[,] array, int row1, int row2)
// {
//     row1--;
//     row2--;
//     if (row1 < array.GetLength(0) || row2 < array.GetLength(0) ||row1 < 0 || row2 < 0)
//     {
//         Console.WriteLine("Invalid rows umber");
//         return array;
//     }
//     else
//     {
//         for(int j = 0; j <array.GetLength(1); j++)
//         {
//             int temp = array[row1,j];
//             array[row1,j] = array[row2,j];
//             array[row2,j] = temp;
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
// Console.WriteLine("Input please number of first row to replace values of member");
// int row1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input please number of second row to replace with");
// int row2 = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = create2DRandomArray(rows, columns, minValue, maxValue);
// print2DRandomArray(myArray);
// ChangeRows(myArray);
// Console.WriteLine("");
// print2DRandomArray(myArray);

//     // task 2
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

// int[,] Transpond (int[,] array)
// {
//         int[,] new2DArray = new int[array.GetLength(1),array.GetLength(0)];
//     for(int i = 0; i < array.GetLength(1); i++)
//     {
//         for( int j = 0; j < array.GetLength(0); j++)
//         {
//             new2DArray[i,j] =  array[j,i];
//         }
//     }
//     return new2DArray;
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
// int[,] transpondedArray = Transpond(myArray);
// Console.WriteLine("");
// print2DRandomArray(transpondedArray);

    // task 2
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

int[,] ToEmplyMinCross (int[,] array)
{
    int[,] new2DArray = new int[array.GetLength(0),array.GetLength(1)];
    int minIPosition = 0;
    int minJPosition = 0;
    for(int i = 0; i < array.GetLength(0); i++)
    {   
        for( int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i,j] < array[minIPosition,minJPosition])
            {
                minIPosition = i;
                minJPosition = j;
            }
        }
    }
    for(int i = 0; i < array.GetLength(0); i++)
    {   
        for( int j = 0; j < array.GetLength(1); j++)
        {
            if ( i == minIPosition || j == minJPosition)
            {
                new2DArray[i,j] = 0;
            }
            else
            {
                new2DArray[i,j] = array[i,j];
            }
        }
    }
    return new2DArray;
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
print2DRandomArray(myArray);
int[,] changedArray = ToEmplyMinCross(myArray);
Console.WriteLine("");
print2DRandomArray(changedArray);