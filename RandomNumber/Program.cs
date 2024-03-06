
int r = new Random().Next(0, 10);
int userRandom = 0;



while (userRandom != r)
{
    Console.WriteLine("Lütfen bir sayı giriniz: ");
    userRandom = Convert.ToInt32(Console.ReadLine());
    if (userRandom == r)
    {
        Console.WriteLine("Doğru Tahmin");
    }
    else
    {
        Console.WriteLine("Yanlış Tahmin");
    }

}









