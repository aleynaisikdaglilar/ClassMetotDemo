using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.Tc = 44447898965;
            customer1.Name = "Aleyna";
            customer1.Surname = "Işık";
            customer1.Phone = 05553339999;
            customer1.Address = "Eskişehir";

            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.Tc = 22255588975;
            customer2.Name = "Aslı";
            customer2.Surname = "Şen";
            customer2.Phone = 04445559696;
            customer2.Address = "Ankara";

            Customer[] customers = new Customer[] {customer1,customer2 };

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.List(customers);
            customerManager.Delete(customer1);
        }
    }
}
