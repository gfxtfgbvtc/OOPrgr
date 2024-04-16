using DNSStore.Interfaces;
using DNSStore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNSStore.Classes
{
    public class User
    {
        public string Name { get; set; }
        public List<IProduct> Cart { get; set; }
        public string Email { get; set; }

        public User(string name, string email)
        {
            Name = name;
            Email = email;
            Cart = new List<IProduct>();
        }

        public void AddToCart(IProduct product)
        {
            Cart.Add(product);
        }

        public void RemoveFromCart(IProduct product)
        {
            Cart.Remove(product);
        }

        public void PlaceOrder(DNSStore store, IDeliveryService deliveryService, string deliveryAddress)
        {
            Order order = new Order()
            {
                Products = Cart,
                TotalPrice = Cart.Sum(p => p.Price),
                DeliveryService = deliveryService,
                DeliveryAddress = deliveryAddress
            };

            store.PlaceOrder(order);
            Cart.Clear();

            SendReceipt(order);
        }

        private void SendReceipt(Order order)
        {
            // Отправка чека на электронную почту
            Console.WriteLine($"Чек отправлен на электронную почту {Email}");
        }
    }
}

