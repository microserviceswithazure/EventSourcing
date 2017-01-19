﻿using System.Collections.Generic;
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
    public class ShippingController : BaseController
    {
        public async Task<HttpResponseMessage> Post(string productName, string warehouseName, string customerName)
        {
            try
            {
                var product = new Product(this.CacheProxy) { Name = productName };
                var wareHouse = new Warehouse(this.CacheProxy) { Name = warehouseName };
                var customer = new Customer(this.CacheProxy) { Name = customerName };
                await this.EventProcessor.Process(new ShipFromWareHouseEvent(DateTime.UtcNow, product, wareHouse, customer));
                return this.Request.CreateResponse(HttpStatusCode.OK, "done");
            }
            catch (Exception e)
            {
                return this.Request.CreateResponse(HttpStatusCode.InternalServerError, e.ToString());
            }
        }
    }
}