using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    public class UnitOfWork
    {
        FirstTaskEntities context = new FirstTaskEntities();

        public SQLRepository sql;

        public SQLRepository Sql
        {
            get
            {
                if (sql == null)
                    sql = new SQLRepository(context);
                return sql;
            }

        }

        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}