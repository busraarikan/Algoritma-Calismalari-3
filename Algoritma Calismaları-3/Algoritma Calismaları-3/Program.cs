namespace Algoritma_Calismaları_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region örnek-1


            //Klavyeden 1 ve 7 arasında bir sayı isteyen, girilen sayı sırasındaki haftanın gününü veren
            //C# konsol uygulamasının kodları switch-case yapısını kullanarak ekrana yazdırılmıştır.
         
           
            Console.Write("lütfen 1-7 arası bir sayı giriniz:");
            int sayi = Convert.ToInt32(Console.ReadLine());
            switch (sayi)
            {
                case 1:
                    Console.WriteLine("Haftanın 1.günü: Pazartesi");
                    break;
                case 2:
                    Console.WriteLine("Haftanın 2.günü: Salı");
                    break;
                case 3:
                    Console.WriteLine("Haftanın 3.günü: Çarşamba");
                    break;
                case 4:
                    Console.WriteLine("Haftanın 4.günü: Perşembe");
                    break;
                case 5:
                    Console.WriteLine("Haftanın 5.günü: Cuma");
                    break;
                case 6:
                    Console.WriteLine("Haftanın 6.günü: Cumartesi");
                    break;
                case 7:
                    Console.WriteLine("Haftanın 7.günü: Pazar");
                    break;
                default:
                    Console.WriteLine("lütfen geçerli bir sayı giriniz");
                    break;






            }



            #endregion


            #region örnek-2


           
            //Her aritmetik işlem, geriye değer döndüren parametreli metotlar ile yazıldı.
            //Programın sonunda 0 girişi yapıldığı durumda program başa dönerek tekrar çalışır.
            //0 girişi yapılmadığında ise program başa dönmeyip “Devam etmek için 0’a basın” ifadesi tekrar eder.
            //Ayrıca “Seçiminiz”  kısmında 5’e basılırsa program sonlanır.
            //switch case yapısı kullanarak seçim yapıldı



            HesapMakinesi();



            #endregion


            #region örnek-3




           // 20 elemanlı bir tam sayı dizisine 7’den itibaren 7’nin katlarını ekleyen
           // ve bu sayıları yan yana ekrana yazdıran void metodu yazın kodunu yazıldı.







            int[] sayilar = new int[20];
            int sayi = 0;
            for (int i = 7; i < sayilar.Length; i++)
            {
                sayi = sayi + 7;
                sayilar[i] = sayi;
                Console.Write(sayilar[i] + ",");


            }


            #endregion


            #region örnek-4

            //15 elemanlı bir diziyi en küçük asal sayıdan itibaren, asal sayılar ile dolduran C# kodu.

           int[] asallar = new int[15];

            asallar[0] = 2;
            asallar[1] = 3;
            asallar[2] = 5;
            asallar[3] = 11;
            asallar[4] = 13;
            asallar[5] = 17;
            asallar[6] = 19;
            asallar[7] = 23;
            asallar[8] = 29;
            asallar[9] = 31;
            asallar[10] = 37;
            asallar[11] = 41;
            asallar[12] = 43;
            asallar[13] = 47;
            asallar[14] = 53;


            for (int i = 0; i <= 14; i++)
            {
                Console.WriteLine(asallar[i]);
            }




            #endregion




            #region örnek-5

            //Rastgele değerde 10 elemanlı bir sayı dizisi oluşturun.Bu dizi içerisindeki
            //tek sayıları başka bir diziye ekleyip, çift sayıları da bambaşka bir diziye ekleyen programı yazın.
            //Bir dizinin elemanını aralarına boşluk koyarak yan yana yazdıran metodu yazın.
            //Bu metot ile bu sorudaki 3 diziyi de ekrana yazdıran kod


            int sayac1 = 1;
            int sayac2 = 1;
            int[] rastgeleSayis = new int[10];
            int[] teksayis = new int[sayac1];
            int[] ciftsayis = new int[sayac2];


            for (int i = 0; i < 10; i++)

            {
                Random rnd = new Random();
                int rastgeleSayi = rnd.Next();

                rastgeleSayis[i] = rastgeleSayi;

                if (rastgeleSayis[i] % 2 == 0)
                {

                    ciftsayis[sayac1] = rastgeleSayis[i];
                    sayac1++;

                }
                else
                {

                    teksayis[i - 1] = rastgeleSayis[i];
                    sayac2++;

                }



            }
            for (int a = 0; a < 10; a++)
            {
                Console.Write("Rastgele seçilen sayılar: ");
                Console.Write(rastgeleSayis[a] + ", ");

            }
            for (int b = 0; b < 10; b++)
            {
                Console.Write("Rastgele seçilen sayılardan tek olanlar: ");
                Console.Write(teksayis[b] + ", ");

            }
            for (int c = 0; c < 10; c++)
            {
                Console.Write("Rastgele seçilen sayılar: ");
                Console.Write(ciftsayis[c] + ", ");

            }



            #endregion




            


        }



        static void HesapMakinesi()
        {
        bas:
            Console.Write("1.sayiyi girin: ");
            int sayi1 = int.Parse(Console.ReadLine());
            Console.Write("2.sayiyi giriniz : ");
            int sayi2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Toplama icin 1`e basin");
            Console.WriteLine("Cikarma icin 2`e basin");
            Console.WriteLine("Carpma icin 3`e basin");
            Console.WriteLine("Bolme icin 4`e basin");
            Console.WriteLine("Çıkış için 5'e basin");
            Console.WriteLine("Devam etmek için 0'a basin");




            Console.Write("seciminiz: ");
            int secim = int.Parse(Console.ReadLine());
            double sonuc = 0;


            switch (secim)
            {

                case 1:

                    sonuc = Toplama(sayi1, sayi2);
                    Console.WriteLine("işlem sonucu:" + sonuc);
                    break;
                case 2:
                    sonuc = Cıkarma(sayi1, sayi2);
                    Console.WriteLine("işlem sonucu:" + sonuc);
                    break;
                case 3:
                    sonuc = Carpma(sayi1, sayi2);
                    Console.WriteLine("işlem sonucu:" + sonuc);
                    break;
                case 4:
                    sonuc = Bolme(sayi1, sayi2);
                    Console.WriteLine("işlem sonucu:" + sonuc);
                    break;
                case 5:
                    break;
                case 0:
                    goto bas;
                    break;
                default:
                    Console.WriteLine("Devam etmek için 0 'a basın");
                    goto bas;
                    break;




            }

        }
}
