Console.WriteLine("Enter your hp: ");
int hp = int.Parse(Console.ReadLine());
bool isAlive = hp > 0;

Console.WriteLine("Do you have the key?");
bool hasKey = bool.Parse(Console.ReadLine());

Console.WriteLine("Do you know the password?");
bool hasPassword = bool.Parse(Console.ReadLine());

bool canEnter = isAlive && hasKey || hasPassword;

if (!isAlive)
{
    canEnter = false;
}

Console.WriteLine($"Hp: {hp}");
Console.WriteLine($"Key: {hasKey}");
Console.WriteLine($"Password: {hasPassword}");
Console.WriteLine($"Can enter: {canEnter}");