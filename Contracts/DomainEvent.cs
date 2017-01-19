namespace Contracts
{
    using System;
    using System.Threading.Tasks;

    public abstract class DomainEvent
    {
        DateTime recorded, occurred;
        internal DomainEvent(string correlationId, DateTime occurred)
        {
            this.Id = correlationId;
            this.occurred = occurred;
            this.recorded = DateTime.Now;
        }

        public string Id { get; set; }

        public abstract Task Process();
    }
}