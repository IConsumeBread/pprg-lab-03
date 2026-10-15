Console.WriteLine("Enter your hp amount: ");
int hp = int.Parse(Console.ReadLine());
bool isAlive = hp > 0;
const int heal = 50;

if (!isAlive)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("You're dead, can't continue.");
    Console.ResetColor();
    Environment.Exit(0);
}
else if (hp < 20)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Your hp is low!");
    Console.ResetColor();
}

Console.WriteLine("Enter your weapon attack damage: ");
int weaponAttack = int.Parse(Console.ReadLine());

Console.WriteLine("Do you have a heaing item? (True/False)");
bool hasHealing = bool.Parse(Console.ReadLine());


Console.WriteLine("Choose your next action:\n1 - Attack\n2 - Heal\n3 - Run away");
int action = int.Parse(Console.ReadLine());
switch (action)
{
    case 1:
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine($"You dealt {weaponAttack} damage.");
    Console.ResetColor();
    break;

    case 2:
    hp = Math.Min(hp + heal, 100);
    if (hp == 100)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Your hp has been maxed out.");
        Console.ResetColor();
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"You healed! You have {hp} hp.");
        Console.ResetColor();
    }
    break;
    
    case 3:
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("You ran away.");
    Console.ResetColor();
    break;

    default:
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Invalid action. Try again.");
    Console.ResetColor();
    break;
}