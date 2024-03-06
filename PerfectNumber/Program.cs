using System.Numerics;

Console.Write("Lütfen bir sayı giriniz: ");
int number = Convert.ToInt32(Console.ReadLine());
int perfectNumber = 0;

for (int i = 1; i < number; i++)
{
    if (number % i == 0)
    {
        perfectNumber += i;

    }
}
if (perfectNumber == number)
{
    Console.WriteLine("{0} Mükemmel bir sayıdır.", number);
}

else
{
    Console.WriteLine("{0} Mükemmel bir sayı değildir.", number);
}


