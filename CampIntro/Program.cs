using System;

namespace CampIntro 
{

class Program
{
    static void Main(string[] args)
    {
            string category_tag = "Kategori";
            int student_number = 32000;
            double interest_rate = 1.45;
            bool was_it_entered_thesystem = false;
            double dollar_today = 18.45;
            double dollar_yesterday = 18.35;

            if (dollar_yesterday > dollar_today)
            {
                Console.WriteLine("Azalış butonu");
            }
            else if (dollar_yesterday < dollar_today)
            {
                Console.WriteLine("Artış butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi");
            }

            if (was_it_entered_thesystem == true) 
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }
            Console.WriteLine(category_tag);


        }
    }
}