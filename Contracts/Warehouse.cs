using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    using System.Collections;

    using Redis;

    public class Warehouse : DomainEntity
    {
        public Warehouse(CacheProxy cacheProxy)
            : base(cacheProxy)
        {
        }

        public string Name { get; set; }

        public Task AddToInventory(Product product)
        {
            var inventory = new List<Product>();
            //var inventory = this.CacheProxy.Get<List<Product>>("inventory") ?? new List<Product>();
            inventory.Add(product);
            return Task.FromResult(1);
        }

        public Task Ship(Product product, Customer customer)
        {
            var inventory = this.CacheProxy.Get<List<Product>>("inventory") ?? new List<Product>();
            var selectedProduct = inventory.FirstOrDefault(p => p.Name == product.Name);
            if (selectedProduct != null)
            {
                inventory.Remove(product);
            }

            return Task.FromResult(1);
        }
    }
}
