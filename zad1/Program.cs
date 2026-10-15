Console.WriteLine("Enter a number: ");

int num = int.Parse(Console.ReadLine());

bool isEven = (num % 2 == 0);

if (isEven)
{
    Console.WriteLine("The number is even");
}
else
{
    Console.WriteLine("The number is odd");
}