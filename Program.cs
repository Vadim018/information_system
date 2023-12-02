using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace O4
{
    class Program
    {
        static void Main(string[] args)
        {
            DBItem<Product> product = new DBItem<Product>();

            Product product1 = new Product("P1", 100);
            product.AddItem(product1);

            Product product2 = new Product("P2", 500);
            product.AddItem(product2);

            Product product3 = new Product("P3", 750);
            product.AddItem(product3);

            Product prod = product.FindbyId(1);

            Console.WriteLine(prod);

            bool isDone = product.Delete(prod);

            Console.WriteLine("DELETE: " + isDone);
        }
    }
}