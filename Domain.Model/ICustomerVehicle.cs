using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    internal interface ICustomerVehicle
    {
        string VehicleId { get; set; }
        string RegistrationNumber { get; set; }
        string Status { get; set; }
        Customer Customer { get; set; }
    }
}
