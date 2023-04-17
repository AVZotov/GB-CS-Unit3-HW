Console.Clear();
Console.WriteLine("Program to print 3rd degree of values from 1 to N");
Console.Write("Enter your value: ");
int userValue = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= userValue; i++)
{
    Console.Write($"{Math.Pow(i, 3)} ");
}
