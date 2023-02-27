    // task: find summ of positive members and negative members

//  int[] new_Array = new int[12];// creating of array based on size

// void toFillingArray (int[] Any_array)// filling of array by random numbers, based on requested assumptions
// {
//     int index = 0;
//     while( index < Any_array.Length)
//     {
//         Any_array[index] = new Random().Next(-10,10);
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

// void DifferenceMaxvsMin (int[] Any_array)
// {
//     int sumpositive = 0;
//     int sumnegative = 0;
//     for (int i = 0; i < Any_array.Length; i++)
//     {
//         if(Any_array[i]<0)
//         {
//             sumnegative += Any_array[i];
//         }
//         if(Any_array[i]>0)
//         {
//             sumpositive += Any_array[i];
//         }
        
//     }
//     Console.WriteLine($" sum of negative is {sumnegative};");
//     Console.WriteLine($" sum of positive is  {sumpositive}");
// }
// toFillingArray(new_Array);
// toPrintingArray(new_Array);
// Console.WriteLine($"");
// DifferenceMaxvsMin(new_Array);

//     // task: convert members to another sign: positive to negative and opposite way

//  Console.WriteLine("Input please Size of Array");// asking for size
//  int sizeArray = Convert.ToInt32(Console.ReadLine());
//   Console.WriteLine("Input please bottom of Array");// asking for lower limit
//  int bottomArray = Convert.ToInt32(Console.ReadLine());
//   Console.WriteLine("Input please Top of Array");// asking for higher limit
//  int topArray = Convert.ToInt32(Console.ReadLine());
 
// int[] toCreateArray (int size, int bottom, int top)// filling of array by random numbers, based on requested assumptions
// {
//     int[] any_Array = new int[size];
//     int index = 0;
//     while( index < any_Array.Length)
//     {
//         any_Array[index] = new Random().Next(bottom,top);
//         index++;
//     };
//     return any_Array;
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

// int[] ConvertArray (int[] Any_array)
// {
//     for (int i = 0; i < Any_array.Length; i++)
//     {
//         Any_array[i] = Any_array[i] * (-1);      
//     }
//     return Any_array;
// }

// int[] new_Array = toCreateArray(sizeArray, bottomArray, topArray);

// Console.Write($"Array as is :");
// toPrintingArray(new_Array);
// Console.WriteLine($"");
// ConvertArray(new_Array);
// Console.Write($"Converted Array :");
// toPrintingArray(new_Array);

//  task: to find number in array

Console.WriteLine("Input please Size of Array");// asking for size
int sizeArray = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input please bottom of Array");// asking for lower limit
int bottomArray = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input please Top of Array");// asking for higher limit
int topArray = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Which number you want to find");// asking for higher limit
int numberToFind = Convert.ToInt32(Console.ReadLine());

int[] toCreateArray (int size, int bottom, int top)// filling of array by random numbers, based on requested assumptions
{
    int[] any_Array = new int[size];
    int index = 0;
    while( index < any_Array.Length)
    {
        any_Array[index] = new Random().Next(bottom,top);
        index++;
    };
    return any_Array;
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

string ToFindMember (int[] Any_array)
{
    string answer = "";
    for (int i = 0; i < Any_array.Length; i++)
    {
        if(Any_array[i] == numberToFind)
        {
            answer = $"yes, {numberToFind} is found in Array";
            break;
        }
        else {answer = $"there are no matches for {numberToFind}" ;}      
    }
    return answer;
}

int[] new_Array = toCreateArray(sizeArray, bottomArray, topArray);

Console.Write($"Array is :");
toPrintingArray(new_Array);
Console.WriteLine($"");
Console.WriteLine(ToFindMember(new_Array));