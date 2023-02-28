    // task36: to Calculate sum of not Even membersin array

 Console.WriteLine("Input please Size of Array");// asking for size
 int Array_size = Convert.ToInt32(Console.ReadLine());
  Console.WriteLine("Input please bottom of Array");// asking for lower limit
 int Array_Bottom = Convert.ToInt32(Console.ReadLine());
  Console.WriteLine("Input please Top of Array");// asking for higher limit
 int Array_Top = Convert.ToInt32(Console.ReadLine());
 
 int[] new_Array = new int[Array_size];// creating of array based on size

void toFillingArray (int[] Any_array)// filling of array by random numbers, based on requested assumptions
{
    int index = 0;
    while( index < Any_array.Length)
    {
        Any_array[index] = new Random().Next(Array_Bottom,Array_Top);
        index++;
    };
};

void toPrintingArray (int[] Any_array)
{
    int index = 0;
    while( index < Any_array.Length-1)
    {
        Console.Write($"{Any_array[index]}; ");
        index++;
    };
    Console.Write($"{Any_array[index]}.");
};

int[] ReverseArray (int[] Any_array)
{
        for (int i = 0; i < Any_array.Length/2; i ++)
    {
        int temp = Any_array[i];
        Any_array[i] = Any_array[Any_array.Length-1-i];
        Any_array[Any_array.Length-1-i] = temp;
        // Console.WriteLine($"{i} ->,{Any_array[i]},  running total is  = {SumNotEven}");
    }
    return Any_array;   
}

toFillingArray(new_Array);
toPrintingArray(new_Array);
Console.WriteLine("");
int[] reversedArray = ReverseArray(new_Array);
toPrintingArray(new_Array);