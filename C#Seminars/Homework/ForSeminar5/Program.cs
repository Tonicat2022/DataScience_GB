    // to Calculate Quantity of Even Numbers in array of 3-digit numbers
 Console.WriteLine("Input please Size of Array");// asking for size
 int Array_size = Convert.ToInt32(Console.ReadLine());
 
 int[] new_Array = new int[Array_size];// creating of array based on size

void toFillingArray (int[] Any_array)// filling of array by random numbers, based on requested assumptions
{
    int index = 0;
    while( index < Any_array.Length)
    {
        Any_array[index] = new Random().Next(100,999);
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

int QuantityEvenNumbersArray (int[] Any_array)
{
    int quantity = 0;
    for (int i = 0; i < Any_array.Length; i++)
    {
        Console.WriteLine($"{i} ->,{Any_array[i]}, {Any_array[i] % 2}");
        if (Any_array[i] % 2 == 0)
        {
            quantity++;
        }
    }
    return quantity;        
}

toFillingArray(new_Array);
int quantity = QuantityEvenNumbersArray(new_Array);
// toPrintingArray(new_Array);
Console.WriteLine($"");
Console.WriteLine($"{quantity} of Even numbers in");
toPrintingArray(new_Array);
