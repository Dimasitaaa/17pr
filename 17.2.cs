using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17._2
{
    class Program
    {
        static void Main(string[] args)
        {
            var order1 = new Order(1001, 1500.50m);
            var order2 = order1;
            order2.Total = 2000.00m;
            Console.WriteLine(order1.Total);
        }
    }
    class Order
    {
        public int Id { get; set; }
        public decimal Total { get; set; }
        public Order(int id, decimal total)
        {
            Id = id;
            Total = total;
        }
    }
}
