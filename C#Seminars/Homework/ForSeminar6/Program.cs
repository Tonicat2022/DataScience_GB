//     // Task 41
// Console.WriteLine("Input please Size of Array");// asking for size
//  int Array_size = Convert.ToInt32(Console.ReadLine());

//  int[] new_Array = new int[Array_size];// creating of array based on size

// void toFillingArray (int[] Any_array)// filling of array by random numbers, based on requested assumptions
// {
//     for (int i = 0; i < Any_array.Length; i++)
//     {
//         Console.WriteLine("Input please next member of Array");
//         Any_array[i] = Convert.ToInt32(Console.ReadLine());
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

// int CountZero (int[] Any_array)
// {
//     int count = 0;
//     for (int i = 0; i < Any_array.Length; i ++)
//     {
//         if(Any_array[i] == 0) {count++;};
//     }
//     return count;   
// }

// toFillingArray(new_Array);
// toPrintingArray(new_Array);
// Console.WriteLine("");
// int countzero = CountZero(new_Array);
// Console.WriteLine($"{countzero} zero in array");