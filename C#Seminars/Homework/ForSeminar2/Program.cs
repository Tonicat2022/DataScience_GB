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