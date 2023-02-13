Console.Clear();
int count = 0, close = 0, check = 0;
double time = 0;
Console.WriteLine("Input initial distance between friends = ");
double distance = double.Parse(Console.ReadLine());
Console.WriteLine("Input Dog speed = ");
double dogSpeed = double.Parse(Console.ReadLine());
Console.WriteLine("Input First friend speed = ");
double firstFriendSpeed = double.Parse(Console.ReadLine());
Console.WriteLine("Input Second friend speed = ");
double SecondFriendSpeed = double.Parse(Console.ReadLine());
Console.WriteLine("With which friend the dog was initially 1 or 2 - please input = ");
int friend = int.Parse(Console.ReadLine());
while (check !=1) // checking for correct friend number
{
    if (friend == 1 | friend == 2)
    {check = 1;}
    else
    {
    Console.WriteLine("Please input only 1 or 2 for Friend with the Dog = ");
    friend = int.Parse(Console.ReadLine());
    // check = 2;
    }   
};
