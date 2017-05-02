using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ViewModel
{
    public interface IVehicleQueryDTO
    {
        int CustomerId { get; set; }
        string CustomerName { get; set; }
        string CustomerAddress { get; set; }
        string VehicleId { get; set; }
        string RegistrationNumber { get; set; }
        string Status { get; set; }
    }
}
