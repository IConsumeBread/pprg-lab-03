Console.WriteLine("Enter your age: ");
int age = int.Parse(Console.ReadLine());

if (age < 0)
{
    Console.WriteLine("Invalid number\nAge can't be negative.");
}
else if (age < 13)
{
    Console.WriteLine("You're a minor.");
}
else if (age < 18)
{
    Console.WriteLine("You're a teenager.");
}
else if (age < 65)
{
    Console.WriteLine("You're an adult.");
}
else
{
    Console.WriteLine("You're ancient.");
}