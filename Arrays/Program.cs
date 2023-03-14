namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int[] numbers = new int[4];

            numbers[0] = 10;
            numbers[1] = 20;
            numbers[2] = 30;
            numbers[3] = 40;
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            string[] names = { "Enes", "Esma", "Sena", "Furkan" };

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
            double[] doeble_num = { 1.44, 7.66, 8.34, 10.5 };

            for (int i = 0; i < doeble_num.Length; i++)
            {
                Console.WriteLine(doeble_num[i]);
            }

            char[] chars = { 'a', 'b', 'c', };

            for (int i = 0; i < chars.Length; i++)
            {
                Console.WriteLine(chars[i]);
            }

            int[] numbers = new int[4];

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("Sayilar dizisinin " + (i + 1) + ". index değerini girin: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine("Bir sayi girin:");
            int[] numbers = { 10, 10, 20, 30, 20, 30, 40, 50, 40, 50, 70, 55, 65, 70, 55, 65, 5, 20, 35, 65, 5, 20, 35, 65, 80 };

            int num = int.Parse(Console.ReadLine());
            int i = 0;
            foreach (var number in numbers)
            {
                if (number == num)
                {
                    i++;
                }
            }
            if (i == 0)
            {
                Console.WriteLine(num + " sayısından dizide bulunmamaktadır");
            }
            else
            {
                Console.WriteLine(" {0} sayısından sayilar dizisinde {1} tane bulunmaktadır.", num, i);
            }
            Console.WriteLine("10 elemalı bir dizi oluşturalım.");
            int[] numbers = new int[10];

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write((i + 1) + ". Elemean: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }
            int even_num = 0;
            int even_total = 0;
            int odd_num = 0;
            int odd_total = 0;
            foreach (var num in numbers)
            {
                if (num % 2 == 0)
                {
                    even_num++;
                    even_total += num;
                }
                else if (num % 2 == 1)
                {
                    odd_num++;
                    odd_total += num;
                }
            }
            Console.WriteLine("Tek sayıların adedi: " + odd_num);
            Console.WriteLine("Çift sayıların adedi: " + even_num);
            if (even_total > odd_total)
            {
                Console.WriteLine("Çift sayıların toplamı ({0}) tek sayıların toplamından ({1}) büyüktür.", even_total, odd_total);
            }
            else
            {
                Console.WriteLine("Tek sayıların toplamı {0} çift sayıların toplamından {1} büyüktür.", even_total, odd_total);
            }
            //Çok boyutlu diziler
            string[,] regions = new string[5, 3]
            {
                {"İstanbul","İzmit","Balıkesir"},
                {"Ankara","Konya","Kırıkkale"},
                {"Antalya","Adana","Mersin"},
                {"Rize","Trabzon","Samsun"},
                {"İzmir","Muğla","Manisa"}
            };
            for (int i = 0; i <= regions.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.Write(regions[i, j] + "  ");
                }
                Console.WriteLine("\n*************************");
            }*/
        }   
    }
}