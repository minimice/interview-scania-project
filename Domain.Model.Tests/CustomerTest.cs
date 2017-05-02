using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain.Model;

namespace Domain.Model.Tests
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void GivenValidCustomerPropertiesExpectCustomerObjectCreated()
        {
            int id = 1;
            string name = "Kalles Grustransporter AB";
            string address = "Cementvägen 8, 111 11 Södertälje";
            Customer customer = new Customer { Name = name, ID = id, Address = address, Vehicles = new System.Collections.Generic.List<CustomerVehicle>() };
            Assert.AreEqual(customer.Name, name, "Name is not equal");
            Assert.AreEqual(customer.Address, address, "Address is not equal");
            Assert.AreEqual(customer.ID, id, "ID is not equal");
            Assert.AreEqual(customer.Vehicles.Count, 0, "Vehicle count is not 0");
        }
    }
}
