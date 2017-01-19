using System.Collections.Generic;
using System.Web.Http;

namespace CommerceService.Controllers
{
    using System;
    using System.Net;
    using System.Net.Http;
    using System.Threading.Tasks;
    using System.Transactions;

    using Contracts;

    using EventManager;

    using NEventStore;
    using NEventStore.Dispatcher;
    using NEventStore.Persistence;
    using NEventStore.Persistence.Sql;
    using NEventStore.Persistence.Sql.SqlDialects;


    [ServiceRequestActionFilter]
    public class AuditController : BaseController
    {
        public async Task<HttpResponseMessage> Get(string correlationCode)
        {
            try
            {
                return this.Request.CreateResponse(HttpStatusCode.OK, "done");
            }
            catch (Exception e)
            {
                return this.Request.CreateResponse(HttpStatusCode.InternalServerError, e.ToString());
            }
        }
    }
}
