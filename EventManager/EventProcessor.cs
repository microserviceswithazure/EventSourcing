namespace EventManager
{
    using System;
    using System.Threading.Tasks;
    using System.Transactions;

    using Contracts;

    using NEventStore;

    public class EventProcessor
    {
        private readonly string connectionString;

        public EventProcessor(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public async Task Process(DomainEvent @event)
        {
            using (var scope = new TransactionScope())
            {
                using (var store = Initializtion.InitEventStore(this.connectionString))
                {
                    await @event.Process();
                    using (var stream = store.OpenStream(@event.Id, 0))
                    {
                        stream.Add(new EventMessage { Body = @event });
                        stream.CommitChanges(Guid.NewGuid());
                    }
                }

                scope.Complete();
            }
        }
    }
}