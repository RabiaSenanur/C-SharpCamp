namespace ValueAndReferenceTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10;
            int num2 = 30;
            num1 = num2;
            num2 = 65;
            Console.WriteLine("sayı1 = "+num1);
            Console.WriteLine("sayı2 = "+num2);

            int[] numbers1 = new int[] { 10, 20, 30 };
            int[] numbers2 = new int[] { 100, 200, 300 };
            numbers1 = numbers2;// numbers1 'in adresi number2 nin adresi ile aynı olur. Bu yüzden tuttukları değerler her ikisinden birinde değişince bir diğerinde de depişmiş olur. 
            numbers2[0] = 999;
            Console.WriteLine(numbers1[0]);
        }
    }
}