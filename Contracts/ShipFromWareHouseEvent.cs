namespace Contracts
{
    using System;
    using System.Threading.Tasks;

    public class ShipFromWareHouseEvent : DomainEvent
    {
        public ShipFromWareHouseEvent(

            DateTime occurred,
            Product product,
            Warehouse warehouse,
            Customer customer, string correlationId = "")
            : base(correlationId, occurred)
        {
            this.Product = product;
            this.Warehouse = warehouse;
            this.Customer = customer;
        }

        public Customer Customer { get; set; }

        public Product Product { get; set; }

        public Warehouse Warehouse { get; set; }

        public override Task Process()
        {
            var product = this.Product.GetProductByName(Product.Name);
            this.Id = product.
            return this.Warehouse.Ship(this.Product, this.Customer);
        }
    }
}