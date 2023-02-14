// Task 1
Console.Clear;
void Max (int num)
{
    int ed = num % 10;
    int dec = num /10;
    if(ed>dec)
    {
        Console.WriteLine($" Biggest digit of {num} is {ed}");    
    }
    else
    {
        Console.WriteLine($" Biggest digit of {num} is {dec}");    
    }
}

int Random_number = new Random().Next(10,100);
Max(Random_number);
