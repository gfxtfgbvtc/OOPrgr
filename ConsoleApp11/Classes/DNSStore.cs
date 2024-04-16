using DNSStore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DNSStore.Interfaces;
using DNSStore.Classes;
using DNSStore.Events;

namespace DNSStore.Classes
{
    public class DNSStore
    {
        private List<IProduct> _products;
        public event OrderEventHandler OrderPlaced;

        public DNSStore()
        {
            _products = new List<IProduct>();
        }

        public void AddProduct(IProduct product)
        {
            _products.Add(product);
        }

        public List<IProduct> GetProducts()
        {
            return _products;
        }

        public void PlaceOrder(Order order)
        {
            OrderEventArgs e = new OrderEventArgs()
            {
                Order = order
            };

            OrderPlaced?.Invoke(this, e);
        }

        public void GetWarehouseInfo()
        {
            Console.WriteLine("Информация по складу техники:");
            foreach (IProduct product in _products)
            {
                if (product.GetType() == "Техника")
                {
                    Console.WriteLine($"\t{product.Name} - {product.Price}");
                }
            }
        }
    }
}