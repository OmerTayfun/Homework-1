
// do while nedir? 
//Bu bir döngü çeşidir diğerlerinden farkı işlemi en az 1 kere yapıp sonrasında şarta bağlı olarak tekrarlamasıdır. 

double total = 0;
int productNumber = 1;
char answer;
do
{
    Console.WriteLine("ÜRÜNLER");
    Console.WriteLine("1-Mikrofiber Temizlik Bezi : 144,13 TL  \n2-Kedi Ödül Maması : 67,73 TL \n3-Cilt Bakım Kremi : 170,28" +
        " \n4-Bilgisayar Temizlik Seti : 163,39 TL ");
    Console.WriteLine("\nLütfen Almak istediğiniz ürünün numarasını giriniz.");

    string selectOrder = Console.ReadLine();
    switch (selectOrder)
    {
        case "1":
            Console.WriteLine("Seçilen ürün Mikro fiber");
            total += 144.13;
            break;
        case "2":
            Console.WriteLine("Seçilen ürün Kedi Ödül Maması");
            total += 67.73;
            break;
        case "3":
            Console.WriteLine("Seçilen ürün Cilt Bakım Kremi");
            total += 170.28;
            break;
        case "4":
            Console.WriteLine("Seçilen ürün Bilgisayar Temizlik Seti");
            total += 163.39;
            break;
        default:
            Console.WriteLine("Hatalı Giriş.");
            break;


    }
    Console.WriteLine("Başka bir ürün var mı? 'e/h'");
    answer = Convert.ToChar(Console.ReadLine());

}


while (answer == 'e');
{
    Console.WriteLine($"Toplam tutar : {Math.Round(total, 2)} TL");
}

