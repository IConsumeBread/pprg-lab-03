Console.WriteLine("Enter a direction (north, south, east, west):");
string direction = Console.ReadLine();

switch (direction)
{
    case "north":
        Console.WriteLine("You're heading north.");
        break;
    case "south":
        Console.WriteLine("You're heading south.");
        break;
    case "east":
        Console.WriteLine("You're heading east.");
        break;
    case "west":
        Console.WriteLine("You're heading west.");
        break;
    default:
        Console.WriteLine("Invalid direction.");
        break;
}