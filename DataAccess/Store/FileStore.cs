using System.Collections.Generic;

namespace DataAccess
{
    public class FileStore : IStore
    {
        public List<Customer> GetCustomers()
        {
            List<Customer> customers = new List<Customer>();

            Customer customer = new Customer();
            customer.ID = 1;
            customer.Name = "Kalles Grustransporter AB";
            customer.Address = "Cementvägen 8, 111 11 Södertälje";
            List<CustomerVehicle> customerVehicleList = new List<CustomerVehicle>();
            customer.Vehicles = customerVehicleList;

            CustomerVehicle customerVehicle1 = new CustomerVehicle();
            customerVehicle1.Customer = customer;
            customerVehicle1.RegistrationNumber = "ABC123";
            customerVehicle1.Status = "OK";
            customerVehicle1.VehicleId = "YS2R4X20005399401";
            customerVehicleList.Add(customerVehicle1);

            CustomerVehicle customerVehicle2 = new CustomerVehicle();
            customerVehicle2.Customer = customer;
            customerVehicle2.RegistrationNumber = "DEF456";
            customerVehicle2.Status = "OK";
            customerVehicle2.VehicleId = "VLUR4X20009093588";
            customerVehicleList.Add(customerVehicle2);

            CustomerVehicle customerVehicle3 = new CustomerVehicle();
            customerVehicle3.Customer = customer;
            customerVehicle3.RegistrationNumber = "GHI789";
            customerVehicle3.Status = "OK";
            customerVehicle3.VehicleId = "VLUR4X20009048066";
            customerVehicleList.Add(customerVehicle3);

            customers.Add(customer);

            return customers;
        }
    }
}
