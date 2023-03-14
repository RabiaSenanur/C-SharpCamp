namespace HomeworkVideoDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Value Types 
            bool condition = false;// true or false
            byte maxValue = byte.MaxValue;
            byte minValue = byte.MinValue;
            byte number4 = 9; // 0<= byte(x) < 2^8
            short number3 = 23; // -2^15 <= short(x) < 2^15 2byte yer kaplar
            int number1 = 256; //-2^31 <= int(x) < 2^31 4 byte(32 bit) yer kaplar 
            long number2 = 2345678;// long : integer'ın 2 katı (8 byte) yer kaplar bellekte ve daha büyük sayıları da alır.
            float number8 = 23.45f; // 4 byte yer kaplar double'dan farkı sonuna 'f' alır.
            double number5 = 10.4;
            decimal number6 = 10.4345678M;// noktadan sonra daha fazla basamak kullanılabilir.
            var number7 = 10;
            number7 = 'A';// var ilk olarak int olarak atandığı için daha sonra karakter atadığımızda karakterin ASCII kodunu atar.

            char character = 'a';
            string city = "Bursa"; // dizidir
            Console.WriteLine(maxValue);
            Console.WriteLine(minValue);
            Console.WriteLine("Number is {0}", number1);
            Console.WriteLine("Number is {0}", number2);
            Console.WriteLine("Number is {0}", number3);
            Console.WriteLine("Number is {0}", number4);
            Console.WriteLine("Number is {0}", number5);
            Console.WriteLine("Number is {0}", number6);
            Console.WriteLine("Number is {0}", number7);
            Console.WriteLine("Number is {0}", number8);
            Console.WriteLine("Character is {0}",character);
            Console.WriteLine("ASCII value of Character is {0}",(int)character);
            Console.WriteLine(Days.Monday);
            Console.WriteLine((int)Days.Sunday);


            }
            }

            enum Days
            {
            Monday,Tuesday,Wednesday,Thursday,Friday,Saturday,Sunday   
            }


            //var number = 10;
            //if(number == 10) 
            //{
            //    Console.WriteLine("Number is 10");
            //}
            //else if (number == 20)
            //{
            //    Console.WriteLine("Number is 20");
            //}
            //else
            //{
            //    Console.WriteLine("Number is not 10 or 20");
            //}

            //char choice = 'A';
            //switch (choice)
            //{
            //    case 'A':
            //        Console.WriteLine("Correct Answer");
            //        break;
            //    case 'B':
            //        Console.WriteLine("Wrong Answer");
            //        break;
            //    case 'C':
            //        Console.WriteLine("Correct Answer");
            //        break;
            //    case 'D':
            //        Console.WriteLine("Correct Answer");
            //        break;
            //    default: Console.WriteLine("Wrong Letter");
            //        break;
            //}

            //if (number >= 0 && number<= 100) 
            //{
            //    Console.WriteLine("Number is between 0-100");
            //}
            //else if (number > 100 && number <= 200)
            //{
            //    Console.WriteLine("Number is between 101-200");
            //}
            //else if(number > 200 || number < 0)
            //{
            //    Console.WriteLine("Number is less than 0 or greater than 200");
            //}
            //if (number <= 100) 
            //{
            //    if (number >= 85)
            //    {
            //        Console.WriteLine("Your Point: AA");
            //    }
            //    else if (number >= 70)
            //    {
            //        Console.WriteLine("Your Point: BA");
            //    }
            //    else if(number >= 60)
            //    {
            //        Console.WriteLine("Your Point: BB");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Your Point is wrong");
            //}
        }
