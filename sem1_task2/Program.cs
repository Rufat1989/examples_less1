Console.WriteLine("Введите число 1: ");
int x = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число 2: ");
int y = int.Parse(Console.ReadLine()!);
if (x > y) 
{
    Console.Write("max число: ");
    Console.WriteLine(x);
    Console.Write("min число: ");
    Console.WriteLine(y);
    

}
else 
{
    Console.Write("max число: ");
    Console.WriteLine(y);
    Console.Write("min число: ");
    Console.WriteLine(x);
}
