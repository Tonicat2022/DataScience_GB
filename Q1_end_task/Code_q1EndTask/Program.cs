string[] initialArray = new string[] {"hello", "2", "world", "!", "peace", "new"};

int ToDefineLenth (string[] Array)
{
    int sum = 0;
    for (int i = 0; i < Array.Length; i++)
    {
        if ( Array[i].Length <=3) sum += 1;
    }
    return sum;
}
// Console.WriteLine(ToDefineLenth(initialArray));

string[] ResultArray (string[] Array)
{
    string[] resulsArray = new string[ToDefineLenth(Array)];
    int i = 0;
    int y = 0;
    while (i < Array.Length)
    {
        if ( Array[i].Length <=3)
        {
            resulsArray[y] = Array[i];
            y++;
        }
        i++;
    }
    return resulsArray;
}

void ToPrintingArray (string[] Array)
{
    for (int i = 0; i < Array.Length; i++)
    {
    Console.Write($"{Array[i]}; ");
    }
}

string [] resultArray = ResultArray(initialArray);
ToPrintingArray(initialArray);
Console.WriteLine("");
ToPrintingArray(resultArray);