using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Dictionary
{
    class Dictionary
    {
        public static void Main()
        {
            Customer Customer1 = new Customer()
            {
                ID = 101,
                Name = "Mark",
                Salary = 5000
            };
            Customer Customer2 = new Customer()
            {
                ID = 102,
                Name = "Maria",
                Salary = 10000
            };
            Customer Customer3 = new Customer()
            {
                ID = 103,
                Name = "Lava",
                Salary = 6000
            };

            Dictionary<int, Customer> dictionaryCustomers = new Dictionary<int, Customer>();
            dictionaryCustomers.Add(Customer1.ID, Customer1);
            dictionaryCustomers.Add(Customer2.ID, Customer2);
            dictionaryCustomers.Add(Customer3.ID, Customer3);

           Customer Customer101 =  dictionaryCustomers[101];

          //  Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", Customer101.ID, Customer101.Name, Customer101.Salary );
           
            foreach(KeyValuePair<int, Customer> CustomerKeyValuePair in dictionaryCustomers)
            {
                Console.WriteLine("ID = {0}", CustomerKeyValuePair.Key);
                Customer cust = CustomerKeyValuePair.Value;
                Console.WriteLine("ID - {0}, Name - {1}, Salary - {2}", cust.ID, cust.Name, cust.Salary);
                Console.WriteLine("______________________________________________________________");
            }
            Console.ReadLine();
        }
    }
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }
}
