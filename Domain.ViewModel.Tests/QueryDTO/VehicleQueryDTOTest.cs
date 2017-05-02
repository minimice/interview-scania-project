using System;
using System.Text;
using System.Collections.Generic;
using Domain.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Domain.ViewModel.Tests
{
    /// <summary>
    /// Summary description for VehicleQueryDTO
    /// </summary>
    [TestClass]
    public class VehicleQueryDTOTest
    {
        [TestMethod]
        public void GivenCustomerAndVehicleInformationExpectDTOToBeReturned()
        {
            Customer customer = new Customer();
            customer.ID = 1;
            customer.Name = "ABC";
            customer.Address = "123 Johnny Road";
            List<CustomerVehicle> customerVehicleList = new List<CustomerVehicle>();
            customer.Vehicles = customerVehicleList;

            CustomerVehicle customerVehicle = new CustomerVehicle();
            customerVehicle.Customer = customer;
            customerVehicle.RegistrationNumber = "246";
            customerVehicle.Status = "OK";
            customerVehicle.VehicleId = "Scania";

            IVehicleQueryDTO vehicleQueryDTO = new VehicleQueryDTO<Customer, CustomerVehicle>(customer, customerVehicle);
            Assert.AreEqual(vehicleQueryDTO.CustomerId, 1, "ID is not equal");
            Assert.AreEqual(vehicleQueryDTO.CustomerName, "ABC", "Name is not equal");
            Assert.AreEqual(vehicleQueryDTO.CustomerAddress, "123 Johnny Road", "Address is not equal");
            Assert.AreEqual(vehicleQueryDTO.RegistrationNumber, "246", "Registration is not equal");
            Assert.AreEqual(vehicleQueryDTO.Status, "OK", "Status is not equal");
            Assert.AreEqual(vehicleQueryDTO.VehicleId, "Scania", "Vehicle id is not equal");
        }
    }
}
