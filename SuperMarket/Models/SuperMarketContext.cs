using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarket.Models
{
    class SuperMarketContext : DbContext
    {
        public DbSet<EmployeeDetails> EmployeeDetails { get; set; }
    }
}
