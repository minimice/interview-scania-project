using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataAccess;
using Domain.Query;
using System.Collections.Generic;

namespace Domain.ViewModel.Tests
{
    [TestClass]
    public class VehicleQueryTest
    {
        [TestMethod]
        public void GivenDefaultFactoryWithFileStoreExpectFileStoreDataTransformedAndReturned()
        {
            Factory factory = new Factory();
            IStore fileStore = factory.GetStore(typeof(FileStore));
            //IStore fileStore = factory.GetStore(typeof(DatabaseStore));
            VehicleQuery vehicleQuery = new VehicleQuery();
            List<IVehicleQueryDTO> vehicleQueryResults = new List<IVehicleQueryDTO>();
            vehicleQueryResults.AddRange(vehicleQuery.ShowAllResults(fileStore));
            Assert.AreEqual(vehicleQueryResults.Count, 3, "Result count does not match");
            Assert.AreEqual(vehicleQueryResults[0].CustomerName, "Kalles Grustransporter AB", "Customer name does not match");
            Assert.AreEqual(vehicleQueryResults[1].CustomerName, "Kalles Grustransporter AB", "Customer name does not match");
            Assert.AreEqual(vehicleQueryResults[2].CustomerName, "Kalles Grustransporter AB", "Customer name does not match");
        }

        [TestMethod]
        public void GivenDefaultFactoryWithFileStoreAndInvalidStatusExpectNoRecordsReturned()
        {
            Factory factory = new Factory();
            IStore fileStore = factory.GetStore(typeof(FileStore));
            VehicleQuery vehicleQuery = new VehicleQuery();
            List<IVehicleQueryDTO> vehicleQueryResults = new List<IVehicleQueryDTO>();
            vehicleQueryResults.AddRange(vehicleQuery.ShowResultsForStatus(fileStore,"NOT OK"));
            Assert.AreEqual(vehicleQueryResults.Count, 0, "Result count does not match");
        }

        [TestMethod]
        public void GivenDefaultFactoryWithFileStoreAndInvalidCustomerIdExpectNoRecordsReturned()
        {
            Factory factory = new Factory();
            IStore fileStore = factory.GetStore(typeof(FileStore));
            VehicleQuery vehicleQuery = new VehicleQuery();
            List<IVehicleQueryDTO> vehicleQueryResults = new List<IVehicleQueryDTO>();
            vehicleQueryResults.AddRange(vehicleQuery.ShowResultsForCustomer(fileStore, 2));
            Assert.AreEqual(vehicleQueryResults.Count, 0, "Result count does not match");
        }
    }
}
