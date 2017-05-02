using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace DataAccess.Tests
{
    [TestClass]
    public class FactoryTest
    {
        [TestMethod]
        public void GivenFactoryFileStoreExpectFileStoreReturned()
        {
            Factory factory = new Factory();
            IStore fileStore = factory.GetStore(typeof(FileStore));
            Assert.AreEqual(fileStore.GetCustomers().Count, 1, "Customers do not match");
            Assert.AreEqual(fileStore.GetCustomers()[0].Vehicles.Count, 3, "Vehicle count does not match");
        }

        [TestMethod]
        public void GivenFactoryDbStoreExpectDbStoreReturned()
        {
            Factory factory = new Factory();
            IStore dbStore = factory.GetStore(typeof(DatabaseStore));
            Assert.AreEqual(dbStore.GetCustomers().Count, 3, "Customers do not match, have you run the init.sql script?");
            Assert.AreEqual(dbStore.GetCustomers().FirstOrDefault(customer => customer.ID == 1).Vehicles.Count, 3, "Vehicle count for customer 1 does not match");
            Assert.AreEqual(dbStore.GetCustomers().FirstOrDefault(customer => customer.ID == 2).Vehicles.Count, 2, "Vehicle count for customer 2 does not match");
            Assert.AreEqual(dbStore.GetCustomers().FirstOrDefault(customer => customer.ID == 3).Vehicles.Count, 2, "Vehicle count for customer 3 does not match");
        }
    }
}
