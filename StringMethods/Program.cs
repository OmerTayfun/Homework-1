//String Metodlar
//Metinsel ifadelerle işlemler yapabilmek için kullanılan fonksiyonlardır.
//Concat: Birleştirme işlemi yapar.
//Length: Girilen metnin uzunluğu
//Indexof: Metin arama işlemi yapar.
//Startswith: İlgili parametre ile mi başlıyor bunu kontrol eder.
//Trim: Metnin başındaki ve sonundaki boşlukları siler.
//ToUpper: Metni büyük halde yazar.
//ToLower: Metni küçük halde yazar.
//Remove: İstenilen karakterden itibaren silme işlemi yapar.
//Replace: Değiştirme işlemi yapar.
//Substring: İstenilen karakterden sonra yazmaya başlar.

using System.Diagnostics.Metrics;
using System.Reflection;

string text;
Console.Write("Metni giriniz: ");
text = Console.ReadLine();

string text2;
Console.Write("2. Metni giriniz: ");
text2 = Console.ReadLine();

Console.WriteLine("Concat ile birleştirme: " + string.Concat(text, " ", text2));

Console.WriteLine("1. Metnin karakter sayısı: " + text.Length);

Console.WriteLine("Indexof Örneği: " + " " + text.IndexOf("aydın"));

Console.WriteLine("Startwith kullanımı: " + " " + text.StartsWith("merhaba"));

Console.WriteLine("Trim kullanımı : " + " " + text.Trim());

Console.WriteLine("ToUpper Kullanımı: " + " " + text.ToUpper());

Console.WriteLine("ToLower Kullanımı: " + " " + text.ToLower());

Console.WriteLine("Replace kullanımı: " + " " + text.Replace("Karanlık ", "Aydınlık "));

Console.WriteLine("Remove işlemine örnek: " + " " + text.Remove(4));

Console.WriteLine("Substring Kullanımı: " + " " + text.Substring(5));



