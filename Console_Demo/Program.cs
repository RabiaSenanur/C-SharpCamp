using System.Reflection.Metadata.Ecma335;

namespace Console_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("İsminizi girin: ");
            //string name = Console.ReadLine();
            //Console.WriteLine("Soyisminizi girin:");
            //string surname = Console.ReadLine();
            //Console.WriteLine("İsim: " +  name + "\n" + "Soyisim: " + surname);

            // **int -> byte** dönüşümü
            //int a = 5;
            //byte b = (byte)a;

            //Console.WriteLine(b.GetType());
            //Console.WriteLine(b);

            //**string -> int** dönüşümü
            //string num1 = "1";
            //string num2 = "2";

            //int a = int.Parse(num1);
            //int a =  Convert.ToInt32(num1);
            //int b = int.Parse(num2);
            //int b = Convert.ToInt32(num2);
            //Console.WriteLine(a + b);

            //**int -> string** dönüşümü
            //int num1 = 5;
            //int num2 = 10;

            //string a = num1.ToString();
            //string b = num2.ToString();
            //Console.WriteLine(a + b);

            //** double -> int** dönüşümü
            //double num = 5.22;

            //int a = Convert.ToInt32(num);
            ////int b = int.Parse(num);
            //Console.WriteLine(a);

            // Kullaıcıdan alınan değerler string veri tipinde olur.

            //Console.WriteLine("Yaşınız: ");
            //string age_s = Console.ReadLine();
            //int age = Convert.ToInt32(age_s);
            //Console.WriteLine(age);

            // Ornek
            //Console.WriteLine("2 tane sayı girin: ");
            //Console.Write("1: ");
            //int num1 = int.Parse(Console.ReadLine());
            //Console.Write("1: ");
            //int num2 = int.Parse(Console.ReadLine());

            ////Console.WriteLine("{0} + {1} = {2}",num1,num2,num1 + num2);
            //Console.WriteLine("İki sayının toplamı:" + (num1 + num2));

            // ToString();
            // Convert.ToInt();
            // int.Parse();
            // double.Parse();
            //(int)

            //if ornek
            //Console.Write("Birinci notunuzu girin: ");
            //int note1 = int.Parse(Console.ReadLine());
            //Console.Write("İkinci notunuzu girin: ");
            //int note2 = int.Parse(Console.ReadLine());
            //Console.Write("Üçüncü notunuzu girin: ");
            //int note3 = int.Parse(Console.ReadLine());
            //int average = (note1 + note2 + note3) / 3;
            //if(average >= 80 && average <= 100) {
            //    Console.WriteLine("Ortalama: ({0}) A+",average);
            //} else if(average >= 60 &&  average <80)
            //{
            //    Console.WriteLine("Ortalama: ({0}) A",average);
            //} else if (average >= 40 && average< 60)
            //{
            //    Console.WriteLine("Ortalama: ({0}) B+",average);
            //}else if(average < 40)
            //{
            //    Console.WriteLine("Ortalama: ({0}) F", average);
            //}
            //else{ Console.WriteLine("Yanlış not girdiniz."); }

            //if ornek2
            //Console.WriteLine("Nasıl bir işlem yapmak istiyorsunuz; ");
            //Console.WriteLine("1- Bakiye Görüntüleme");
            //Console.WriteLine("2- Para Çekme");
            //Console.WriteLine("3- Para Yatırma");
            //Console.WriteLine("4 (çıkış)");
            //int choice = Convert.ToInt32(Console.ReadLine());
            //int balance = 4567;
            //switch (choice)
            //    {
            //        case 1:
            //            Console.WriteLine("Bakiyeniz: " + balance);
            //            break;
            //        case 2:
            //            Console.WriteLine("Çekmek istediğiniz para miktarını giriniz: ");
            //            int money_withdraw = int.Parse(Console.ReadLine());
            //            if (money_withdraw > balance)
            //            {
            //                Console.WriteLine("Lütfen uygun bir tutar girin.");
            //                break;
            //            }
            //            Console.WriteLine("Kalan Paranız: " + (balance - money_withdraw));
            //            break;
            //        case 3:
            //            Console.WriteLine("Yatırmak istediğniz miktarı girin: ");
            //            int money_deposit = int.Parse(Console.ReadLine());
            //            Console.WriteLine("Toplam tutar: " + (money_deposit + balance));
            //            break;
            //        case 4: Console.WriteLine("Çıkış Yapıldı");
            //        break;
            //        default:
            //            Console.WriteLine("Yanlış tuşlama yapıldı.");
            //            break;}

            // if ornek3
            //Console.WriteLine("Boyunuz:");
            //double height = double.Parse(Console.ReadLine());
            //Console.WriteLine("Kilonuz:");
            //double weight = double.Parse(Console.ReadLine());
            //double mass_index = weight / (height*height);
            //if (mass_index <= 18)
            //{
            //    Console.WriteLine("Beden kitle indeksiniz: {0},Zayıf",mass_index);
            //} else if (mass_index > 18 && mass_index<= 25) 
            //{
            //    Console.WriteLine("Beden kitle indeksiniz: {0},Normal",mass_index);
            //} else if (mass_index > 25)
            //{ 
            //    Console.WriteLine("Beden kitle indeksiniz: {0},Obez",mass_index);
            //}
            //else
            //{
            //    Console.WriteLine("Lütfen Boy ve kilonuzu doğru girdiğinden emin olun");
            //}

        }
    }
}