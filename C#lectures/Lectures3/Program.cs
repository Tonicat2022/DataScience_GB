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

    //type 4
string Method4(int count, string text)
{
    int i = 0;
    string output = string.Empty;
    while (i < count)
    {
        output = output + text;
        i ++;
    };
    return  output;
}
string result = Method4(10,"asdf");
Console.WriteLine(result);
