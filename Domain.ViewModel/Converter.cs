using DAL = DataAccess;
using Domain.Model;
using System.Collections.Generic;

namespace Domain.ViewModel
{
    internal static class Converter
    {
        internal static IEnumerable<IVehicleQueryDTO> ConvertToDTOCollection(IEnumerable<DAL.Customer> dalCustomers)
        {
            List<IVehicleQueryDTO> vehicleQueryDTOList = new List<IVehicleQueryDTO>();
            // Prepare DTO object
            foreach (DAL.Customer dalCustomer in dalCustomers)
            {
                Customer customer = new Customer();
                customer.ID = dalCustomer.ID;
                customer.Name = dalCustomer.Name;
                customer.Address = dalCustomer.Address;
                customer.Vehicles = new List<CustomerVehicle>();

                foreach (DAL.CustomerVehicle dalCustomerVehicle in dalCustomer.Vehicles)
                {
                    CustomerVehicle vehicle = new CustomerVehicle();
                    vehicle.Customer = customer;
                    vehicle.RegistrationNumber = dalCustomerVehicle.RegistrationNumber;
                    vehicle.Status = dalCustomerVehicle.Status;
                    vehicle.VehicleId = dalCustomerVehicle.VehicleId;
                    customer.Vehicles.Add(vehicle);

                    vehicleQueryDTOList.Add(new VehicleQueryDTO<Customer, CustomerVehicle>(customer, vehicle));
                }
            }
            return vehicleQueryDTOList;
        }
    }
}
