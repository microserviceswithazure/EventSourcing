using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    using Redis;

    public class Product : DomainEntity
    {
        public Product(CacheProxy cacheProxy)
            : base(cacheProxy)
        {
        }

        public string Name { get; set; }

        public string Supplier { get; set; }
    }
}
