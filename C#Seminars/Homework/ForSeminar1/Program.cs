    //task 2
// Console.Clear();
// Console.WriteLine("Please input First Number");
// int n1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Please input Second Number");
// int n2 = Convert.ToInt32(Console.ReadLine());
// if (n1 > n2)
// {
//     Console.WriteLine($"Maximum number from {n1} and {n2} is {n1} !!!");
// }
// else
// {
//     Console.WriteLine($"Maximum number from {n1} and {n2} is {n2} !!!");
// };
    // task 4
// Console.Clear();
// Console.WriteLine("Please input First Number");
// int n1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Please input Second Number");
// int n2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Please input Second Number");
// int n3 = Convert.ToInt32(Console.ReadLine());
// int max = n1;
// if (n2 > max)
// {
//     max = n2;}
// if (n3 > max)
// {
// max = n3;
// };
// Console.WriteLine($"Maximum number from {n1}, {n2}, {n3} is {max} !!!");
    // task 6
// Console.Clear();
// Console.WriteLine("Please input Number");
// int n = Convert.ToInt32(Console.ReadLine());
// int rest = n%2;
// if (rest ==0)
// {
//   Console.WriteLine($"Number {n} is devided by 2 without any rest!!!");  
// }
// else
// {
//   Console.WriteLine($"Number {n} is devided by 2 with rest: {rest}");
// };
    // task 8
Console.Clear();
Console.WriteLine("Please input Number");
int n = Convert.ToInt32(Console.ReadLine());
int current = 2;
if(n < 2)
{
    Console.WriteLine($"Where no positive even numbers between 1 and {n} ");    
}
else
{   
    Console.Write($"Positive Even numbers between 1 and {n} are: ");
    while (current <= n)
    {  
        Console.Write($"{current} ");
        current= current + 2;
    };

};