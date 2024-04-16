using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DNSStore;
using DNSStore.Classes;
using DNSStore.Interfaces;

namespace DNSStore.Classes
{
    public class Product : IProduct
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public string GetType()
        {
            return "Техника";
        }
    }
}
