Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
int n1 = n / 100;
int n2 = (n % 100) / 10;
int n3 = n % 10;
if (Math.Pow(n, 2) == Math.Pow((n1 + n2 + n3), 3))
{
    Console.WriteLine("Условие истинно");
}
else
{
    Console.WriteLine("Условие ложно");
}
