int[] X = {4, 2, 6, 7, 34, 1, 5, 5, 32, 6};

void PrintArray (int[] array)
{
    int count = array.Length;
    for ( int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]};");
    }
    Console.WriteLine();
}

int[] sortarray (int[] any)
{
    int count = any.Length;
    // int[] Y = new int [count];
    Console.WriteLine($"Array length is {count}; ");
    for (int i = 0; i < count-1; i++)
    {
        int minPosition = i;
        int temp = 0;
        for (int y = i+1; y < count; y++)
        {
            if (any [y] < any [minPosition])
            {
                minPosition = y; 
            } 
                temp = any[i];
                any[i] = any[minPosition];
                any[minPosition] = temp;
        };
    }
    return any;

}
PrintArray(X);
sortarray(X);
PrintArray(X);
