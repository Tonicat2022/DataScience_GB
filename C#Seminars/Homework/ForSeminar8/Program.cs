    // Task 54 Sorting in rows by descending

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

void SelectionSort (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for ( int j = 0; j < array.GetLength(1)-1; j++)
        {
            int MinPostition = j;
            for ( int z = j +1; z < array.GetLength(1); z++)  
            {
                if (array[i, z] > array[i, MinPostition]) MinPostition = z;
            }
            int temp = array[i,j];
            array[i, j] = array[i, MinPostition];
            array[i, MinPostition] = temp;
        }
    }
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
SelectionSort(myArray);
Console.WriteLine("");
print2DRandomArray(myArray);
