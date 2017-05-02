using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Domain.Model.Tests
{
    /// <summary>
    /// Summary description for CustomerVehicleTest
    /// </summary>
    [TestClass]
    public class CustomerVehicleTest
    {
        [TestMethod]
        public void GivenValidCustomerVehiclePropertiesExpectCustomerVehicleObjectCreated()
        {
            int id = 1;
            string name = "Kalles Grustransporter AB";
            string address = "Cementvägen 8, 111 11 Södertälje";
            Customer customer = new Customer { Name = name, ID = id, Address = address, Vehicles = new System.Collections.Generic.List<CustomerVehicle>() };
            
            string vehicleId = "YS2R4X20005399401";
            string registrationNumber = "ABC123";
            CustomerVehicle customerVehicle = new CustomerVehicle { Customer = customer, RegistrationNumber = registrationNumber, VehicleId = vehicleId };
            customerVehicle.Customer.Vehicles.Add(customerVehicle); // Set up linkage
            Assert.AreEqual(customer.ID, id, "Customer id is not equal");
            Assert.AreEqual(customer.Vehicles[0].RegistrationNumber, registrationNumber, "Registration number is not equal");
            Assert.AreEqual(customer.Vehicles[0].VehicleId, vehicleId, "Vehicle ID is not equal");
        }
    }
}
