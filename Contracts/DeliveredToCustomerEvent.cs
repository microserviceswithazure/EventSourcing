using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    using System.Net.Sockets;

    using Newtonsoft.Json.Linq;

    public class DeliveredToCustomerEvent : DomainEvent
    {
        public Customer Customer { get; set; }

        public Product Product { get; set; }

        public DeliveredToCustomerEvent(Product product, Customer customer, DateTime occurred) : base(product.Id, occurred)
        {
            this.Product = product;
            this.Customer = customer;
        }

        public override async Task<JObject> Process()
        {
            Customer.Receive(Product);
            return JObject.FromObject(1);
        }
    }
}
