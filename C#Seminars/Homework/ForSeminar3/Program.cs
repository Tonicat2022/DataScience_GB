    // Check for Polyndrome
int x = 0;
bool CheckIf5Digit (int num)
{
    if (num > 9999 && num < 100000)
    {
        return true; // yes, it is 
    }
        return false;
};

void CheckPolindrom (int num)
{ 
    if (CheckIf5Digit(x))
    {
        char [] xArray = Convert.ToString(num).ToArray();
        // int index = 0; ///for display xArray
        // while (index < 5)
        // {
        //     Console.Write($"{xArray[index]};");
        //     index ++;
        // };
        if (xArray[0] == xArray[4] && xArray[1] == xArray[3])
        {
            Console.Write($"{num} is Polindrome");
        }
        else
        {
            Console.Write($"{num} is NOT Polindrome");
        }
    }
    else
    {
        Console.Write($"{num} is not Five-MiddleDigit Number");
    }
}
Console.WriteLine("Please input five-digit number");
x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
CheckPolindrom(x);