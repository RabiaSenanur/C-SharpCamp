namespace Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.Name = "Elma";
            product1.Price = 10;
            product1.Description = "Amasya Elması";
            product1.StockQuantity = 5;

            Product product2 = new Product();
            product2.Id = 2;
            product2.Name = "Karpuz";
            product2.Price = 20;
            product2.Description = "Diyarbakır Karpuzu";
            product2.StockQuantity = 3;

            Product[] products = new Product[] {product1, product2 };
            // type-safe -- tip güvenli
            foreach (Product product in products)
            {
                Console.Write(product.Id + ": ");
                Console.WriteLine(product.Name + "\nFiyatı: " + product.Price);
                Console.WriteLine("Ürün Açıklaması: " + product.Description);
                Console.WriteLine("-------------------------------");
            }
            Console.WriteLine("*****Methods******");
            // instance - örnek
            // encapsulation - kapsülleme(ürün classına yeni bir özellik eklendiğinde bütün siteleri etkilememesi için classlar kullanılır.)
            BasketManager basketManager = new BasketManager();
            basketManager.Add(product1);
            basketManager.Add(product2);
        }
    }
}