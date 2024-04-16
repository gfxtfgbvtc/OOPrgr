using DNSStore.Classes;
using DNSStore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNSStore.Interfaces
{
    public interface IDeliveryService
    {
        void DeliverOrder(Order order);
    }
}
