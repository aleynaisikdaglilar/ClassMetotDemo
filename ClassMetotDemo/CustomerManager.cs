using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Tebrikler " + customer.Id + " kişisi eklendi.");
        }
        public void List(Customer[] customers)
        {
            foreach (Customer customer in customers)
            {
                Console.WriteLine(customer.Id + " " + customer.Name + " " + customer.Surname + " " + customer.Tc + " " + customer.Phone + " " + customer.Address);
            }
        }
        public void Delete(Customer customer)
        {
            Console.WriteLine(customer.Id+" Silinmiştir.");
        }
    }
}
