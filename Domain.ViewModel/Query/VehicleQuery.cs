using DAL = DataAccess;
using Domain.ViewModel;
using System.Linq;
using System.Collections.Generic;

namespace Domain.Query
{
    public class VehicleQuery : IVehicleQuery
    {
        public IEnumerable<IVehicleQueryDTO> ShowAllResults(DAL.IStore store)
        {
            List<DAL.Customer> dalCustomers = store.GetCustomers();
            return Converter.ConvertToDTOCollection(dalCustomers);
        }

        public IEnumerable<IVehicleQueryDTO> ShowResultsForCustomer(DAL.IStore store, int customerId)
        {
            List<DAL.Customer> dalCustomers = store.GetCustomers().Where(customer => customer.ID == customerId).ToList();
            return Converter.ConvertToDTOCollection(dalCustomers);
        }

        public IEnumerable<IVehicleQueryDTO> ShowResultsForStatus(DAL.IStore store, string status)
        {
            List<DAL.Customer> dalCustomers = new List<DAL.Customer>();
            foreach (DAL.Customer dalCustomer in store.GetCustomers())
            {
                List<DAL.CustomerVehicle> customerVehicles = dalCustomer.Vehicles.Where(vehicle => vehicle.Status == status).ToList();
                if (customerVehicles.Any())
                {
                    DAL.Customer customer = new DAL.Customer();
                    customer.ID = dalCustomer.ID;
                    customer.Name = dalCustomer.Name;
                    customer.Address = dalCustomer.Address;
                    customer.Vehicles = customerVehicles;
                    dalCustomers.Add(customer);
                }
            }
            return Converter.ConvertToDTOCollection(dalCustomers);
        }
    }
}
