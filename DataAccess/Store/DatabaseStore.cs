using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;

namespace DataAccess
{
    public class DatabaseStore : DbContext, IStore
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<CustomerVehicle> CustomerVehicles { get; set; }

        public List<Customer> GetCustomers()
        {
            return Customers.Include("Vehicles").ToList();
        }
    }
}
