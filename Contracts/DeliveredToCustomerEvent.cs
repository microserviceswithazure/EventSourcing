using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    using System.Net.Sockets;

    public class DeliveredToCustomerEvent : DomainEvent
    {
        public Warehouse Warehouse { get; set; }
        private Customer Customer { get; set; }

        public Product Product { get; set; }

        public DeliveredToCustomerEvent(string correlationId, DateTime occurred)
            : base(correlationId, occurred)
        {

        }

        public override Task Process()
        {
            return Customer.Receive(Product, Warehouse);
        }
    }
}
