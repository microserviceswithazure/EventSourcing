namespace Contracts
{
    using System;
    using System.Threading.Tasks;

    public class AddToInventoryEvent : DomainEvent
    {
        public AddToInventoryEvent(string correlationId, DateTime occurred, Product product, Warehouse warehouse)
            : base(correlationId, occurred)
        {
            this.Product = product;
            this.Warehouse = warehouse;
        }

        public Product Product { get; set; }

        public Warehouse Warehouse { get; set; }

        public override async Task Process()
        {
            await this.Warehouse.AddToInventory(this.Product);
        }
    }
}