Console.WriteLine("Введите целое число a: ");

int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите целое число b: ");

int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите целое число c: ");

int c = Convert.ToInt32(Console.ReadLine());

int max = Convert.ToInt32(a);

if(b > a)
{
     max = b;
} 
if(c > max)
{
    max = c;
}
 Console.WriteLine("Максимальное число: " + max);