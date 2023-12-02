using System;
using System.Collections.Generic;
using System.Text;
namespace O4
{
    class Product : IID
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public Product(string name, int price)
        {
            Name = name;
            Price = price;
        }
        public override string ToString()
        {
            return String.Format("ID: " + Id + " " + "NAME: " + Name + " " + "PRICE: " + Price);
        }
    }
}