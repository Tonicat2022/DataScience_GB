//     task34: to Calculate Quantity of Even Numbers in array of 3-digit numbers
//  Console.WriteLine("Input please Size of Array");// asking for size
//  int Array_size = Convert.ToInt32(Console.ReadLine());
 
//  int[] new_Array = new int[Array_size];// creating of array based on size

// void toFillingArray (int[] Any_array)// filling of array by random numbers, based on requested assumptions
// {
//     int index = 0;
//     while( index < Any_array.Length)
//     {
//         Any_array[index] = new Random().Next(100,999);
//         index++;
//     };
// };

// void toPrintingArray (int[] Any_array)
// {
//     int index = 0;
//     while( index < Any_array.Length-1)
//     {
//         Console.Write($"{Any_array[index]}; ");
//         index++;
//     };
//     Console.Write($"{Any_array[index]}.");
// };

// int QuantityEvenNumbersArray (int[] Any_array)
// {
//     int quantity = 0;
//     for (int i = 0; i < Any_array.Length; i++)
//     {
//         Console.WriteLine($"{i} ->,{Any_array[i]}, {Any_array[i] % 2}");
//         if (Any_array[i] % 2 == 0)
//         {
//             quantity++;
//         }
//     }
//     return quantity;        
// }

// toFillingArray(new_Array);
// Console.WriteLine($"");
// int quantity = QuantityEvenNumbersArray(new_Array);
// Console.WriteLine($"{quantity} of Even numbers in");
// toPrintingArray(new_Array);

//     // task36: to Calculate sum of not Even membersin array

//  Console.WriteLine("Input please Size of Array");// asking for size
//  int Array_size = Convert.ToInt32(Console.ReadLine());
//   Console.WriteLine("Input please bottom of Array");// asking for lower limit
//  int Array_Bottom = Convert.ToInt32(Console.ReadLine());
//   Console.WriteLine("Input please Top of Array");// asking for higher limit
//  int Array_Top = Convert.ToInt32(Console.ReadLine());
 
//  int[] new_Array = new int[Array_size];// creating of array based on size

// void toFillingArray (int[] Any_array)// filling of array by random numbers, based on requested assumptions
// {
//     int index = 0;
//     while( index < Any_array.Length)
//     {
//         Any_array[index] = new Random().Next(Array_Bottom,Array_Top);
//         index++;
//     };
// };

// void toPrintingArray (int[] Any_array)
// {
//     int index = 0;
//     while( index < Any_array.Length-1)
//     {
//         Console.Write($"{Any_array[index]}; ");
//         index++;
//     };
//     Console.Write($"{Any_array[index]}.");
// };

// int SumNotEvenMembersArray (int[] Any_array)
// {
//     int SumNotEven = 0;
//     for (int i = 0; i < Any_array.Length; i = i+2)
//     {
//         SumNotEven += Any_array[i];
//         Console.WriteLine($"{i} ->,{Any_array[i]},  running total is  = {SumNotEven}");
//     }
//     return SumNotEven;   
// }

// toFillingArray(new_Array);
// Console.WriteLine("");
// int SumNotEven = SumNotEvenMembersArray(new_Array);
// Console.WriteLine($"{SumNotEven} the sum of not Even members in");
// toPrintingArray(new_Array);

    // task38: to find difference between maximum and minimum in any array

 Console.WriteLine("Input please Size of Array");// asking for size
 int Array_size = Convert.ToInt32(Console.ReadLine());
  Console.WriteLine("Input please bottom of Array");// asking for lower limit
 int Array_Bottom = Convert.ToInt32(Console.ReadLine());
  Console.WriteLine("Input please Top of Array");// asking for higher limit
 int Array_Top = Convert.ToInt32(Console.ReadLine());
 
 double[] new_Array = new double[Array_size];// creating of array based on size

void toFillingArray (double[] Any_array)// filling of array by random numbers, based on requested assumptions
{
    int index = 0;
    while( index < Any_array.Length)
    {
        Any_array[index] = new Random().NextDouble() + new Random().Next(Array_Bottom,Array_Top);
        index++;
    };
};

void toPrintingArray (double[] Any_array)
{
    int index = 0;
    while( index < Any_array.Length-1)
    {
        Console.Write($"{Any_array[index]}; ");
        index++;
    };
    Console.Write($"{Any_array[index]}.");
};

double DifferenceMaxvsMin (double[] Any_array)
{
    double difference = 0;
    double min = Any_array[0];
    double max = Any_array[0];
    for (int i = 0; i < Any_array.Length; i++)
    {
        if(Any_array[i]<min)
        {
            min = Any_array[i];
        }
        if(Any_array[i]>max)
        {
            max = Any_array[i];
        }
        
    }
    difference = max - min;
    Console.WriteLine($" max is {max};");
    Console.WriteLine($" min is {min}");
    Console.WriteLine($"difference = {difference}");
    return difference;
}

toFillingArray(new_Array);
Console.WriteLine("");
double difference = DifferenceMaxvsMin(new_Array);
toPrintingArray(new_Array);
