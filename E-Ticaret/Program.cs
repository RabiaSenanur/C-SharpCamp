namespace E_Ticaret
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.ProductCategory = "Ayakkabı";
            product1.ProductBrand = "Adidas";
            product1.ProductPrice = 1035.45;
            
            Product product2 = new Product();
            product2.ProductCategory = "Çanta";
            product2.ProductBrand = "Marjin";
            product2.ProductPrice = 199.99;

            Product product3 = new Product();
            product3.ProductCategory = "Aksesuar/Saat";
            product3.ProductBrand = "Daniel Klein";
            product3.ProductPrice = 749.00;

            Product[] products = new Product[] { product1, product2, product3 };

            for (int i = 0; i < products.Length; i++)
            {
                Console.Write("Ürün Kategorisi : " + products[i].ProductCategory + "   =>   ");
                Console.Write("Ürün Markası : " + products[i].ProductBrand + "   =>   ");
                Console.Write("Ürün Fiyatı : " + products[i].ProductPrice + "\n");

            }

            Console.Write("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            foreach (var product in products)
            {
                Console.Write("Ürün Kategorisi: "+ product.ProductCategory + "   =>   ");
                Console.Write("Ürün Markası: "+product.ProductBrand + "   =>   ");
                Console.Write("Ürün Fiyatı: "+product.ProductPrice + "\n");
            }
            Console.Write("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            int j = 0;
            while (j < products.Length){
                Console.Write("Ürün Kategorisi : " + products[j].ProductCategory + "   =>   ");
                Console.Write("Ürün Markası : " + products[j].ProductBrand + "   =>   ");
                Console.Write("Ürün Fiyatı : " + products[j].ProductPrice + "\n");
                j++;
            }
        }
    }
}

class Product
{
    public string ProductCategory { get; set; }
    public string ProductBrand { get; set; }
    public double ProductPrice { get; set; }
}