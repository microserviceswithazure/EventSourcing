using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    using Redis;

    public class Customer : DomainEntity
    {
        public Customer(CacheProxy cacheProxy)
            : base(cacheProxy)
        {
        }

        public Task Receive(Product product)
        {
            var receipts = this.CacheProxy.Get<List<Receipt>>("receipts") ?? new List<Receipt>();
            receipts.Add(new Receipt { Product = product, Customer = this });
            this.CacheProxy.Set("receipts", receipts);
            return Task.FromResult(1);
        }

        public string Name { get; set; }
    }
}
