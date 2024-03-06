
Console.WriteLine("1- Bilgisayar \n2- Telefon \n3- Tablet \n4- Kulaklık");

Console.Write("Lütfen almak istediğiniz ürünün numarasını giriniz: ");

string selectOrder;
selectOrder = Console.ReadLine();


switch (selectOrder)
{

    case "1":
        Console.WriteLine("Seçtiğiniz ürün: Bilgisayar");
        break;
    case "2":
        Console.WriteLine("Seçtiğiniz ürün: Telefon");
        break;
    case "3":
        Console.WriteLine("Seçtiğiniz ürün: Tablet");
        break;
    case "4":
        Console.WriteLine("Seçtiğiniz ürün: Kulaklık");
        break;
    default:
        Console.WriteLine("Lütfen geçerli bir sayı giriniz.");
        break;

}

