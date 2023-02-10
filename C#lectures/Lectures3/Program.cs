 Console.Clear();
 Console.Write("Input please name of the User : ");
string username = Console.ReadLine();

if(username.ToLower() == "masha" | username.ToLower() == "maria")
{
    Console.WriteLine("Hi there, dear Maria!!!");
}
else
{
    Console.Write("Hi, ");
    Console.WriteLine(username);
}