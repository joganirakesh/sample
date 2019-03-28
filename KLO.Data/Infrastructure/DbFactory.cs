using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KLO.Data.Infrastructure
{
    public class DbFactory:Disposable, IDbFactory
    {
        KLOEntities dbContext;

        public KLOEntities Init()
        {
            return dbContext ?? (dbContext = new KLOEntities());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}
