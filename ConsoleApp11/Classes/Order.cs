using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DNSStore.Interfaces;

namespace DNSStore.Classes
{
    public class Order
    {
        public List<IProduct> Products { get; set; }
        public decimal TotalPrice { get; set; }
        public IDeliveryService DeliveryService { get; set; }
        public string DeliveryAddress { get; set; }
    }
}