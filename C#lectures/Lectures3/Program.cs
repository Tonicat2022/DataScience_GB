    //type 1
// void Method1()
// {
//     Console.WriteLine("Author....");
// }
// Method1();

    //type 2
// void Method21(string msg)
// {
//     Console.WriteLine(msg);    
// }

// Method21("Any text to display");

// void Method21(string msg, int count)
// {
//     int i = 0;
//     while (i < count)
//     {
//         Console.WriteLine(msg);    
//         i ++;
//     };
// }

// Method21("Any text to display", 5);
// Method21(count: 3, msg: "any text");

//     //type 3
// int Method3()
// {
//     return DateTime.Now.Year;    
// }
// Method3();
// int year = Method3();
// Console.WriteLine(year);

//    // type 4
// string Method4(int count, string text)
// {
//     int i = 0;
//     string output = string.Empty;
//     while (i < count)
//     {
//         output = output + text;
//         i ++;
//     };
//     return  output;
// }
// string result = Method4(10,"asdf");
// Console.WriteLine(result);

    // for
    // examble 1
// string Method4(int count, string text)
// {
    
//     string output = string.Empty;
//     for (int i = 0; i < count; i++)
//     {
//         output = output + text;
//     };
//     return  output;
// }
// string result = Method4(10,"asdf");
// Console.WriteLine(result);

    // examble 2
// void Method4(int x, int y)
// {
//     for (int i = 0; i < x; i = i+10)
//     {
//         for (int n = 1; n < y+1; n++)
//         {
//             Console.Write($"{i+n} ;");
//         };
//         Console.WriteLine();
//     };
// }
// Method4(100,10);

    // examble 3
// "All the world's a stage! - and all the men and women merely players." 
// "To thine own self be true." 
// "Ay! -  there's the rub."
// "Parting is such sweet sorrow!."
// "If music be the food of love, play on."

// string text = "All the worlds a stage! - and all the men and women merely players."
//             +" To thine own self be true." 
//             +"Ay! -  there's the rub. Parting is such sweet sorrow!"
//             +"If music be the food of love, play on.";
// string ReplaceSymbol (string text, char Old, char New)
//  {
//     string result = string.Empty;
//     int length = text.Length;
//     for (int i=0; i < length; i++)
//     {
//         if (text[i] == Old)
//         {
//         result = result + New;
//         }
//         else
//         {
//         result = result + text[i];
//         };
//     }
//     return result;
//  };
// Console.WriteLine($"{ReplaceSymbol(text,'!',';')}");

    // examble 4

int[] arr = {1,5,4,3,2,6,7,1,1};

void PrintArray (int[] array)
{
    int count = array.Length;
    for ( int i = 0; i < count; i++)
    {
        Console.Write($"{array[1]};");
    }
    Console.WriteLine();
}
