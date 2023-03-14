namespace ClassMethotDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.Name = "Rabia";
            customer1.Surname = "İslamoğlu";
            customer1.Address = "Ankara";

            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.Name = "Engin";
            customer2.Surname = "Demiroğ";
            customer2.Address = "Diyarbakır";

            // Customer[] customers = new Customer[] { customer1, customer2 };
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);

            customerManager.Listed(customer1);
            customerManager.Listed(customer2);

            customerManager.Delete(customer1);

        }
    }
}