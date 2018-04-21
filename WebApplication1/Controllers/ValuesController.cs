using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    public class ValuesController : ApiController
    {
        UnitOfWork unit = new UnitOfWork();

        public IEnumerable<Store> GetProducts()
        {
            return unit.Sql.ListAllStores();
        }

        public IEnumerable<Product> GetProducts(int id)
        {
            return unit.Sql.ListAllProducts(id);
        }
    }
}
