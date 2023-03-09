//Console.WriteLine("Hello, World!");


using System.Collections;

class Program2
{
    public static void Main()
    {
        Kisi k1 = new Musteri();
        Console.WriteLine(k1.ToString());

        Musteri m1 = new Musteri();
        m1.MusteriNo = 1;
        m1.Ad = "Hasan";
        m1.Soyad = "Demir";
        m1.Bakiye = 100;

        //Musteri m2 = new Musteri();
        //m2.MusteriNo = 1;
        //m2.Ad = "Ayşe";
        //m2.Soyad = "Fidan";
        //m2.Bakiye = 200;

        Console.WriteLine(m1);
        //Console.WriteLine(m1.IndirimYap(50));
        //Console.WriteLine(m2);
        //Console.WriteLine(m2.IndirimYap(60));

        //int j = 5;//Int16  veya Int32 veya Int64 i=5;
        //if (j == 5)
        //{
        //    Console.WriteLine("Eşit");

        //}
        //else
        //{
        //    Console.WriteLine("Eşit Değil");
        //}
        //for (int i = 0; i < j; i++) //i=i+2
        //{
        //    Console.WriteLine(i);
        //}

    } //End Main


    //Array List
    public static void Samp1()
    {
        ArrayList  ar=new ArrayList();
        ar.Add(1); //ar.Add("Ali")
        ar.Add(2); //ar.Add("Veli")
        ar.Add(3); //ar.Add("Selami")
        ar.Add(4); //ar.Add("Ayşe")
        ar.Add(5); //ar.Add("Fatma")

        //ar[2]=8;

        for (int i = 0; i < ar.Count; i++)
        {
            Console.WriteLine(ar[i]);

        }

    }

}

