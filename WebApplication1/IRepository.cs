using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication1
{
    interface IRepository
    {
        List<Store> ListAllStores();

        List<Product> ListAllProducts(int id);
    }
}
