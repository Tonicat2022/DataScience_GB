Console.Clear();
Console.BufferHeight = 60;
// Console.SetCursorPosition(1,1);
// Console.WriteLine("*");
int xa = 40; int ya = 1;
int xb = 1; int yb = 30;
int xc = 800; int yc = 30;
Console.SetCursorPosition(xa, ya); Console.WriteLine(".");
Console.SetCursorPosition(xb, yb); Console.WriteLine(".");
Console.SetCursorPosition(xc, yc); Console.WriteLine(".");
int x = xa, y = ya, count = 0;
while(count < 500)
{
    int rnd = new Random().Next(0,3); // 0,1,2
    if(rnd == 0)
    {
        x = (x + xa) / 2;
        y = (y + ya) / 2;
    }

    if(rnd == 1)
    {
        x = (x + xb) / 2;
        y = (y + yb) / 2;
    }
    
    if(rnd == 2)
    {
        x = (x + xc) / 2;
        y = (y + yc) / 2;
    }
    Console.SetCursorPosition(x, y);
    Console.WriteLine(".");
    count += 1;
};