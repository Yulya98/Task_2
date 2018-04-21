using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    public class SQLRepository : IRepository
    {
        FirstTaskEntities context;

        public SQLRepository(FirstTaskEntities dbcon)
        {
            context = dbcon;
        }

        public List<Store> ListAllStores()
        {
            List<Store> storesList = new List<Store>();

            IQueryable<Store> queryToDb = from u in context.Stores
                                          select u;
            foreach (Store s in queryToDb)
            {
                storesList.Add(new Store
                {
                    Id = s.Id,
                    NameOfStore = s.NameOfStore,
                    Addres = s.Addres,
                    OperatingMode = s.OperatingMode
                });
            }
            return storesList;
        }

        public List<Product> ListAllProducts(int id)
        {
            List<Product> productsList = new List<Product>();

            IQueryable<Product> queryProducts = from u in context.Products
                                                 where u.IdProducts == id
                                                 select u;

            foreach (Product s in queryProducts)
            {
                productsList.Add(new Product
                {
                    Id = s.Id,
                    NameOfProducts = s.NameOfProducts,
                    Description = s.Description
                });
            }
            return productsList;
        }
    }
}