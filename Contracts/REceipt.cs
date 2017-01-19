using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    using Redis;

    public class Receipt
    {
        public Product Product { get; set; }

        public Customer Customer { get; set; }
    }
}
