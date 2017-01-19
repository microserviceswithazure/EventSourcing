namespace EventManager
{
    using System;
    using System.Threading.Tasks;
    using System.Transactions;

    using Contracts;

    using Newtonsoft.Json.Linq;

    using NEventStore;

    public class EventProcessor
    {
        private readonly string connectionString;

        public EventProcessor(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public async Task<JObject> Process(DomainEvent @event)
        {
            JObject result;
            using (var scope = new TransactionScope())
            {
                using (var store = Initializtion.InitEventStore(this.connectionString))
                {
                    result = await @event.Process();
                    using (var stream = store.OpenStream(@event.Id, 0))
                    {
                        stream.Add(new EventMessage { Body = @event });
                        stream.CommitChanges(Guid.NewGuid());
                    }
                }

                scope.Complete();
            }

            return result;
        }
    }
}