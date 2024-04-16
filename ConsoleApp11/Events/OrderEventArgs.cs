using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DNSStore.Classes;

namespace DNSStore.Events
{

    // Класс для событий
    public class OrderEventArgs : EventArgs
    {
        public Order Order { get; set; }
    }
    public delegate void OrderEventHandler(object sender, OrderEventArgs e);
}