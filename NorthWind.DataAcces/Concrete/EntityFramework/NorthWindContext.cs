using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.DataAcces.Concrete.EntityFramework  

{
    public class NorthWindContext:DbContext
    {
        public DbSet<Nortwind.Entities.Product> Products { get; set; }

    }
}
