using System.Runtime.InteropServices;

namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string city = "Ankara";

            //foreach (var s in city)
            //{
            //    Console.WriteLine(s);
            //}

            //string city2 = "İstanbul";
            //string result = city + city2;
            //Console.WriteLine(result);

            //string result1 = String.Format("{0} {1}",city,city2);
            //Console.WriteLine(result1);

            //String Methodlar
            string sentence = "My name is Rabia İslamoğlu";
            var result = sentence.Length;
            var result2 = sentence.Clone();
            sentence = "My name is Esma İslamoğlu";
            var result3 = sentence.EndsWith("u");
            var result4 = sentence.StartsWith("My name");
            var result5 = sentence.IndexOf("name");// bulunan ilk indexi verir : 3
            var result6 = sentence.LastIndexOf(" ");// sondan başlayarak bulunan ilk indeksi verir
            var result7 = sentence.Insert(0, "Hello, ");
            var result8 = sentence.Substring(0, 7);
            var result9 = sentence.ToLower();
            var result10 = sentence.ToUpper();
            var result11 = sentence.Replace(" ","-");
            var result12 = sentence.Remove(0, 4);
            Console.WriteLine(result);
            Console.WriteLine(result2);
            Console.WriteLine(result3);
            Console.WriteLine(result4);
            Console.WriteLine(result5);
            Console.WriteLine(result6);
            Console.WriteLine(result7);
            Console.WriteLine(result8);
            Console.WriteLine(result9);
            Console.WriteLine(result10);
            Console.WriteLine(result11);
            Console.WriteLine(result12);
            
        }
    }
}