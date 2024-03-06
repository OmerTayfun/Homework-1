
using System.ComponentModel;

double total = 0;
int productNumber = 1;

Console.WriteLine("ÜRÜNLER");
Console.WriteLine("1-Mikrofiber Temizlik Bezi : 144,13 TL  \n2-Kedi Ödül Maması : 67,73 TL \n3-Cilt Bakım Kremi : 170,28" +
    " \n4-Bilgisayar Temizlik Seti : 163,39 TL ");
Console.WriteLine("\nLütfen Almak istediğiniz ürünün numarasını giriniz.");

string selectOrder = Console.ReadLine();

switch (selectOrder)
{
    case "1":
        Console.WriteLine("Seçilen ürün: Mikro Fiber Temizlik Bezi");
        break;
    case "2":
        Console.WriteLine("Seçilen ürün: Kedi Ödül Maması");
        break;
    case "3":
        Console.WriteLine("Seçilen ürün: Cilt Bakım Kremi");
        break;
    case "4":
        Console.WriteLine("Seçilen ürün: Bilgisayar Temizlik Seti");
        break;
    default:
        Console.WriteLine("Lütfen listedeki sayılardan birini seçiniz.");
        break;


}
Console.Write("Ürün adedini giriniz: ");
productNumber = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= productNumber; i++)
{
    if (selectOrder == "1")
    {
        total = 144.13 + total;

    }
    else if (selectOrder == "2")
    {
        total = 67.73 + total;

    }
    else if (selectOrder == "3")
    {
        total = 170.28 + total;

    }
    else if (selectOrder == "4")
    {
        total = 163.39 + total;

    }

}
Console.WriteLine("Toplam fiyat : " + Math.Round(total, 2) + " TL");



