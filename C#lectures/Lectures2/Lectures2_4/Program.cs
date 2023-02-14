/* Void - Метод(функция) который ничего не возвращает
1) Определили массив
2) toFillingArray - метод заполнили массив
3) toPrintingArray - метод Распечатали массив
*/
 Console.WriteLine("Input please bottom of Random for Array");// asking for bottom
 int bottom_for_Random = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("Input please top of Random for Array");// asking for top
 int top_for_Random = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("Input please Size of Array");// asking for size
 int Array_size = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("Input please Value to try to Find in Array");// asking for Value to find in Random filled array
 int Value_to_Find = Convert.ToInt32(Console.ReadLine());

 int[] new_Array = new int[Array_size];// creating of array based on size

void toFillingArray (int[] Any_array)// filling of array by random numbers, based on requested assumptions
{
    int index = 0;
    while( index < Any_array.Length)
    {
        Any_array[index] = new Random().Next(bottom_for_Random,top_for_Random);
        index++;
    };
};

void toPrintingArray (int[] Any_array)// filling of array by random numbers, based on requested assumptions
{
    int index = 0;
    while( index < Any_array.Length-1)
    {
        Console.Write($"{Any_array[index]}; "); // output all members of array except last one
        index++;
    };
    Console.Write($"{Any_array[index]}.");// output last member of array
};

void Find_Index_By_Value (int[] Any_array, int find_value)
{
    int index = 0;
    int searched_index = -1; // initial index of position
    while( index < Any_array.Length)
    {
        if(Any_array[index] == find_value)
        {
            searched_index = index;
            Console.WriteLine($" {searched_index} is position of {find_value} in Array");
            break;// to stop cycle after first match
        };
        index++;
    };
    if (searched_index == -1) // if no matching in all array
    {
        Console.WriteLine($" there is NO {find_value} member in Array");
    };
}

toFillingArray(new_Array);
toPrintingArray(new_Array);
Console.WriteLine($"");// to add empty line
Find_Index_By_Value(new_Array, Value_to_Find);
