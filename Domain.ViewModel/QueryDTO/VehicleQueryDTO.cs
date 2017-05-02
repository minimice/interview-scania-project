using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ViewModel
{
    public class VehicleQueryDTO<T,V> : IVehicleQueryDTO
    {
        public string CustomerAddress { get; set; }

        public int CustomerId { get; set; }

        public string CustomerName { get; set; }

        public string RegistrationNumber { get; set; }

        public string Status { get; set; }

        public string VehicleId { get; set; }

        public VehicleQueryDTO(T customer, V customerVehicle)
        {
            Customer concreteCustomer = customer as Customer;
            if (concreteCustomer != null)
            {
                CustomerId = concreteCustomer.ID;
                CustomerAddress = concreteCustomer.Address;
                CustomerName = concreteCustomer.Name;
            }
            else
            {
                throw new NotImplementedException("Customer type is not recognised.");
            }

            CustomerVehicle concreteCustomerVehicle = customerVehicle as CustomerVehicle;
            if (concreteCustomerVehicle != null)
            {
                RegistrationNumber = concreteCustomerVehicle.RegistrationNumber;
                Status = concreteCustomerVehicle.Status;
                VehicleId = concreteCustomerVehicle.VehicleId;
            }
            else
            {
                throw new NotImplementedException("Customer vehicle type is not recognised.");
            }
        }
    }
}
