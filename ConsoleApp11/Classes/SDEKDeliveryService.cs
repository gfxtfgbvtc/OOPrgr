using DNSStore.Interfaces;
using DNSStore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNSStore.Classes
{
    public class SDEKDeliveryService : IDeliveryService
    {
        public void DeliverOrder(Order order)
        {
            Console.WriteLine($"Заказ доставлен СДЭК по адресу {order.DeliveryAddress}");
        }
    }
}
