using System.ComponentModel.Design;
using System.Runtime.InteropServices;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Add();
            //int number1 = 20;
            //int number2 = 100;
            //var result = Add2(10, 20);
            //Console.WriteLine(result);
            //var result2 = Add3(10);// 2.Parametre gerekmediği durumlarda böyle fonksiyonlar kullanılır.
            //Console.WriteLine(result2);
            //var result3 = Add4(ref number1, number2);// number1 değişkeni Add4 fonksiyonu içinde yerel değişken olarak yazılıp yeni bir değer atandığı için o değeri toplayıp yazdırır.
            //// number1 değişkeninin başına ref yazılırsa hem ana fonsiyon ve Add4 fonksiyonunda o zaman değişkenin değişiminden ana fonksiyonda etkilenir
            //// ref yerine out kullanılıdığında ise refden farkı number1 değişkenine önceden atama yapmış olma şartı aranmaz.
            //// out' un ref'den bir farkı da out kullanıldığında Add4 fonksiyonunda number1 değişkenine değer atanma şartı vardır 
            //Console.WriteLine(result3);
            //Console.WriteLine(number1); // burada ise ana foksiyonda atanan değeri yazdırır. (ref yazılmadan önce 20 çıktısı verir ref yazıldıktan sonra 30 çıktısını verir)
            //var result4 = Add5(out number1, number2);
            //Console.WriteLine(result4);
            //Console.WriteLine(Multiply(2,8));
            //Console.WriteLine(Multiply(2, 8, 5));
            //var result5 = Add6(1, 5, 7);
            //Console.WriteLine(result5);
            //Console.WriteLine("Bir sayı giriniz: ");
            //int enter_num = int.Parse(Console.ReadLine());
            //int square_num = Square(enter_num);
            //if (square_num > 25)
            //{
            //    Console.WriteLine("Sayının karesi 25'ten büyüktür.");
            //}
            //else
            //{
            //    Console.WriteLine("Sayının karesi 25'ten küçüktür veya eşittir.");
            //}
            //Console.WriteLine("Bir sayı giriniz: ");
            //int number = int.Parse(Console.ReadLine());
            //isEvenOrOddNum(number);
            //Console.Write("Birinci sayıyı girin: ");
            //int number1 = int.Parse(Console.ReadLine());
            //Console.Write("İkinci sayıyı girin: ");
            //int number2 = int.Parse(Console.ReadLine());
            //isBigOrSmall(number1, number2);
            //Console.WriteLine("Birinci sayıyı girin: ");
            //int num1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("İkinci sayıyı girin: ");
            //int num2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Girdiğiniz sayılar arasındaki asal sayılar");
            //findPrime(num1, num2);

            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            List<int> primeList = findPrime(num1, num2);
            foreach (var item in primeList)
            {
                Console.Write(item + " ");
            }
        }
            // advance
            static List<int> findPrime(int num1, int num2)
            {
                List<int> prime = new List<int>();
                for (int num = num1; num <= num2; num++)
                {
                    bool isPrime = true;
                    if (num > 1)
                    {
                        for (int i = 2; i < num; i++)
                        {
                            if (num % i == 0)
                            {
                                isPrime = false;
                                break;
                            }
                        }
                    }
                    else
                    {
                        isPrime = false;
                    }
                    if (isPrime)
                    {
                        prime.Add(num);
                    }
                }
                return prime;
            }
        //static void findPrime (int num1, int num2)
        //{
        //    for (int i = num1; i <= num2; i++)
        //    {
        //        bool isPrime = true;
        //        for ( int j = 2; j <= Math.Sqrt(i); j++) // math.sqrt
        //        {
        //            if( i % j == 0 )
        //            {
        //                isPrime = false;
        //                break;        
        //            }
        //        }
        //        if (isPrime && i > 1)
        //        {
        //            Console.WriteLine(i + " ");
        //        }
        //    }
        //}
        //static void isBigOrSmall(int number1, int number2)
        //{
        //    if (number1 > number2) 
        //    {
        //        Console.WriteLine("Birinci sayı ikinci sayıdan büyüktür.");
        //    } else if (number1 < number2)
        //    {
        //        Console.WriteLine("İkinci sayı birinci sayıdan büyüktür.");
        //    } else
        //    {
        //        Console.WriteLine("Girilen sayılar eşittir.");
        //    }
        //}
        //static void isEvenOrOddNum(int num)
        //{
        //    if (num %2 == 0)
        //    {
        //        Console.WriteLine("Girdiğiniz sayı çiftir.");
        //    }
        //    else if (num %2 == 1)
        //    {
        //        Console.WriteLine("Girdiğiniz sayi tektir.");
        //    }

        //}
        //static int Square(int n)
        //{
        //    return n * n;
        //}
        //static void Add() 
        //{
        //    Console.WriteLine("Added!");
        //}
        //static int Add2(int number1, int number2)
        //{
        //    var result = number1 + number2;
        //    return result;
        //}
        //// default parametreli fonsiyon
        //static int Add3(int number1, int number2=10)
        //{
        //    var result = number1 + number2;
        //    return result;
        //}
        //static int Add4(ref int number1, int number2)
        //{
        //    number1 = 30;// zorunlu değildir
        //    return number1 + number2;
        //}
        //static int Add5(out int number1, int number2)
        //{
        //    number1 = 30; // zorunludur
        //    return number1 + number2;
        //}
        //static int Add6(params int[] numbers)
        //{
        //    return numbers.Sum();
        //}
        //static int Multiply(int number1, int number2)
        //{
        //    return number1 * number2;
        //}
        //static int Multiply(int number1, int number2, int number3)
        //{
        //    return number1 * number2 * number3; // method overloading
        //}
    }
}