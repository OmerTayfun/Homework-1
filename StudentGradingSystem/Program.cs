using System.Runtime.Intrinsics.X86;


string studentName, StudentLastName;
byte exam1, exam2, exam3;
double avg;
try
{
    Console.Write("Öğrenci sayısını giriniz:");
    byte studentNumber = Convert.ToByte(Console.ReadLine());

    for (int i = 1; i <= studentNumber; i++)
    {
        Console.Write("Öğrencinin Adını giriniz: ");
        studentName = Console.ReadLine();
        Console.Write("Öğrencinin Soyadını giriniz: ");
        StudentLastName = Console.ReadLine();
        Console.Write("Öğrencinin 1. Sınav Notunu Giriniz: ");
        exam1 = Convert.ToByte(Console.ReadLine());
        Console.Write("Öğrencinin 2. Sınav Notunu Giriniz: ");
        exam2 = Convert.ToByte(Console.ReadLine());
        Console.Write("Öğrencinin 3. Sınav Notunu Giriniz: ");
        exam3 = Convert.ToByte(Console.ReadLine());

        avg = (exam1 + exam2 + exam3) / 3;
        if (avg <= 100 && avg > 89)
        {
            Console.WriteLine("{0} {1} Notu: {2} \nHarf Notu: AA", studentName, StudentLastName, avg);
        }
        else if (avg <= 89 && avg > 79)
        {
            Console.WriteLine("{0} {1} Notu: {2} \nHarf Notu: BA", studentName, StudentLastName, avg);

        }
        else if (avg <= 79 && avg > 69)
        {
            Console.WriteLine("{0} {1} Notu: {2} \nHarf Notu: BB", studentName, StudentLastName, avg);

        }
        else if (avg <= 69 && avg > 59)
        {
            Console.WriteLine("{0} {1} Notu: {2} \nHarf Notu: CC", studentName, StudentLastName, avg);

        }
        else if (avg <= 59 && avg > 49)
        {
            Console.WriteLine("{0} {1} Notu: {2} \nHarf Notu: DD", studentName, StudentLastName, avg);

        }
        else
        {
            Console.WriteLine("{0} {1} Notu: {2} \nHarf Notu: FF", studentName, StudentLastName, avg);

        }


    }
    Console.WriteLine("İşlem başarıyla tamamlandı!");
}
catch (Exception)
{

    Console.WriteLine("Lütfen 0 ile 100 arasında sayısal bir değer giriniz.");
}




