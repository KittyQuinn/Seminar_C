Console.Clear();
Console.Write("Write number1 ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Write number2 ");
int number2 = int.Parse(Console.ReadLine());

if(number2 == number1 * number1)
{
    Console.WriteLine("Yes");
}
else 
{
    Console.WriteLine("No");
}
